using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EMS.Common.Modbus.ModbusTCP;
using PCS_NEW.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace PCS_NEW.ViewModels
{
    public class MainViewModel: ObservableObject
    {
        public DCStatusViewModel dCStatusViewModel;
        public FaultViewModel faultViewModel;
        public pCSMonitorViewModel pCSMonitorViewModel;
        public PCSSettingViewModel pCSSettingViewModel;

        public ModbusClient modbusClient;
        public bool isRead = false;

        public Thread thread;

        private int DaqTimeSpan = 1;
        public RelayCommand ConnectCommand { get; set; }

        public RelayCommand StartDaqCommand { get; set; }

        public MainViewModel()
        {
            dCStatusViewModel = new DCStatusViewModel();
            faultViewModel = new FaultViewModel();
            pCSMonitorViewModel = new pCSMonitorViewModel();
            pCSSettingViewModel = new PCSSettingViewModel();

            ConnectCommand = new RelayCommand(Connect);
            StartDaqCommand = new RelayCommand(StartDaq);

            pCSMonitorViewModel.VisDCAlarm = Visibility.Hidden;
            pCSMonitorViewModel.VisPDSAlarm = Visibility.Hidden;
        }


        public void Connect()
        {
            try
            {
                if (pCSSettingViewModel.IsConnected == true)
                {
                    MessageBox.Show("已连接");
                }
                if (pCSSettingViewModel.IsConnected == false)
                {
                    PCSConView view = new PCSConView();
                    if (view.ShowDialog() == true)
                    {
                        string IP = view.IPText.AddressText;
                        int port = Convert.ToInt32(view.TCPPort.Text);
                        modbusClient = new ModbusClient(IP, port);
                        modbusClient.Connect();

                        pCSSettingViewModel.IsConnected = true;
                        pCSSettingViewModel.modbusClient = modbusClient;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("请输入正确的IP地址。");
            }
        }

        public void StartDaq()
        {
            if (pCSSettingViewModel.IsConnected==true)
            {
                thread = new Thread(ReadINFO);
                thread.IsBackground = true;

                isRead = true;
                thread.Start();
            }
            else
            {
                MessageBox.Show("请连接");
            }
        }

        public void ReadINFO()
        {
            while (true)
            {
                try
                {
                    if (!isRead)
                    {
                        break;
                    }

                    byte[] DCstate = modbusClient.ReadFunc(53026, 7);
                    dCStatusViewModel.ModuleOnLineFlag = BitConverter.ToUInt16(DCstate, 0);
                    dCStatusViewModel.ModuleRunFlag = BitConverter.ToUInt16(DCstate, 4);
                    dCStatusViewModel.ModuleAlarmFlag = BitConverter.ToUInt16(DCstate, 8);
                    dCStatusViewModel.ModuleFaultFlag = BitConverter.ToUInt16(DCstate, 12);

                    byte[] PCSData = modbusClient.ReadFunc(53005, 10);
                    pCSMonitorViewModel.AlarmStateFlagDC1 = BitConverter.ToUInt16(PCSData, 0);
                    pCSMonitorViewModel.AlarmStateFlagDC2 = BitConverter.ToUInt16(PCSData, 4);
                    pCSMonitorViewModel.AlarmStateFlagDC3 = BitConverter.ToUInt16(PCSData, 6);
                    pCSMonitorViewModel.AlarmStateFlagPDS = BitConverter.ToUInt16(PCSData, 8);
                    pCSMonitorViewModel.ControlStateFlagPCS = BitConverter.ToUInt16(PCSData, 10);
                    pCSMonitorViewModel.StateFlagPCS = BitConverter.ToUInt16(PCSData, 12);
                    pCSMonitorViewModel.DcBranch1StateFlag1 = BitConverter.ToUInt16(PCSData, 16);
                    pCSMonitorViewModel.DcBranch1StateFlag2 = BitConverter.ToUInt16(PCSData, 18);
                    
                    pCSMonitorViewModel.GetDCBranchINFO();

                    byte[] Temp = modbusClient.ReadFunc(53221, 3);
                    pCSMonitorViewModel.ModuleTemperature = Math.Round(BitConverter.ToUInt16(Temp, 0) * 0.1 - 20, 2);
                    pCSMonitorViewModel.AmbientTemperature = Math.Round(BitConverter.ToUInt16(Temp, 4) * 0.1 - 20, 2);

                    byte[] DCBranch1INFO = modbusClient.ReadFunc(53250, 10);
                    pCSMonitorViewModel.DcBranch1DCPower=Math.Round(BitConverter.ToUInt16(DCBranch1INFO,0)*0.1-1500,2);
                    pCSMonitorViewModel.DcBranch1DCVol = Math.Round(BitConverter.ToUInt16(DCBranch1INFO, 2) * 0.1, 2);
                    pCSMonitorViewModel.DcBranch1DCCur=Math.Round(BitConverter.ToUInt16(DCBranch1INFO,4)*0.1-2000, 2);
                    pCSMonitorViewModel.DcBranch1CharHigh = BitConverter.ToUInt16(DCBranch1INFO, 6);
                    pCSMonitorViewModel.DcBranch1CharLow = BitConverter.ToUInt16(DCBranch1INFO, 8);
                    pCSMonitorViewModel.DcBranch1DisCharHigh = BitConverter.ToUInt16(DCBranch1INFO, 10);
                    pCSMonitorViewModel.DcBranch1DisCharLow = BitConverter.ToUInt16(DCBranch1INFO, 12);
                    pCSMonitorViewModel.DcBranch1BUSVol = Math.Round(BitConverter.ToUInt16(DCBranch1INFO, 18)*0.1,2);

                    pCSMonitorViewModel.EnergyCal();

                    bool AlarmColorFlagDC = pCSMonitorViewModel.GetActiveDCState();
                    bool AlarmColorFlagPDS = pCSMonitorViewModel.GetActivePDSState();

                    dCStatusViewModel.CurrentTime=DateTime.Now;

                    App.Current.Dispatcher.Invoke(() =>
                    {
                        if (AlarmColorFlagDC == true)
                        {
                            pCSMonitorViewModel.VisDCAlarm = Visibility.Visible;
                            pCSMonitorViewModel.AlarmColorDC = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EE0000"));
                            
                        }
                        else
                        {
                            pCSMonitorViewModel.VisDCAlarm = Visibility.Hidden;
                        }

                        if (AlarmColorFlagPDS == true)
                        {
                            pCSMonitorViewModel.VisPDSAlarm = Visibility.Visible;
                            pCSMonitorViewModel.AlarmColorPDS = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#EE0000"));
                        }
                        else
                        {
                            pCSMonitorViewModel.VisPDSAlarm = Visibility.Hidden;
                        }
                        pCSMonitorViewModel.GetActivePCSControlState();
                        pCSMonitorViewModel.GetActivePCSState();
                        dCStatusViewModel.DaqDCModuleStatus();
                        pCSMonitorViewModel.GetActiveDCState();
                        pCSMonitorViewModel.GetActivePDSState();
                        //DaqDCModuleStatus(DCStatusModel);
                    });
                    Thread.Sleep(DaqTimeSpan * 1000);
                }
                catch (Exception ex)
                {

                }
            }
        }

        







    }
}
