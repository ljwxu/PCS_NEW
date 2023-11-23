using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PCS_NEW.ViewModels
{
    public  class pCSMonitorViewModel:ObservableObject
    {
        /// <summary>
        /// DC模块异常1 DC模块异常有三个地址
        /// </summary>
        private int _alarmStateFlagDC1;

		public int AlarmStateFlagDC1
        {
			get => _alarmStateFlagDC1;
			set
			{
				SetProperty(ref _alarmStateFlagDC1, value);
			}
		}

        /// <summary>
        /// DC模块异常2
        /// </summary>
        private int _alarmStateFlagDC2;

		public int AlarmStateFlagDC2
        {
			get => _alarmStateFlagDC2;
			set
			{
				SetProperty(ref _alarmStateFlagDC2, value);
			}
		}

        /// <summary>
        /// DC模块异常3
        /// </summary>
        private int _alarmStateFlagDC3;

		public int AlarmStateFlagDC3
        {
			get => _alarmStateFlagDC3;
			set
			{
				SetProperty(ref _alarmStateFlagDC3, value);
			}
		}

        /// <summary>
        /// DC模块异常状态
        /// </summary>
        private ObservableCollection<string> _alarmStateDC;

        public ObservableCollection<string> AlarmStateDC
        {
            get => _alarmStateDC;
            set
            {
                SetProperty(ref _alarmStateDC, value);
            }
        }

        /// <summary>
        /// DC模块异常颜色
        /// </summary>
        private SolidColorBrush _alarmColorDC;

        public SolidColorBrush AlarmColorDC
        {
            get => _alarmColorDC;
            set
            {
                SetProperty(ref _alarmColorDC, value);
            }
        }

        /// <summary>
        /// PDS异常信息
        /// </summary>
        private int _alarmStateFlagPDS;

        public int AlarmStateFlagPDS
        {
            get => _alarmStateFlagPDS;
            set
            {
                SetProperty(ref _alarmStateFlagPDS, value);
            }
        }

        /// <summary>
        /// PDS异常状态
        /// </summary>
        private ObservableCollection<string> _alarmStatePDS;

        public ObservableCollection<string> AlarmStatePDS
        {
            get => _alarmStatePDS;
            set
            {
                SetProperty(ref _alarmStatePDS, value);
            }
        }

        /// <summary>
        /// PDS异常颜色
        /// </summary>
        private SolidColorBrush _alarmColorPDS;

        public SolidColorBrush AlarmColorPDS
        {
            get => _alarmColorPDS;
            set
            {
                SetProperty(ref _alarmColorPDS, value);
            }
        }

        /// <summary>
        /// PCS本地手动控制状态颜色
        /// </summary>
        private SolidColorBrush _pCSStateColorManControl;

		public SolidColorBrush PCSStateColorManControl
        {
			get => _pCSStateColorManControl;
			set
			{
				SetProperty(ref _pCSStateColorManControl, value);
			}
		}

        /// <summary>
        /// PCS本地自动控制状态颜色
        /// </summary>
        private SolidColorBrush _pCSStateColorAutoControl;

		public SolidColorBrush PCSStateColorAutoControl
        {
			get => _pCSStateColorAutoControl;
			set
			{
				SetProperty(ref _pCSStateColorAutoControl, value);
			}
		}

        /// <summary>
        /// PCS远程控制状态颜色
        /// </summary>
        private SolidColorBrush _pCSStateColorRemoteControl;

		public SolidColorBrush PCSStateColorRemoteControl
        {
			get => _pCSStateColorRemoteControl;
			set
			{
				SetProperty(ref _pCSStateColorRemoteControl, value);
			}
		}

        /// <summary>
        /// PCS控制状态读取
        /// </summary>
        private int _controlStateFlagPCS;

		public int ControlStateFlagPCS
        {
			get => _controlStateFlagPCS;
			set
			{
				SetProperty(ref _controlStateFlagPCS, value);
			}
		}

        /// <summary>
        /// PCS告警状态颜色
        /// </summary>
        private SolidColorBrush _alarmStateColorPCS;

		public SolidColorBrush AlarmStateColorPCS
        {
			get => _alarmStateColorPCS;
			set
			{
				SetProperty(ref _alarmStateColorPCS, value);
			}
		}

        /// <summary>
        /// PCS故障状态颜色
        /// </summary>
        private SolidColorBrush _faultStateColorPCS;

		public SolidColorBrush FaultStateColorPCS
        {
			get => _faultStateColorPCS;
			set
			{
				SetProperty(ref _faultStateColorPCS, value);
			}
		}

        /// <summary>
        /// PCS上电初始化状态颜色
        /// </summary>
        private SolidColorBrush _powerOnInitStateColorPCS;

		public SolidColorBrush PowerOnInitStateColorPCS
        {
			get => _powerOnInitStateColorPCS;
			set
			{
				SetProperty(ref _powerOnInitStateColorPCS, value);
			}
		}

        /// <summary>
        /// PCS状态读取
        /// </summary>
        private int _stateFlagPCS;

		public int StateFlagPCS
        {
			get => _stateFlagPCS;
			set
			{
				SetProperty(ref _stateFlagPCS, value);
			}
		}

        /// <summary>
        /// 模块温度  精度0.1 偏移值-20
        /// </summary>
        private double _moduleTemperature;

		public double ModuleTemperature
        {
			get => _moduleTemperature;
			set
			{
				SetProperty(ref _moduleTemperature, value);
			}
		}

        /// <summary>
        /// 环境温度  精度0.1 偏移值-20
        /// </summary>
        private double _ambientTemperature;

		public double AmbientTemperature
        {
			get => _ambientTemperature;
			set
			{
				SetProperty(ref _ambientTemperature, value);
			}
		}


        /// <summary>
        /// DC侧支路1状态读取1 
        /// </summary>
        private int _dcBranch1StateFlag1;

        public int DcBranch1StateFlag1
        {
            get => _dcBranch1StateFlag1;
            set
            {
                SetProperty(ref _dcBranch1StateFlag1, value);
            }
        }


        /// <summary>
        /// DC侧支路1状态读取2  启停状态
        /// </summary>
        private int _dcBranch1StateFlag2;

        public int DcBranch1StateFlag2
        {
            get => _dcBranch1StateFlag2;
            set
            {
                SetProperty(ref _dcBranch1StateFlag2, value);
            }
        }

        /// <summary>
        /// DC侧支路1状态1
        /// </summary>
        private string _dcBranch1State1;

        public string DcBranch1State1
        {
            get => _dcBranch1State1;
            set
            {
                SetProperty(ref _dcBranch1State1, value);
            }
        }

        /// <summary>
        /// DC侧支路1状态2  启停状态
        /// </summary>
        private string _dcBranch1State2;

        public string DcBranch1State2
        {
            get => _dcBranch1State2;
            set
            {
                SetProperty(ref _dcBranch1State2, value);
            }
        }

        /// <summary>
        /// DC侧支路1：直流功率
        /// </summary>
        private double _dcBranch1DCPower;

        public double DcBranch1DCPower
        {
            get => _dcBranch1DCPower;
            set
            {
                SetProperty(ref _dcBranch1DCPower, value);
            }
        }

        /// <summary>
        /// DC侧支路1：直流电压
        /// </summary>
        private double _dcBranch1DCVol;

        public double DcBranch1DCVol
        {
            get => _dcBranch1DCVol;
            set
            {
                SetProperty(ref _dcBranch1DCVol, value);
            }
        }

        /// <summary>
        /// DC侧支路1：直流电流
        /// </summary>
        private double _dcBranch1DCCur;

        public double DcBranch1DCCur
        {
            get => _dcBranch1DCCur;
            set
            {
                SetProperty(ref _dcBranch1DCCur, value);
            }
        }

        /// <summary>
        /// DC侧支路1：BUS侧电压
        /// </summary>
        private double  _dcBranch1BUSVol;

        public double DcBranch1BUSVol
        {
            get => _dcBranch1BUSVol;
            set
            {
                SetProperty(ref _dcBranch1BUSVol, value);
            }
        }

        /// <summary>
        /// DC侧支路1：直流累计充电电量高两字节
        /// </summary>
        private int _dcBranch1CharHigh;

        public int DcBranch1CharHigh
        {
            get => _dcBranch1CharHigh;
            set
            {
                SetProperty(ref _dcBranch1CharHigh, value);
            }
        }

        /// <summary>
        /// DC侧支路1：直流累计充电电量低两字节
        /// </summary>
        private int _dcBranch1CharLow;

        public int DcBranch1CharLow
        {
            get => _dcBranch1CharLow;
            set
            {
                SetProperty(ref _dcBranch1CharLow, value);
            }
        }

        /// <summary>
        /// DC侧支路1：直流累计充电电量
        /// </summary>
        private double _dcBranch1Char;

        public double DcBranch1Char
        {
            get => _dcBranch1Char;
            set
            {
                SetProperty(ref _dcBranch1Char, value);
            }
        }

        /// <summary>
        /// DC侧支路1：直流累计放电电量高两字节
        /// </summary>
        private int _dcBranch1DisCharHigh;

        public int DcBranch1DisCharHigh
        {
            get => _dcBranch1DisCharHigh;
            set
            {
                SetProperty(ref _dcBranch1DisCharHigh, value);
            }
        }

        /// <summary>
        /// DC侧支路1：直流累计放电电量低两字节
        /// </summary>
        private int _dcBranch1DisCharLow;

        public int DcBranch1DisCharLow
        {
            get => _dcBranch1DisCharLow;
            set
            {
                SetProperty(ref _dcBranch1DisCharLow, value);
            }
        }

        /// <summary>
        /// DC侧支路1：直流累计放电电量
        /// </summary>
        private double _dcBranch1DisChar;

        public double DcBranch1DisChar
        {
            get => _dcBranch1DisChar;
            set
            {
                SetProperty(ref _dcBranch1DisChar, value);
            }
        }

        /// <summary>
        /// DC故障可见度
        /// </summary>
        private Visibility _visDCAlarm;

        public Visibility VisDCAlarm
        {
            get => _visDCAlarm;
            set
            {
                SetProperty(ref _visDCAlarm, value);
            }
        }

        /// <summary>
        /// PDS故障可见度
        /// </summary>
        private Visibility _visPDSAlarm;

        public Visibility VisPDSAlarm
        {
            get => _visPDSAlarm;
            set
            {
                SetProperty(ref _visPDSAlarm, value);
            }
        }



        public Queue<string> FaultShow = new Queue<string>(10);

        

        public pCSMonitorViewModel()
        {

        }

        // 下面是逻辑代码
        public void GetActivePCSControlState()
        {
            int Value;
            Value = ControlStateFlagPCS;
            if ((Value & 0x0100) != 0)
            {
                PCSStateColorRemoteControl = new SolidColorBrush(Colors.Transparent);
                PCSStateColorAutoControl = new SolidColorBrush(Colors.Transparent);
                PCSStateColorManControl = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#98FB98"));
            }
            else if ((Value & 0x0200) != 0)
            {
                PCSStateColorManControl = new SolidColorBrush(Colors.Transparent);
                PCSStateColorRemoteControl = new SolidColorBrush(Colors.Transparent);
                PCSStateColorAutoControl = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#98FB98"));
            }
            else if ((Value & 0x0400) != 0)
            {
                PCSStateColorAutoControl = new SolidColorBrush(Colors.Transparent);
                PCSStateColorManControl = new SolidColorBrush(Colors.Transparent);
                PCSStateColorRemoteControl = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#98FB98"));
            }
            else
            {
                PCSStateColorAutoControl = new SolidColorBrush(Colors.Transparent);
                PCSStateColorManControl = new SolidColorBrush(Colors.Transparent);
                PCSStateColorRemoteControl = new SolidColorBrush(Colors.Transparent);
            }
        }

        public void GetActivePCSState()
        {
            int Value;
            Value = StateFlagPCS;
            if ((Value & 0x0200) != 0)
            {
                FaultStateColorPCS = new SolidColorBrush(Colors.Transparent);
                PowerOnInitStateColorPCS = new SolidColorBrush(Colors.Transparent);
                AlarmStateColorPCS = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#98FB98"));
            }
            else if ((Value & 0x0400) != 0)
            {
                PowerOnInitStateColorPCS = new SolidColorBrush(Colors.Transparent);
                AlarmStateColorPCS = new SolidColorBrush(Colors.Transparent);
                FaultStateColorPCS = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#98FB98"));
            }
            else if ((Value & 0x1000) != 0)
            {
                AlarmStateColorPCS = new SolidColorBrush(Colors.Transparent);
                FaultStateColorPCS = new SolidColorBrush(Colors.Transparent);
                PowerOnInitStateColorPCS = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#98FB98"));
            }
            else
            {
                AlarmStateColorPCS = new SolidColorBrush(Colors.Transparent);
                FaultStateColorPCS = new SolidColorBrush(Colors.Transparent);
                PowerOnInitStateColorPCS = new SolidColorBrush(Colors.Transparent);
            }
        }

        public void GetDCBranchINFO()
        {
            int Value1;
            int Value2;
            
            Value1 = DcBranch1StateFlag1;
            Value2 = DcBranch1StateFlag2;
            if ((Value1&0x0001)!=0)
            {
                DcBranch1State1 = "电池充满";
            }
            else if ((Value1 & 0x0002) != 0)
            {
                DcBranch1State1 = "电池放空";
            }
            else if ((Value1 & 0x0004) != 0)
            {
                DcBranch1State1 = "充电";
            }
            else if ((Value1 & 0x0008) != 0)
            {
                DcBranch1State1 = "放电";
            }
            else if ((Value1 & 0x0040)!=0)
            {
                DcBranch1State1 = "电池恒压均充";
            }


            if ((Value2&0x0001)!=0)
            {
                DcBranch1State2 = "启动";
            }
            else if ((Value2&0x0001)==0)
            {
                DcBranch1State2 = "停止";
            }
        }

        /// <summary>
        /// 电量计算
        /// </summary>
        public void EnergyCal()
        {
            int Value1;
            int Value2;
            int Value3;
            int Value4;
            Value1 = DcBranch1CharHigh;
            Value2 = DcBranch1CharLow;
            Value3 = DcBranch1DisCharHigh;
            Value4 = DcBranch1DisCharLow;
            DcBranch1Char = Value1 << 16 | Value2;
            DcBranch1DisChar = Value3 << 16 | Value4;
        }

        public bool GetActiveDCState()
        {
            int Value1;
            int Value2;
            int Value3;
            bool colorflag = false;
            ObservableCollection<string> INFO = new ObservableCollection<string>();
            Value1 = AlarmStateFlagDC1;
            Value2 = AlarmStateFlagDC2;
            Value3 = AlarmStateFlagDC3;
            if ((Value1 & 0x0001) != 0) { INFO.Add("直流高压侧过压"); colorflag = true; FaultShow.Enqueue("直流高压侧过压"); } //53005 bit0
            if ((Value1 & 0x0002) != 0) { INFO.Add("直流高压侧欠压"); colorflag = true; FaultShow.Enqueue("直流高压侧欠压"); }  //bit1`
            if ((Value1 & 0x0004) != 0) { INFO.Add("直流低压侧过压"); colorflag = true; }  //bit2
            if ((Value1 & 0x0008) != 0) { INFO.Add("直流低压侧欠压"); colorflag = true; }  //bit3
            if ((Value1 & 0x0010) != 0) { INFO.Add("直流低压侧过流"); colorflag = true; }  //bit4
            //if ((Value1 & 0x0020) != 0) { INFO.Add("重启过多"); colorflag = true; } //bit5
            if ((Value1 & 0x0040) != 0) { INFO.Add("重启过多"); colorflag = true; } //bit6
            if ((Value1 & 0x0080) != 0) { INFO.Add("直流低压侧继电器短路"); colorflag = true; } //bit7
            if ((Value1 & 0x0100) != 0) { INFO.Add("光伏能量不足"); colorflag = true; } //bit8
            if ((Value1 & 0x0200) != 0) { INFO.Add("电池电量不足"); colorflag = true; } //bit9
            if ((Value1 & 0x0400) != 0) { INFO.Add("环境温度过高"); colorflag = true; } //bit10
            if ((Value1 & 0x0800) != 0) { INFO.Add("BMS故障或直流高压侧开关断开"); colorflag = true; } //bit11
            if ((Value1 & 0x1000) != 0) { INFO.Add("U2通信异常1"); colorflag = true; } //bit12
            if ((Value1 & 0x2000) != 0) { INFO.Add("机柜温度过高"); colorflag = true; } //bit13
            if ((Value1 & 0x4000) != 0) { INFO.Add("柜温探头故障"); colorflag = true; } //bit14
            if ((Value1 & 0x8000) != 0) { INFO.Add("环温探头故障"); colorflag = true; } //bit15

            if ((Value2 & 0x0001) != 0) { INFO.Add("模块电流不平衡"); colorflag = true; } //53007 bit0
            if ((Value2 & 0x0002) != 0) { INFO.Add("直流低压侧开关断开"); colorflag = true; } //bit1
            if ((Value2 & 0x0004) != 0) { INFO.Add("24V辅助电源故障"); colorflag = true; } //bit2
            if ((Value2 & 0x0008) != 0) { INFO.Add("紧急停机"); colorflag = true; } //bit3
            //if ((Value2 & 0x0010) != 0) { INFO.Add("环温探头故障"); colorflag = true; } //bit4
            //if ((Value2 & 0x0020) != 0) { INFO.Add("环温探头故障"); colorflag = true; } //bit5
            if ((Value2 & 0x0040) != 0) { INFO.Add("模块温度过温"); colorflag = true; } //bit6
            if ((Value2 & 0x0080) != 0) { INFO.Add("风扇故障"); colorflag = true; } //bit7
            if ((Value2 & 0x0100) != 0) { INFO.Add("直流低压侧继电器开路"); colorflag = true; } //bit8
            if ((Value2 & 0x0200) != 0) { INFO.Add("校准参数异常"); colorflag = true; } //bit9
            if ((Value2 & 0x0400) != 0) { INFO.Add("保险故障"); colorflag = true; } //bit10
            if ((Value2 & 0x0800) != 0) { INFO.Add("DSP初始化故障"); colorflag = true; } //bit11
            if ((Value2 & 0x1000) != 0) { INFO.Add("直流低压侧软启动失败"); colorflag = true; } //bit12
            if ((Value2 & 0x2000) != 0) { INFO.Add("CANA通讯故障"); colorflag = true; } //bit13
            if ((Value2 & 0x4000) != 0) { INFO.Add("直流高压侧继电器开路"); colorflag = true; } //bit14
            if ((Value2 & 0x8000) != 0) { INFO.Add("直流高压侧软启动失败"); colorflag = true; } //bit15

            if ((Value3 & 0x0001) != 0) { INFO.Add("DSP版本故障"); colorflag = true; } //53008 bit0
            if ((Value3 & 0x0002) != 0) { INFO.Add("CPLD版本故障"); colorflag = true; } //bit1
            if ((Value3 & 0x0004) != 0) { INFO.Add("参数不匹配"); colorflag = true; } //bit2
            if ((Value3 & 0x0008) != 0) { INFO.Add("硬件版本故障"); colorflag = true; } //bit3
            if ((Value3 & 0x0010) != 0) { INFO.Add("485通讯故障"); colorflag = true; } //bit4
            if ((Value3 & 0x0020) != 0) { INFO.Add("CANB通讯故障"); colorflag = true; } //bit5
            if ((Value3 & 0x0040) != 0) { INFO.Add("模块重号故障"); colorflag = true; } //bit6
            //if ((Value3 & 0x0080) != 0) { INFO.Add("风扇故障"); colorflag = true; } //bit7
            if ((Value3 & 0x0100) != 0) { INFO.Add("15V辅助电源故障"); colorflag = true; } //bit8
            if ((Value3 & 0x0200) != 0) { INFO.Add("直流高压侧继电器短路"); colorflag = true; } //bit9
            if ((Value3 & 0x0400) != 0) { INFO.Add("BMS电压异常"); colorflag = true; } //bit10
            if ((Value3 & 0x0800) != 0) { INFO.Add("BMS电流异常"); colorflag = true; } //bit11
            if ((Value3 & 0x1000) != 0) { INFO.Add("BMS温度异常"); colorflag = true; } //bit12
            if ((Value3 & 0x2000) != 0) { INFO.Add("BMS关机异常"); colorflag = true; } //bit13
            if ((Value3 & 0x4000) != 0) { INFO.Add("绝缘检测异常"); colorflag = true; } //bit14
            //if ((Value3 & 0x8000) != 0) { INFO.Add("直流高压侧软启动失败"); colorflag = true; } //bit15
            AlarmStateDC = INFO;
            return colorflag;
        }

        //private void Demo(int value, ref bool colorflag)
        //{
        //    ObservableCollection<string> INFO = new ObservableCollection<string>();
        //    for (int i = 0; i < 16; i++)
        //    {
        //        Int32 flag = 0x0001;
        //        // todo
        //        if ((value & flag) != 0) 
        //        {
        //            INFO.Add(strlist[i]); 
        //            colorflag = true; 
        //        }
        //        flag = flag << 1;
        //    }

        //    //values.TryDequeue()
        //}

        Queue<string> values;

        public bool GetActivePDSState()
        {
            int Value;
            bool colorflag = false;
            ObservableCollection<string> INFO = new ObservableCollection<string>();
            Value = AlarmStateFlagPDS;
            if ((Value & 0x0001) != 0) { INFO.Add("软件版本故障"); colorflag = true; } //53008 bit0
            if ((Value & 0x0002) != 0) { INFO.Add("DSP初始化故障"); colorflag = true; } //bit1
            if ((Value & 0x0004) != 0) { INFO.Add("BMS故障"); colorflag = true; } //bit2
            if ((Value & 0x0008) != 0) { INFO.Add("紧急停机"); colorflag = true; } //bit3
            if ((Value & 0x0010) != 0) 
            { 
                INFO.Add("防雷器告警"); 
                colorflag = true; 
            } //bit4
            //if ((Value & 0x0020) != 0) { INFO.Add("CANB通讯故障"); colorflag = true; } //bit5
            //if ((Value & 0x0040) != 0) { INFO.Add("模块重号故障"); colorflag = true; } //bit6
            //if ((Value3 & 0x0080) != 0) { INFO.Add("风扇故障"); colorflag = true; } //bit7
            //if ((Value & 0x0100) != 0) { INFO.Add("15V辅助电源故障"); colorflag = true; } //bit8
            //if ((Value & 0x0200) != 0) { INFO.Add("直流高压侧继电器短路"); colorflag = true; } //bit9
            //if ((Value & 0x0400) != 0) { INFO.Add("BMS电压异常"); colorflag = true; } //bit10
            //if ((Value & 0x0800) != 0) { INFO.Add("BMS电流异常"); colorflag = true; } //bit11
            //if ((Value & 0x1000) != 0) { INFO.Add("BMS温度异常"); colorflag = true; } //bit12
            //if ((Value & 0x2000) != 0) { INFO.Add("BMS关机异常"); colorflag = true; } //bit13
            //if ((Value & 0x4000) != 0) { INFO.Add("绝缘检测异常"); colorflag = true; } //bit14
            //if ((Value3 & 0x8000) != 0) { INFO.Add("直流高压侧软启动失败"); colorflag = true; } //bit15
            AlarmStatePDS = INFO;
            return colorflag;
        }







    }
}
