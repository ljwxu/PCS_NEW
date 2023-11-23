using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using EMS.Common.Modbus.ModbusTCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PCS_NEW.ViewModels
{
    public class PCSSettingViewModel: ObservableObject
    {
        /// <summary>
        /// 时间年
        /// </summary>
        private double _year;

        public double Year
        {
            get => _year;
            set
            {
                SetProperty(ref _year, value);
            }
        }

        /// <summary>
        /// 时间月
        /// </summary>
        private double _month;

        public double Month
        {
            get => _month;
            set
            {
                SetProperty(ref _month, value);
            }
        }

        /// <summary>
        /// 时间日
        /// </summary>
        private double _day;

        public double Day
        {
            get => _day;
            set
            {
                SetProperty(ref _day, value);
            }
        }

        /// <summary>
        /// 时间小时
        /// </summary>
        private double _hour;

        public double Hour
        {
            get => _hour;
            set
            {
                SetProperty(ref _hour, value);
            }
        }

        /// <summary>
        /// 时间分钟
        /// </summary>
        private double _minute;

        public double Minute
        {
            get => _minute;
            set
            {
                SetProperty(ref _minute, value);
            }
        }

        /// <summary>
        /// 时间秒
        /// </summary>
        private double _second;

        public double Second
        {
            get => _second;
            set
            {
                SetProperty(ref _second, value);
            }
        }

        /// <summary>
        /// BMS通讯中断超时
        /// </summary>
        private double _bMSCMInterruptionTimeOut;

        public double BMSCMInterruptionTimeOut
        {
            get => _bMSCMInterruptionTimeOut;
            set
            {
                SetProperty(ref _bMSCMInterruptionTimeOut, value);
            }
        }

        /// <summary>
        /// 远程485通信中断超时
        /// </summary>
        private double _remote485CMInterruptionTimeOut;

        public double Remote485CMInterruptonTimeOut
        {
            get => _remote485CMInterruptionTimeOut;
            set
            {
                SetProperty(ref _remote485CMInterruptionTimeOut, value);
            }
        }

        /// <summary>
        /// 远程TCP通信中断超时
        /// </summary>
        private double _remoteTCPCMInterruptionTimeOut;

        public double RemoteTCPCMInterruptionTimeOut
        {
            get => _remoteTCPCMInterruptionTimeOut;
            set
            {
                SetProperty(ref _remoteTCPCMInterruptionTimeOut, value);
            }
        }



        /// <summary>
        /// BUS侧上限电压
        /// </summary>
        private double _bUSHigherVolThresh;

        public double BUSUpperLimitVolThresh
        {
            get => _bUSHigherVolThresh;
            set
            {
                SetProperty(ref _bUSHigherVolThresh, value);
            }
        }

        /// <summary>
        /// BUS侧下限电压
        /// </summary>
        private double _bUSLowerLimitVolThresh;

        public double BUSLowerLimitVolThresh
        {
            get => _bUSLowerLimitVolThresh;
            set
            {
                SetProperty(ref _bUSLowerLimitVolThresh, value);
            }
        }

        /// <summary>
        /// BUS侧高压设置
        /// </summary>
        private double _bUSHVolSetting;

        public double BUSHVolSetting
        {
            get => _bUSHVolSetting;
            set
            {
                SetProperty(ref _bUSHVolSetting, value);
            }
        }

        /// <summary>
        /// BUS侧低压设置
        /// </summary>
        private double _bUSLVolSetiing;

        public double BUSLVolSetting
        {
            get => _bUSLVolSetiing;
            set
            {
                SetProperty(ref _bUSLVolSetiing, value);
            }
        }

        /// <summary>
        /// 模式设置
        /// </summary>
        public string ModeSet1 { get;set; }

        /// <summary>
        /// 电池下限电压
        /// </summary>
        private double _bTLLimitVol;

        public double BTLLimitVol
        {
            get => _bTLLimitVol;
            set
            {
                SetProperty(ref _bTLLimitVol, value);
            }
        }

        /// <summary>
        /// 放电终止电压
        /// </summary>
        private double _dischargeSTVol;

        public double DischargeSTVol
        {
            get => _dischargeSTVol;
            set
            {
                SetProperty(ref _dischargeSTVol, value);
            }
        }

        /// <summary>
        /// 多支路电流调节参数
        /// </summary>
        private int _multiBranchCurRegPar;

        public int MultiBranchCurRegPar
        {
            get => _multiBranchCurRegPar;
            set
            {
                SetProperty(ref _multiBranchCurRegPar, value);
            }
        }

        /// <summary>
        /// 电池均充电压
        /// </summary>
        private double _batAveChVol;

        public double BatAveChVol
        {
            get => _batAveChVol;
            set
            {
                SetProperty(ref _batAveChVol, value);
            }
        }

        /// <summary>
        /// 充电截止电流
        /// </summary>
        private double _chCutCurrent;

        public double ChCutCurrent
        {
            get => _chCutCurrent;
            set
            {
                SetProperty(ref _chCutCurrent, value);
            }
        }

        /// <summary>
        /// 最大充电电流
        /// </summary>
        private double _maxChCurrent;

        public double MaxChCurrent
        {
            get => _maxChCurrent;
            set
            {
                SetProperty(ref _maxChCurrent, value);
            }
        }

        /// <summary>
        /// 最大放电电流
        /// </summary>
        private double _maxDisChCurrent;

        public double MaxDisChCurrent
        {
            get => _maxDisChCurrent;
            set
            {
                SetProperty(ref _maxDisChCurrent, value);
            }
        }

        /// <summary>
        /// 直流电流设置
        /// </summary>
        private double _dCCurrentSet;

        public double DCCurrentSet
        {
            get => _dCCurrentSet;
            set
            {
                SetProperty(ref _dCCurrentSet, value);
            }
        }

        /// <summary>
        /// 直流功率设置
        /// </summary>
        private double _dCPowerSet;

        public double DCPowerSet
        {
            get => _dCPowerSet;
            set
            {
                SetProperty(ref _dCPowerSet, value);
            }
        }

        /// <summary>
        /// DC支路选择
        /// </summary>
        public int DCBranch { get; set; }


        /// <summary>
        /// 功率调节可见度
        /// </summary>
        private Visibility _visDCPower;

        public Visibility VisDCPower
        {
            get => _visDCPower;
            set
            {
                SetProperty(ref _visDCPower, value);
            }
        }

        /// <summary>
        /// 电流调节可见度
        /// </summary>
        private Visibility _visDCCur;

        public Visibility VisDCCur
        {
            get => _visDCCur;
            set
            {
                SetProperty(ref _visDCCur, value);
            }
        }

        /// <summary>
        /// 充放电按钮可见度
        /// </summary>
        private Visibility _visDCChar;

        public Visibility VisDCChar
        {
            get => _visDCChar;
            set
            {
                SetProperty(ref _visDCChar, value);
            }
        }













        public  ModbusClient modbusClient;
        public RelayCommand ConnectMSLCommand { get; set; }
        public RelayCommand SyncBUSVolInfoCommand { get; set; }
        //public RelayCommand SyncTimeInfoCommand { get; set; }
        //public RelayCommand SyncCMTimeOutCommand { get; set; }
        public RelayCommand ReadBUSVolInfoCommand { get; set; }
        public RelayCommand ReadCMTimeOutCommand { get; set; }
        public RelayCommand ReadTimeInfoCommand { get; set; }
        public RelayCommand SyncDCBranchInfoCommand { get; set; }
        public RelayCommand ReadDCBranchInfoCommand { get; set; }
        public RelayCommand ModeSetCommand { get; set; }
        public RelayCommand ManCharCommand { get; set; }

        public bool IsConnected=false;

        public PCSSettingViewModel()
        {
            SyncBUSVolInfoCommand = new RelayCommand(SyncBUSVolInfo);
            //SyncTimeInfoCommand = new RelayCommand(SyncTimeInfo);
            //SyncCMTimeOutCommand = new RelayCommand(SyncCMTimeOut);
            ReadBUSVolInfoCommand = new RelayCommand(ReadBUSVolInfo);
            //ReadCMTimeOutCommand = new RelayCommand(ReadCMTimeOut);
            //ReadTimeInfoCommand = new RelayCommand(ReadTimeInfo);
            SyncDCBranchInfoCommand = new RelayCommand(SyncDCBranchInfo);
            ReadDCBranchInfoCommand = new RelayCommand(ReadDCBranchInfo);
            ModeSetCommand = new RelayCommand(ModeSet);


            ManCharCommand = new RelayCommand(ManChar);

            VisDCPower = Visibility.Hidden;
            VisDCCur = Visibility.Hidden;
            VisDCChar = Visibility.Hidden;
        }


        private void SyncBUSVolInfo()
        {
            if (IsConnected)
            {
                if (BUSUpperLimitVolThresh < 100 || BUSUpperLimitVolThresh > 900)
                {
                    MessageBox.Show("上限电压：请输入100-900的数");
                    return;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(BUSUpperLimitVolThresh.ToString(), @"^\d+\.\d$"))
                {
                    MessageBox.Show("上限电压：请输入一位小数");
                    return;
                }

                if (BUSLowerLimitVolThresh < 100 || BUSLowerLimitVolThresh > 900)
                {
                    MessageBox.Show("下限电压：请输入100-900的数");
                    return;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(BUSLowerLimitVolThresh.ToString(), @"^\d+\.\d$"))
                {
                    MessageBox.Show("下限电压：请输入一位小数");
                    return;
                }

                if (BUSHVolSetting < 100 || BUSHVolSetting > 900)
                {
                    MessageBox.Show("高压设置：请输入100-900的数");
                    return;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(BUSHVolSetting.ToString(), @"^\d+\.\d$"))
                {
                    MessageBox.Show("高压设置：请输入一位小数");
                    return;
                }

                if (BUSLVolSetting < 100 || BUSLVolSetting > 900)
                {
                    MessageBox.Show("低压设置：请输入100-900的数");
                    return;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(BUSLVolSetting.ToString(), @"^\d+\.\d$"))
                {
                    MessageBox.Show("低压设置：请输入一位小数");
                    return;
                }
                modbusClient.WriteFunc(1, 53640, (ushort)(BUSUpperLimitVolThresh * 10));
                modbusClient.WriteFunc(1, 53641, (ushort)(BUSLowerLimitVolThresh * 10));
                modbusClient.WriteFunc(1, 53642, (ushort)(BUSHVolSetting * 10));
                modbusClient.WriteFunc(1, 53643, (ushort)(BUSLVolSetting * 10));
            }
            else
            {
                MessageBox.Show("请连接");
            }
        }


        /// <summary>
        /// 使用四舍五入避免出现多位小数的情况。
        /// </summary>
        private void ReadBUSVolInfo()
        {
            if (IsConnected)
            {
                byte[] data = modbusClient.ReadFunc(53640, 4);
                BUSUpperLimitVolThresh = Math.Round(BitConverter.ToInt16(data, 0) * 0.1, 2);
                BUSLowerLimitVolThresh = Math.Round(BitConverter.ToInt16(data, 2) * 0.1, 2);
                BUSHVolSetting = Math.Round(BitConverter.ToInt16(data, 4) * 0.1, 2);
                BUSLVolSetting = Math.Round(BitConverter.ToInt16(data, 6) * 0.1, 2);
            }
            else
            {
                MessageBox.Show("请连接");
            }
        }

        //private void SyncTimeInfo()
        //{
        //    if (IsConnected)
        //    {
        //        if (Year < 2000 || Year > 2099)
        //        {
        //            MessageBox.Show("年：请输入2000-2099的整数");
        //            return;
        //        }

        //        if (Month < 1 || Month > 12)
        //        {
        //            MessageBox.Show("月：请输入1-12的整数");
        //            return;
        //        }

        //        if (Day < 1 || Day > 31)
        //        {
        //            MessageBox.Show("日：请输入1-31的整数");
        //            return;
        //        }

        //        if (Hour < 0 || Hour > 23)
        //        {
        //            MessageBox.Show("小时：请输入0-23的整数");
        //            return;
        //        }

        //        if (Minute < 0 || Minute > 59)
        //        {
        //            MessageBox.Show("分钟：请输入0-59的整数");
        //            return;
        //        }

        //        if (Second < 0 || Second > 59)
        //        {
        //            MessageBox.Show("秒：请输入0-59的整数");
        //            return;
        //        }
        //        modbusClient.WriteFunc(1, 56000, (ushort)(Year));
        //        modbusClient.WriteFunc(1, 56001, (ushort)(Month));
        //        modbusClient.WriteFunc(1, 56002, (ushort)(Day));
        //        modbusClient.WriteFunc(1, 56003, (ushort)(Hour));
        //        modbusClient.WriteFunc(1, 56004, (ushort)(Minute));
        //        modbusClient.WriteFunc(1, 56005, (ushort)(Second));
        //    }
        //    else
        //    {
        //        MessageBox.Show("请连接");
        //    }
        //}


        //private void ReadTimeInfo()
        //{
        //    if (IsConnected)
        //    {
        //        byte[] data = modbusClient.ReadFunc(56000, 6);
        //        Year = BitConverter.ToUInt16(data, 0);
        //        Month = BitConverter.ToUInt16(data, 2);
        //        Day = BitConverter.ToUInt16(data, 4);
        //        Hour = BitConverter.ToUInt16(data, 6);
        //        Minute = BitConverter.ToUInt16(data, 8);
        //        Second = BitConverter.ToUInt16(data, 10);
        //    }
        //    else
        //    {
        //        MessageBox.Show("请连接");
        //    }
        //}

        //private void SyncCMTimeOut()
        //{
        //    if (IsConnected)
        //    {
        //        if (BMSCMInterruptionTimeOut < 1 || BMSCMInterruptionTimeOut > 600)
        //        {
        //            MessageBox.Show("BMS通信超时设置：请输入1-600的整数");
        //            return;
        //        }
        //        if (Remote485CMInterruptonTimeOut < 1 || Remote485CMInterruptonTimeOut > 600)
        //        {
        //            MessageBox.Show("远程485通信超时设置：请输入1-600的整数");
        //            return;
        //        }
        //        if (RemoteTCPCMInterruptionTimeOut < 1 || RemoteTCPCMInterruptionTimeOut > 600)
        //        {
        //            MessageBox.Show("远程TCP通信超时设置：请输入1-600的整数");
        //            return;
        //        }
        //        modbusClient.WriteFunc(1, 56006, (ushort)(BMSCMInterruptionTimeOut));
        //        modbusClient.WriteFunc(1, 56007, (ushort)(Remote485CMInterruptonTimeOut));
        //        modbusClient.WriteFunc(1, 56008, (ushort)(RemoteTCPCMInterruptionTimeOut));
        //    }
        //    else
        //    {
        //        MessageBox.Show("请连接");
        //    }

        //}


        //private void ReadCMTimeOut()
        //{
        //    if (IsConnected)
        //    {
        //        byte[] data = modbusClient.ReadFunc(56006, 3);
        //        BMSCMInterruptionTimeOut = BitConverter.ToInt16(data, 0);
        //        Remote485CMInterruptonTimeOut = BitConverter.ToInt16(data, 2);
        //        RemoteTCPCMInterruptionTimeOut = BitConverter.ToInt16(data, 4);
        //    }
        //    else
        //    {
        //        MessageBox.Show("请连接");
        //    }
        //}


        private void SyncDCBranchInfo()
        {
            if (IsConnected)
            {
                if (BTLLimitVol > 800 || BTLLimitVol < 30)
                {
                    MessageBox.Show("电池下限电压：请输入30到800的数");
                    return;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(BTLLimitVol.ToString(), @"^\d+\.\d$"))
                {
                    MessageBox.Show("电池下限电压：请输入一位小数");
                    return;
                }

                if (DischargeSTVol > 900 || DischargeSTVol < 30)
                {
                    MessageBox.Show("放电终止电压：请输入30到800的数");
                    return;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(DischargeSTVol.ToString(), @"^\d+\.\d$"))
                {
                    MessageBox.Show("放电终止电压：请输入一位小数");
                    return;
                }

                if (MultiBranchCurRegPar > 50 || MultiBranchCurRegPar < -50)
                {
                    MessageBox.Show("多支路电流调节参数：请输入-50到50的数");
                    return;
                }

                if (BatAveChVol > 800 || BatAveChVol < 30)
                {
                    MessageBox.Show("电池均充电压：请输入30到800的数");
                    return;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(BatAveChVol.ToString(), @"^\d+\.\d$"))
                {
                    MessageBox.Show("电池均充电压：请输入一位小数");
                    return;
                }

                if (ChCutCurrent > 250 || ChCutCurrent < 0)
                {
                    MessageBox.Show("充电截止电流：请输入0到250的数");
                    return;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(ChCutCurrent.ToString(), @"^\d+\.\d$"))
                {
                    MessageBox.Show("充电截止电流：请输入一位小数");
                    return;
                }

                if (MaxChCurrent > 1500 || MaxChCurrent < 0)
                {
                    MessageBox.Show("最大充电电流：请输入0到1500的数");
                    return;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(MaxChCurrent.ToString(), @"^\d+\.\d$"))
                {
                    MessageBox.Show("最大充电电流：请输入一位小数");
                    return;
                }

                if (MaxDisChCurrent > 1500 || MaxDisChCurrent < 0)
                {
                    MessageBox.Show("最大放电电流：请输入0到1500的数");
                    return;
                }
                else if (!System.Text.RegularExpressions.Regex.IsMatch(MaxDisChCurrent.ToString(), @"^\d+\.\d$"))
                {
                    MessageBox.Show("最大放电电流：请输入一位小数");
                    return;
                }

                //switch (DCBranch)
                //{
                //    case 1:
                
                modbusClient.WriteFunc(1, 53653, (ushort)(BTLLimitVol * 10));
                modbusClient.WriteFunc(1, 53655, (ushort)(DischargeSTVol * 10));
                modbusClient.WriteFunc(1, 53658, (ushort)MultiBranchCurRegPar);
                modbusClient.WriteFunc(1, 53660, (ushort)(BatAveChVol * 10));
                modbusClient.WriteFunc(1, 53662, (ushort)(ChCutCurrent * 10));
                modbusClient.WriteFunc(1, 53663, (ushort)(MaxChCurrent * 10));
                modbusClient.WriteFunc(1, 53664, (ushort)(MaxDisChCurrent * 10));
                    //    break;
                    //case 2:
                    //    modbusClient.WriteFunc(1, 53681, (ushort)(DCCurrentSet * 10));
                    //    modbusClient.WriteFunc(1, 53682, (ushort)(DCPowerSet * 10));
                    //    modbusClient.WriteFunc(1, 53683, (ushort)(BTLLimitVol * 10));
                    //    modbusClient.WriteFunc(1, 53685, (ushort)(DischargeSTVol * 10));
                    //    modbusClient.WriteFunc(1, 53688, (ushort)MultiBranchCurRegPar);
                    //    modbusClient.WriteFunc(1, 53690, (ushort)(BatAveChVol * 10));
                    //    modbusClient.WriteFunc(1, 53692, (ushort)(ChCutCurrent * 10));
                    //    modbusClient.WriteFunc(1, 53693, (ushort)(MaxChCurrent * 10));
                    //    modbusClient.WriteFunc(1, 53694, (ushort)(MaxDisChCurrent * 10));
                    //    break;
                    //case 3:
                    //    modbusClient.WriteFunc(1, 53711, (ushort)(DCCurrentSet * 10));
                    //    modbusClient.WriteFunc(1, 53712, (ushort)(DCPowerSet * 10));
                    //    modbusClient.WriteFunc(1, 53713, (ushort)(BTLLimitVol * 10));
                    //    modbusClient.WriteFunc(1, 53715, (ushort)(DischargeSTVol * 10));
                    //    modbusClient.WriteFunc(1, 53718, (ushort)MultiBranchCurRegPar);
                    //    modbusClient.WriteFunc(1, 53720, (ushort)(BatAveChVol * 10));
                    //    modbusClient.WriteFunc(1, 53722, (ushort)(ChCutCurrent * 10));
                    //    modbusClient.WriteFunc(1, 53723, (ushort)(MaxChCurrent * 10));
                    //    modbusClient.WriteFunc(1, 53724, (ushort)(MaxDisChCurrent * 10));
                    //    break;
                    //case 4:
                    //    modbusClient.WriteFunc(1, 53741, (ushort)(DCCurrentSet * 10));
                    //    modbusClient.WriteFunc(1, 53742, (ushort)(DCPowerSet * 10));
                    //    modbusClient.WriteFunc(1, 53743, (ushort)(BTLLimitVol * 10));
                    //    modbusClient.WriteFunc(1, 53745, (ushort)(DischargeSTVol * 10));
                    //    modbusClient.WriteFunc(1, 53748, (ushort)MultiBranchCurRegPar);
                    //    modbusClient.WriteFunc(1, 53750, (ushort)(BatAveChVol * 10));
                    //    modbusClient.WriteFunc(1, 53752, (ushort)(ChCutCurrent * 10));
                    //    modbusClient.WriteFunc(1, 53753, (ushort)(MaxChCurrent * 10));
                    //    modbusClient.WriteFunc(1, 53754, (ushort)(MaxDisChCurrent * 10));
                    //    break;
                    //case 5:
                    //    modbusClient.WriteFunc(1, 53771, (ushort)(DCCurrentSet * 10));
                    //    modbusClient.WriteFunc(1, 53772, (ushort)(DCPowerSet * 10));
                    //    modbusClient.WriteFunc(1, 53773, (ushort)(BTLLimitVol * 10));
                    //    modbusClient.WriteFunc(1, 53775, (ushort)(DischargeSTVol * 10));
                    //    modbusClient.WriteFunc(1, 53778, (ushort)MultiBranchCurRegPar);
                    //    modbusClient.WriteFunc(1, 53780, (ushort)(BatAveChVol * 10));
                    //    modbusClient.WriteFunc(1, 53782, (ushort)(ChCutCurrent * 10));
                    //    modbusClient.WriteFunc(1, 53783, (ushort)(MaxChCurrent * 10));
                    //    modbusClient.WriteFunc(1, 53784, (ushort)(MaxDisChCurrent * 10));
                    //    break;
                    //case 6:
                    //    modbusClient.WriteFunc(1, 53801, (ushort)(DCCurrentSet * 10));
                    //    modbusClient.WriteFunc(1, 53802, (ushort)(DCPowerSet * 10));
                    //    modbusClient.WriteFunc(1, 53803, (ushort)(BTLLimitVol * 10));
                    //    modbusClient.WriteFunc(1, 53805, (ushort)(DischargeSTVol * 10));
                    //    modbusClient.WriteFunc(1, 53808, (ushort)MultiBranchCurRegPar);
                    //    modbusClient.WriteFunc(1, 53810, (ushort)(BatAveChVol * 10));
                    //    modbusClient.WriteFunc(1, 53812, (ushort)(ChCutCurrent * 10));
                    //    modbusClient.WriteFunc(1, 53813, (ushort)(MaxChCurrent * 10));
                    //    modbusClient.WriteFunc(1, 53814, (ushort)(MaxDisChCurrent * 10));
                    //    break;
                    //case 7:
                    //    modbusClient.WriteFunc(1, 53831, (ushort)(DCCurrentSet * 10));
                    //    modbusClient.WriteFunc(1, 53832, (ushort)(DCPowerSet * 10));
                    //    modbusClient.WriteFunc(1, 53833, (ushort)(BTLLimitVol * 10));
                    //    modbusClient.WriteFunc(1, 53835, (ushort)(DischargeSTVol * 10));
                    //    modbusClient.WriteFunc(1, 53838, (ushort)MultiBranchCurRegPar);
                    //    modbusClient.WriteFunc(1, 53840, (ushort)(BatAveChVol * 10));
                    //    modbusClient.WriteFunc(1, 53842, (ushort)(ChCutCurrent * 10));
                    //    modbusClient.WriteFunc(1, 53843, (ushort)(MaxChCurrent * 10));
                    //    modbusClient.WriteFunc(1, 53844, (ushort)(MaxDisChCurrent * 10));
                    //    break;
                    //case 8:
                    //    modbusClient.WriteFunc(1, 53861, (ushort)(DCCurrentSet * 10));
                    //    modbusClient.WriteFunc(1, 53862, (ushort)(DCPowerSet * 10));
                    //    modbusClient.WriteFunc(1, 53863, (ushort)(BTLLimitVol * 10));
                    //    modbusClient.WriteFunc(1, 53865, (ushort)(DischargeSTVol * 10));
                    //    modbusClient.WriteFunc(1, 53868, (ushort)MultiBranchCurRegPar);
                    //    modbusClient.WriteFunc(1, 53870, (ushort)(BatAveChVol * 10));
                    //    modbusClient.WriteFunc(1, 53872, (ushort)(ChCutCurrent * 10));
                    //    modbusClient.WriteFunc(1, 53873, (ushort)(MaxChCurrent * 10));
                    //    modbusClient.WriteFunc(1, 53874, (ushort)(MaxDisChCurrent * 10));
                    //    break;
                    //default:
                    //    {
                    //        MessageBox.Show("请选择DC支路");
                    //    }
                    //    break;
                
            }
            else
            {
                MessageBox.Show("请连接");
            }
        }


        private void ReadDCBranchInfo()
        {
            if (IsConnected)
            {
                //switch (DCBranch)
                //{
                //    case 1:
                        byte[] data11 = modbusClient.ReadFunc(53651, 3);
                        DCCurrentSet = Math.Round(BitConverter.ToInt16(data11, 0) * 0.1, 2);
                        DCPowerSet = Math.Round(BitConverter.ToInt16(data11, 2) * 0.1, 2);
                        BTLLimitVol = Math.Round(BitConverter.ToInt16(data11, 4) * 0.1, 2);
                        byte[] data12 = modbusClient.ReadFunc(53655, 1);
                        DischargeSTVol = Math.Round(BitConverter.ToInt16(data12, 0) * 0.1, 2);
                        byte[] data13 = modbusClient.ReadFunc(53658, 1);
                        MultiBranchCurRegPar = BitConverter.ToInt16(data13, 0);
                        byte[] data14 = modbusClient.ReadFunc(53660, 1);
                        BatAveChVol = Math.Round(BitConverter.ToInt16(data14, 0) * 0.1, 2);
                        byte[] data15 = modbusClient.ReadFunc(53662, 3);
                        ChCutCurrent = Math.Round(BitConverter.ToInt16(data15, 0) * 0.1, 2);
                        MaxChCurrent = Math.Round(BitConverter.ToInt16(data15, 2) * 0.1, 2);
                        MaxDisChCurrent = Math.Round(BitConverter.ToInt16(data15, 4) * 0.1, 2);
                //            break;
                //        case 2:
                //            byte[] data21 = modbusClient.ReadFunc(53681, 3);
                //            DCCurrentSet = Math.Round(BitConverter.ToInt16(data21, 0) * 0.1, 2);
                //            DCPowerSet = Math.Round(BitConverter.ToInt16(data21, 2) * 0.1, 2);
                //            BTLLimitVol = Math.Round(BitConverter.ToInt16(data21, 4) * 0.1, 2);
                //            byte[] data22 = modbusClient.ReadFunc(53685, 1);
                //            DischargeSTVol = Math.Round(BitConverter.ToInt16(data22, 0) * 0.1, 2);
                //            byte[] data23 = modbusClient.ReadFunc(53688, 1);
                //            MultiBranchCurRegPar = BitConverter.ToInt16(data23, 0);
                //            byte[] data24 = modbusClient.ReadFunc(53690, 1);
                //            BatAveChVol = Math.Round(BitConverter.ToInt16(data24, 0) * 0.1, 2);
                //            byte[] data25 = modbusClient.ReadFunc(53692, 3);
                //            ChCutCurrent = Math.Round(BitConverter.ToInt16(data25, 0) * 0.1, 2);
                //            MaxChCurrent = Math.Round(BitConverter.ToInt16(data25, 2) * 0.1, 2);
                //            MaxDisChCurrent = Math.Round(BitConverter.ToInt16(data25, 4) * 0.1, 2);
                //            break;
                //        case 3:
                //            byte[] data31 = modbusClient.ReadFunc(53711, 3);
                //            DCCurrentSet = Math.Round(BitConverter.ToInt16(data31, 0) * 0.1, 2);
                //            DCPowerSet = Math.Round(BitConverter.ToInt16(data31, 2) * 0.1, 2);
                //            BTLLimitVol = Math.Round(BitConverter.ToInt16(data31, 4) * 0.1, 2);
                //            byte[] data32 = modbusClient.ReadFunc(53715, 1);
                //            DischargeSTVol = Math.Round(BitConverter.ToInt16(data32, 0) * 0.1, 2);
                //            byte[] data33 = modbusClient.ReadFunc(53718, 1);
                //            MultiBranchCurRegPar = BitConverter.ToInt16(data33, 0);
                //            byte[] data34 = modbusClient.ReadFunc(53720, 1);
                //            BatAveChVol = Math.Round(BitConverter.ToInt16(data34, 0) * 0.1, 2);
                //            byte[] data35 = modbusClient.ReadFunc(53722, 3);
                //            ChCutCurrent = Math.Round(BitConverter.ToInt16(data35, 0) * 0.1, 2);
                //            MaxChCurrent = Math.Round(BitConverter.ToInt16(data35, 2) * 0.1, 2);
                //            MaxDisChCurrent = Math.Round(BitConverter.ToInt16(data35, 4) * 0.1, 2);
                //            break;
                //        case 4:
                //            byte[] data41 = modbusClient.ReadFunc(53741, 3);
                //            DCCurrentSet = Math.Round(BitConverter.ToInt16(data41, 0) * 0.1, 2);
                //            DCPowerSet = Math.Round(BitConverter.ToInt16(data41, 2) * 0.1, 2);
                //            BTLLimitVol = Math.Round(BitConverter.ToInt16(data41, 4) * 0.1, 2);
                //            byte[] data42 = modbusClient.ReadFunc(53745, 1);
                //            DischargeSTVol = Math.Round(BitConverter.ToInt16(data42, 0) * 0.1, 2);
                //            byte[] data43 = modbusClient.ReadFunc(53748, 1);
                //            MultiBranchCurRegPar = BitConverter.ToInt16(data43, 0);
                //            byte[] data44 = modbusClient.ReadFunc(53750, 1);
                //            BatAveChVol = Math.Round(BitConverter.ToInt16(data44, 0) * 0.1, 2);
                //            byte[] data45 = modbusClient.ReadFunc(53752, 3);
                //            ChCutCurrent = Math.Round(BitConverter.ToInt16(data45, 0) * 0.1, 2);
                //            MaxChCurrent = Math.Round(BitConverter.ToInt16(data45, 2) * 0.1, 2);
                //            MaxDisChCurrent = Math.Round(BitConverter.ToInt16(data45, 4) * 0.1, 2);
                //            break;
                //        case 5:
                //            byte[] data51 = modbusClient.ReadFunc(53771, 3);
                //            DCCurrentSet = Math.Round(BitConverter.ToInt16(data51, 0) * 0.1, 2);
                //            DCPowerSet = Math.Round(BitConverter.ToInt16(data51, 2) * 0.1, 2);
                //            BTLLimitVol = Math.Round(BitConverter.ToInt16(data51, 4) * 0.1, 2);
                //            byte[] data52 = modbusClient.ReadFunc(53775, 1);
                //            DischargeSTVol = Math.Round(BitConverter.ToInt16(data52, 0) * 0.1, 2);
                //            byte[] data53 = modbusClient.ReadFunc(53778, 1);
                //            MultiBranchCurRegPar = BitConverter.ToInt16(data53, 0);
                //            byte[] data54 = modbusClient.ReadFunc(53780, 1);
                //            BatAveChVol = Math.Round(BitConverter.ToInt16(data54, 0) * 0.1, 2);
                //            byte[] data55 = modbusClient.ReadFunc(53782, 3);
                //            ChCutCurrent = Math.Round(BitConverter.ToInt16(data55, 0) * 0.1, 2);
                //            MaxChCurrent = Math.Round(BitConverter.ToInt16(data55, 2) * 0.1, 2);
                //            MaxDisChCurrent = Math.Round(BitConverter.ToInt16(data55, 4) * 0.1, 2);
                //            break;
                //        case 6:
                //            byte[] data61 = modbusClient.ReadFunc(53801, 3);
                //            DCCurrentSet = Math.Round(BitConverter.ToInt16(data61, 0) * 0.1, 2);
                //            DCPowerSet = Math.Round(BitConverter.ToInt16(data61, 2) * 0.1, 2);
                //            BTLLimitVol = Math.Round(BitConverter.ToInt16(data61, 4) * 0.1, 2);
                //            byte[] data62 = modbusClient.ReadFunc(53805, 1);
                //            DischargeSTVol = Math.Round(BitConverter.ToInt16(data62, 0) * 0.1, 2);
                //            byte[] data63 = modbusClient.ReadFunc(53808, 1);
                //            MultiBranchCurRegPar = BitConverter.ToInt16(data63, 0);
                //            byte[] data64 = modbusClient.ReadFunc(53810, 1);
                //            BatAveChVol = Math.Round(BitConverter.ToInt16(data64, 0) * 0.1, 2);
                //            byte[] data65 = modbusClient.ReadFunc(53812, 3);
                //            ChCutCurrent = Math.Round(BitConverter.ToInt16(data65, 0) * 0.1, 2);
                //            MaxChCurrent = Math.Round(BitConverter.ToInt16(data65, 2) * 0.1, 2);
                //            MaxDisChCurrent = Math.Round(BitConverter.ToInt16(data65, 4) * 0.1, 2);
                //            break;
                //        case 7:
                //            byte[] data71 = modbusClient.ReadFunc(53831, 3);
                //            DCCurrentSet = Math.Round(BitConverter.ToInt16(data71, 0) * 0.1, 2);
                //            DCPowerSet = Math.Round(BitConverter.ToInt16(data71, 2) * 0.1, 2);
                //            BTLLimitVol = Math.Round(BitConverter.ToInt16(data71, 4) * 0.1, 2);
                //            byte[] data72 = modbusClient.ReadFunc(53835, 1);
                //            DischargeSTVol = Math.Round(BitConverter.ToInt16(data72, 0) * 0.1, 2);
                //            byte[] data73 = modbusClient.ReadFunc(53838, 1);
                //            MultiBranchCurRegPar = BitConverter.ToInt16(data73, 0);
                //            byte[] data74 = modbusClient.ReadFunc(53840, 1);
                //            BatAveChVol = Math.Round(BitConverter.ToInt16(data74, 0) * 0.1, 2);
                //            byte[] data75 = modbusClient.ReadFunc(53842, 3);
                //            ChCutCurrent = Math.Round(BitConverter.ToInt16(data75, 0) * 0.1, 2);
                //            MaxChCurrent = Math.Round(BitConverter.ToInt16(data75, 2) * 0.1, 2);
                //            MaxDisChCurrent = Math.Round(BitConverter.ToInt16(data75, 4) * 0.1, 2);
                //            break;
                //        case 8:
                //            byte[] data81 = modbusClient.ReadFunc(53861, 3);
                //            DCCurrentSet = Math.Round(BitConverter.ToInt16(data81, 0) * 0.1, 2);
                //            DCPowerSet = Math.Round(BitConverter.ToInt16(data81, 2) * 0.1, 2);
                //            BTLLimitVol = Math.Round(BitConverter.ToInt16(data81, 4) * 0.1, 2);
                //            byte[] data82 = modbusClient.ReadFunc(53865, 1);
                //            DischargeSTVol = Math.Round(BitConverter.ToInt16(data82, 0) * 0.1, 2);
                //            byte[] data83 = modbusClient.ReadFunc(53868, 1);
                //            MultiBranchCurRegPar = BitConverter.ToInt16(data83, 0);
                //            byte[] data84 = modbusClient.ReadFunc(53870, 1);
                //            BatAveChVol = Math.Round(BitConverter.ToInt16(data84, 0) * 0.1, 2);
                //            byte[] data85 = modbusClient.ReadFunc(53872, 3);
                //            ChCutCurrent = Math.Round(BitConverter.ToInt16(data85, 0) * 0.1, 2);
                //            MaxChCurrent = Math.Round(BitConverter.ToInt16(data85, 2) * 0.1, 2);
                //            MaxDisChCurrent = Math.Round(BitConverter.ToInt16(data85, 4) * 0.1, 2);
                //            break;
                //        default:
                //            {
                //                MessageBox.Show("请选择DC支路");
                //            }
                //            break;
                //    }
            }
            else
            {
                MessageBox.Show("请连接");
            }
        }

        private void ModeSet()
        {
            if (IsConnected)
            {
                //switch (DCBranch)
                //{
                //    case 1:
                        if (ModeSet1 == "设置电流调节")
                        {
                            modbusClient.WriteFunc(1,53650, 0);
                            VisDCCur = Visibility.Visible;
                            VisDCPower = Visibility.Hidden;
                            VisDCChar = Visibility.Visible;
                        }
                        else if(ModeSet1== "设置功率调节")
                        {
                            modbusClient.WriteFunc(1,53650, 1);
                            VisDCPower=Visibility.Visible;
                            VisDCCur = Visibility.Hidden;
                            VisDCChar = Visibility.Visible;
                        }
                        else
                        {
                            MessageBox.Show("请选择模式");
                        }
                        

                
                //        break;
                //    case 2:
                //        if (ModeSet1 == "设置电流调节")
                //        {
                //            modbusClient.WriteFunc(1, 53680, 0);
                //        }
                //        else
                //        {
                //            modbusClient.WriteFunc(1, 53680, 1);
                //        }
                //        break;
                //    case 3:
                //        if (ModeSet1 == "设置电流调节")
                //        {
                //            modbusClient.WriteFunc(1, 53710, 0);
                //        }
                //        else
                //        {
                //            modbusClient.WriteFunc(1, 53710, 1);
                //        }
                //        break;
                //    case 4:
                //        if (ModeSet1 == "设置电流调节")
                //        {
                //            modbusClient.WriteFunc(1, 53740, 0);
                //        }
                //        else
                //        {
                //            modbusClient.WriteFunc(1, 53740, 1);
                //        }
                //        break;
                //    case 5:
                //        if (ModeSet1 == "设置电流调节")
                //        {
                //            modbusClient.WriteFunc(1, 53770, 0);
                //        }
                //        else
                //        {
                //            modbusClient.WriteFunc(1, 53770, 1);
                //        }
                //        break;
                //    case 6:
                //        if (ModeSet1 == "设置电流调节")
                //        {
                //            modbusClient.WriteFunc(1, 53800, 0);
                //        }
                //        else
                //        {
                //            modbusClient.WriteFunc(1, 53800, 1);
                //        }
                //        break;
                //    case 7:
                //        if (ModeSet1 == "设置电流调节")
                //        {
                //            modbusClient.WriteFunc(1, 53830, 0);
                //        }
                //        else
                //        {
                //            modbusClient.WriteFunc(1, 53830, 1);
                //        }
                //        break;
                //    case 8:
                //        if (ModeSet1 == "设置电流调节")
                //        {
                //            modbusClient.WriteFunc(1, 53860, 0);
                //        }
                //        else
                //        {
                //            modbusClient.WriteFunc(1, 53860, 1);
                //        }
                //        break;
                //    default:
                //        {
                //            MessageBox.Show("请选择DC支路");
                //        }
                //        break;
                //}
            }
            else
            {
                MessageBox.Show("请连接");
            }
        }

        private void ManChar()
        {
            if (IsConnected)
            {
                if (ModeSet1 == "设置电流调节")
                {
                    if (DCCurrentSet > 1500 || DCCurrentSet < -1500)
                    {
                        MessageBox.Show("直流电流设置：请输入-1500到1500的数");
                        return;
                    }
                    else if (System.Text.RegularExpressions.Regex.IsMatch(DCCurrentSet.ToString(), @"^\d+\.\d$") == false & System.Text.RegularExpressions.Regex.IsMatch(DCCurrentSet.ToString(), @"^\-\d+\.\d$") == false)
                    {
                        MessageBox.Show("直流电流设置：请输入一位小数");
                        return;
                    }
                    modbusClient.WriteFunc(0, 53651, (ushort)(DCCurrentSet * 10));
                }
                else
                {
                    if (DCPowerSet > 1000 || DCPowerSet < -1000)
                    {
                        MessageBox.Show("直流功率设置：请输入-1000到1000的数");
                        return;
                    }
                    else if (System.Text.RegularExpressions.Regex.IsMatch(DCPowerSet.ToString(), @"^\d+\.\d$") == false & System.Text.RegularExpressions.Regex.IsMatch(DCPowerSet.ToString(), @"^\-\d+\.\d$") == false)
                    {
                        MessageBox.Show("直流功率设置：请输入一位小数");
                        return;
                    }
                    modbusClient.WriteFunc(0, 53652, (ushort)(DCPowerSet * 10));
                }
            }
        }
    }
}
