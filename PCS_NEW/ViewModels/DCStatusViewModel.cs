using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PCS_NEW.ViewModels
{
    public class DCStatusViewModel:ObservableObject
    {
        /// <summary>
        /// 模组一状态
        /// </summary>
        private string _module1Status1;

		public string Module1Status1
        {
			get => _module1Status1;
			set
			{
				SetProperty(ref _module1Status1, value);
			}
		}

        /// <summary>
        /// 模组二状态
        /// </summary>
        private string _module1Status2;

        public string Module1Status2
        {
            get => _module1Status2;
            set
            {
                SetProperty(ref _module1Status2, value);
            }
        }

        /// <summary>
        /// 模组三状态
        /// </summary>
        private string _module1Status3;

        public string Module1Status3
        {
            get => _module1Status3;
            set
            {
                SetProperty(ref _module1Status3, value);
            }
        }

        /// <summary>
        /// 模组四状态
        /// </summary>
        private string _module1Status4;

        public string Module1Status4
        {
            get => _module1Status4;
            set
            {
                SetProperty(ref _module1Status4, value);
            }
        }

        /// <summary>
        /// 模组五状态
        /// </summary>
        private string _module1Status5;

        public string Module1Status5
        {
            get => _module1Status5;
            set
            {
                SetProperty(ref _module1Status5, value);
            }
        }

        /// <summary>
        /// 模组六状态
        /// </summary>
        private string _module1Status6;

        public string Module1Status6
        {
            get => _module1Status6;
            set
            {
                SetProperty(ref _module1Status6, value);
            }
        }

        /// <summary>
        /// 模组七状态
        /// </summary>
        private string _module1Status7;

        public string Module1Status7
        {
            get => _module1Status7;
            set
            {
                SetProperty(ref _module1Status7, value);
            }
        }

        /// <summary>
        /// 模组八状态
        /// </summary>
        private string _module1Status8;

        public string Module1Status8
        {
            get => _module1Status8;
            set
            {
                SetProperty(ref _module1Status8, value);
            }
        }

        /// <summary>
        /// 模组九状态
        /// </summary>
        private string _module1Status9;

        public string Module1Status9
        {
            get => _module1Status9;
            set
            {
                SetProperty(ref _module1Status9, value);
            }
        }

        /// <summary>
        /// 模组十状态
        /// </summary>
        private string _module1Status10;

        public string Module1Status10
        {
            get => _module1Status10;
            set
            {
                SetProperty(ref _module1Status10, value);
            }
        }

        /// <summary>
		/// 模组一状态颜色（蓝色=在线，绿色=运行，黄色=告警，红色=故障）
		/// </summary>
		private SolidColorBrush _module1StatusColor1;

        public SolidColorBrush Module1StatusColor1
        {
            get => _module1StatusColor1;
            set
            {
                SetProperty(ref _module1StatusColor1, value);
            }
        }

        /// <summary>
        /// 模组二状态颜色
        /// </summary>
        private SolidColorBrush _module1StatusColor2;

        public SolidColorBrush Module1StatusColor2
        {
            get => _module1StatusColor2;
            set
            {
                SetProperty(ref _module1StatusColor2, value);
            }
        }

        /// <summary>
        /// 模组三状态颜色
        /// </summary>
        private SolidColorBrush _module1StatusColor3;

        public SolidColorBrush Module1StatusColor3
        {
            get => _module1StatusColor3;
            set
            {
                SetProperty(ref _module1StatusColor3, value);
            }
        }

        /// <summary>
        /// 模组四状态颜色
        /// </summary>
        private SolidColorBrush _module1StatusColor4;

        public SolidColorBrush Module1StatusColor4
        {
            get => _module1StatusColor4;
            set
            {
                SetProperty(ref _module1StatusColor4, value);
            }
        }

        /// <summary>
        /// 模组五状态颜色
        /// </summary>
        private SolidColorBrush _module1StatusColor5;

        public SolidColorBrush Module1StatusColor5
        {
            get => _module1StatusColor5;
            set
            {
                SetProperty(ref _module1StatusColor5, value);
            }
        }

        /// <summary>
        /// 模组六状态颜色
        /// </summary>
        private SolidColorBrush _module1StatusColor6;

        public SolidColorBrush Module1StatusColor6
        {
            get => _module1StatusColor6;
            set
            {
                SetProperty(ref _module1StatusColor6, value);
            }
        }

        /// <summary>
        /// 模组七状态颜色
        /// </summary>
        private SolidColorBrush _module1StatusColor7;

        public SolidColorBrush Module1StatusColor7
        {
            get => _module1StatusColor7;
            set
            {
                SetProperty(ref _module1StatusColor7, value);
            }
        }

        /// <summary>
        /// 模组八状态颜色
        /// </summary>
        private SolidColorBrush _module1StatusColor8;

        public SolidColorBrush Module1StatusColor8
        {
            get => _module1StatusColor8;
            set
            {
                SetProperty(ref _module1StatusColor8, value);
            }
        }

        /// <summary>
        /// 模组九状态颜色
        /// </summary>
        private SolidColorBrush _module1StatusColor9;

        public SolidColorBrush Module1StatusColor9
        {
            get => _module1StatusColor9;
            set
            {
                SetProperty(ref _module1StatusColor9, value);
            }
        }

        /// <summary>
        /// 模组十状态颜色
        /// </summary>
        private SolidColorBrush _module1StatusColor10;

        public SolidColorBrush Module1StatusColor10
        {
            get => _module1StatusColor10;
            set
            {
                SetProperty(ref _module1StatusColor10, value);
            }
        }

        /// <summary>
        /// 模块在线地址状态读取
        /// </summary>
        private int _moduleOnLineFlag;

        public int ModuleOnLineFlag
        {
            get => _moduleOnLineFlag;
            set
            {
                SetProperty(ref _moduleOnLineFlag, value);
            }
        }

        /// <summary>
        /// 模块运行地址状态读取
        /// </summary>
        private int _moduleRunFlag;

        public int ModuleRunFlag
        {
            get => _moduleRunFlag;
            set
            {
                SetProperty(ref _moduleRunFlag, value);
            }
        }

        /// <summary>
        /// 模块告警地址状态读取
        /// </summary>
        private int _moduleAlarmFlag;

        public int ModuleAlarmFlag
        {
            get => _moduleAlarmFlag;
            set
            {
                SetProperty(ref _moduleAlarmFlag, value);
            }
        }

        /// <summary>
        /// 模块故障地址状态读取
        /// </summary>
        private int _moduleFaultFlag;

        public int ModuleFaultFlag
        {
            get => _moduleFaultFlag;
            set
            {
                SetProperty(ref _moduleFaultFlag, value);
            }
        }

        /// <summary>
        /// 现在时间
        /// </summary>
        private DateTime _currentTime;

        public DateTime CurrentTime
        {
            get => _currentTime;
            set
            {
                SetProperty(ref _currentTime, value);
            }
        }






        public void DaqDCModuleStatus()
        {

            int OnLineValue;
            int RunValue;
            int AlarmValue;
            int FaultValue;
            OnLineValue = ModuleOnLineFlag;
            RunValue = ModuleRunFlag;
            AlarmValue = ModuleAlarmFlag;
            FaultValue = ModuleFaultFlag;

            //DC模组1状态
            if ((OnLineValue & 0x0001) != 0 && (RunValue & 0x0001) == 0 && (AlarmValue & 0x0001) == 0 && (FaultValue & 0x0001) == 0)
            {
                Module1Status1 = "在线";
                Module1StatusColor1 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00BFFF"));
            }
            else if ((RunValue & 0x0001) != 0 && (AlarmValue & 0x0001) == 0 && (FaultValue & 0x0001) == 0 && (OnLineValue & 0x0001) == 0)
            {
                Module1Status1 = "运行";
                Module1StatusColor1 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00FF00"));
            }
            else if ((AlarmValue & 0x0001) != 0 && (OnLineValue & 0x0001) == 0 && (RunValue & 0x0001) == 0 && (FaultValue & 0x0001) == 0)
            {
                Module1Status1 = "告警";
                Module1StatusColor1 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF00"));
            }
            else if ((FaultValue & 0x0001) != 0 && (OnLineValue & 0x0001) == 0 && (RunValue & 0x0001) == 0 && (AlarmValue & 0x0001) == 0)
            {
                Module1Status1 = "故障";
                Module1StatusColor1 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));
            }
            else if ((OnLineValue & 0x0001) == 0 && (RunValue & 0x0001) == 0 && (AlarmValue & 0x0001) == 0 && (FaultValue & 0x0001) == 0)
            {
                Module1Status1 = "离线";
                Module1StatusColor1 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A52A2A"));
            }

            //DC模组2状态
            if ((OnLineValue & 0x0002) != 0 && (RunValue & 0x0002) == 0 && (AlarmValue & 0x0002) == 0 && (FaultValue & 0x0002) == 0)
            {
                Module1Status2 = "在线";
                Module1StatusColor2 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00BFFF"));
            }
            else if ((RunValue & 0x0002) != 0 && (AlarmValue & 0x0002) == 0 && (FaultValue & 0x0002) == 0 && (OnLineValue & 0x0002) == 0)
            {
                Module1Status2 = "运行";
                Module1StatusColor2 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00FF00"));
            }
            else if ((AlarmValue & 0x0002) != 0 && (OnLineValue & 0x0002) == 0 && (RunValue & 0x0002) == 0 && (FaultValue & 0x0002) == 0)
            {
                Module1Status2 = "告警";
                Module1StatusColor2 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF00"));
            }
            else if ((FaultValue & 0x0002) != 0 && (OnLineValue & 0x0002) == 0 && (RunValue & 0x0002) == 0 && (AlarmValue & 0x0002) == 0)
            {
                Module1Status2 = "故障";
                Module1StatusColor2 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));
            }
            else if ((OnLineValue & 0x0002) == 0 && (RunValue & 0x0002) == 0 && (AlarmValue & 0x0002) == 0 && (FaultValue & 0x0002) == 0)
            {
                Module1Status2 = "离线";
                Module1StatusColor2 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A52A2A"));
            }

            //DC模组3状态
            if ((OnLineValue & 0x0004) != 0 && (RunValue & 0x0004) == 0 && (AlarmValue & 0x0004) == 0 && (FaultValue & 0x0004) == 0)
            {
                Module1Status3 = "在线";
                Module1StatusColor3 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00BFFF"));
            }
            else if ((RunValue & 0x0004) != 0 && (AlarmValue & 0x0004) == 0 && (FaultValue & 0x0004) == 0 && (OnLineValue & 0x0004) == 0)
            {
                Module1Status3 = "运行";
                Module1StatusColor3 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00FF00"));
            }
            else if ((AlarmValue & 0x0004) != 0 && (OnLineValue & 0x0004) == 0 && (RunValue & 0x0004) == 0 && (FaultValue & 0x0004) == 0)
            {
                Module1Status3 = "告警";
                Module1StatusColor3 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF00"));
            }
            else if ((FaultValue & 0x0004) != 0 && (OnLineValue & 0x0004) == 0 && (RunValue & 0x0004) == 0 && (AlarmValue & 0x0004) == 0)
            {
                Module1Status3 = "故障";
                Module1StatusColor3 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));
            }
            else if((OnLineValue & 0x0004) == 0 && (RunValue & 0x0004) == 0 && (AlarmValue & 0x0004) == 0 && (FaultValue & 0x0004) == 0)
            {
                Module1Status3 = "离线";
                Module1StatusColor3 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A52A2A"));
            }

            //DC模组4状态
            if ((OnLineValue & 0x0008) != 0 && (RunValue & 0x0008) == 0 && (AlarmValue & 0x0008) == 0 && (FaultValue & 0x0008) == 0)
            {
                Module1Status4 = "在线";
                Module1StatusColor4 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00BFFF"));
            }
            else if ((RunValue & 0x0008) != 0 && (AlarmValue & 0x0008) == 0 && (FaultValue & 0x0008) == 0 && (OnLineValue & 0x0008) == 0)
            {
                Module1Status4 = "运行";
                Module1StatusColor4 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00FF00"));
            }
            else if ((AlarmValue & 0x0008) != 0 && (OnLineValue & 0x0008) == 0 && (RunValue & 0x0008) == 0 && (FaultValue & 0x0008) == 0)
            {
                Module1Status4 = "告警";
                Module1StatusColor4 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF00"));
            }
            else if ((FaultValue & 0x0008) != 0 && (OnLineValue & 0x0008) == 0 && (RunValue & 0x0008) == 0 && (AlarmValue & 0x0008) == 0)
            {
                Module1Status4 = "故障";
                Module1StatusColor4 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));
            }
            else if ((OnLineValue & 0x0008) == 0 && (RunValue & 0x0008) == 0 && (AlarmValue & 0x0008) == 0 && (FaultValue & 0x0008) == 0)
            {
                Module1Status4 = "离线";
                Module1StatusColor4 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A52A2A"));
            }

            //DC模组5状态
            if ((OnLineValue & 0x0010) != 0 && (RunValue & 0x0010) == 0 && (AlarmValue & 0x0010) == 0 && (FaultValue & 0x0010) == 0)
            {
                Module1Status5 = "在线";
                Module1StatusColor5 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00BFFF"));
            }
            else if ((RunValue & 0x0010) != 0 && (AlarmValue & 0x0010) == 0 && (FaultValue & 0x0010) == 0 && (OnLineValue & 0x0010) == 0)
            {
                Module1Status5 = "运行";
                Module1StatusColor5 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00FF00"));
            }
            else if ((AlarmValue & 0x0010) != 0 && (OnLineValue & 0x0010) == 0 && (RunValue & 0x0010) == 0 && (FaultValue & 0x0010) == 0)
            {
                Module1Status5 = "告警";
                Module1StatusColor5 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF00"));
            }
            else if ((FaultValue & 0x0010) != 0 && (OnLineValue & 0x0010) == 0 && (RunValue & 0x0010) == 0 && (AlarmValue & 0x0010) == 0)
            {
                Module1Status5 = "故障";
                Module1StatusColor5 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));
            }
            else if ((OnLineValue & 0x0010) == 0 && (RunValue & 0x0010) == 0 && (AlarmValue & 0x0010) == 0 && (FaultValue & 0x0010) == 0)
            {
                Module1Status5 = "离线";
                Module1StatusColor5 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A52A2A"));
            }

            //DC模组6状态
            if ((OnLineValue & 0x0020) != 0 && (RunValue & 0x0020) == 0 && (AlarmValue & 0x0020) == 0 && (FaultValue & 0x0020) == 0)
            {
                Module1Status6 = "在线";
                Module1StatusColor6 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00BFFF"));
            }
            else if ((RunValue & 0x0020) != 0 && (AlarmValue & 0x0020) == 0 && (FaultValue & 0x0020) == 0 && (OnLineValue & 0x0020) == 0)
            {
                Module1Status6 = "运行";
                Module1StatusColor6 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00FF00"));
            }
            else if ((AlarmValue & 0x0020) != 0 && (OnLineValue & 0x0020) == 0 && (RunValue & 0x0020) == 0 && (FaultValue & 0x0020) == 0)
            {
                Module1Status6 = "告警";
                Module1StatusColor6 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF00"));
            }
            else if ((FaultValue & 0x0020) != 0 && (OnLineValue & 0x0020) == 0 && (RunValue & 0x0020) == 0 && (AlarmValue & 0x0020) == 0)
            {
                Module1Status6 = "故障";
                Module1StatusColor6 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));
            }
            else if ((OnLineValue & 0x0020) == 0 && (RunValue & 0x0020) == 0 && (AlarmValue & 0x0020) == 0 && (FaultValue & 0x0020) == 0)
            {
                Module1Status6 = "离线";
                Module1StatusColor6 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A52A2A"));
            }

            //DC模组7状态
            if ((OnLineValue & 0x0040) != 0 && (RunValue & 0x0040) == 0 && (AlarmValue & 0x0040) == 0 && (FaultValue & 0x0040) == 0)
            {
                Module1Status7 = "在线";
                Module1StatusColor7 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00BFFF"));
            }
            else if ((RunValue & 0x0040) != 0 && (AlarmValue & 0x0040) == 0 && (FaultValue & 0x0040) == 0 && (OnLineValue & 0x0040) == 0)
            {
                Module1Status7 = "运行";
                Module1StatusColor7 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00FF00"));
            }
            else if ((AlarmValue & 0x0040) != 0 && (OnLineValue & 0x0040) == 0 && (RunValue & 0x0040) == 0 && (FaultValue & 0x0040) == 0)
            {
                Module1Status7 = "告警";
                Module1StatusColor7 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF00"));
            }
            else if ((FaultValue & 0x0040) != 0 && (OnLineValue & 0x0040) == 0 && (RunValue & 0x0040) == 0 && (AlarmValue & 0x0040) == 0)
            {
                Module1Status7 = "故障";
                Module1StatusColor7 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));
            }
            else if ((OnLineValue & 0x0040) == 0 && (RunValue & 0x0040) == 0 && (AlarmValue & 0x0020) == 0 && (FaultValue & 0x0040) == 0)
            {
                Module1Status7 = "离线";
                Module1StatusColor7 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A52A2A"));
            }

            //DC模组8状态
            if ((OnLineValue & 0x0080) != 0 && (RunValue & 0x0080) == 0 && (AlarmValue & 0x0080) == 0 && (FaultValue & 0x0080) == 0)
            {
                Module1Status8 = "在线";
                Module1StatusColor8 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00BFFF"));
            }
            else if ((RunValue & 0x0080) != 0 && (AlarmValue & 0x0080) == 0 && (FaultValue & 0x0080) == 0 && (OnLineValue & 0x0080) == 0)
            {
                Module1Status8 = "运行";
                Module1StatusColor8 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00FF00"));
            }
            else if ((AlarmValue & 0x0080) != 0 && (OnLineValue & 0x0080) == 0 && (RunValue & 0x0080) == 0 && (FaultValue & 0x0080) == 0)
            {
                Module1Status8 = "告警";
                Module1StatusColor8 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF00"));
            }
            else if ((FaultValue & 0x0080) != 0 && (OnLineValue & 0x0080) == 0 && (RunValue & 0x0080) == 0 && (AlarmValue & 0x0080) == 0)
            {
                Module1Status8 = "故障";
                Module1StatusColor8 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));
            }
            else if ((OnLineValue & 0x0080) == 0 && (RunValue & 0x0080) == 0 && (AlarmValue & 0x0080) == 0 && (FaultValue & 0x0080) == 0)
            {
                Module1Status8 = "离线";
                Module1StatusColor8 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A52A2A"));
            }

            //DC模组9状态
            if ((OnLineValue & 0x0100) != 0 && (RunValue & 0x0100) == 0 && (AlarmValue & 0x0100) == 0 && (FaultValue & 0x0100) == 0)
            {
                Module1Status9 = "在线";
                Module1StatusColor9 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00BFFF"));
            }
            else if ((RunValue & 0x0100) != 0 && (AlarmValue & 0x0100) == 0 && (FaultValue & 0x0100) == 0 && (OnLineValue & 0x0100) == 0)
            {
                Module1Status9 = "运行";
                Module1StatusColor9 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00FF00"));
            }
            else if ((AlarmValue & 0x0100) != 0 && (OnLineValue & 0x0100) == 0 && (RunValue & 0x0100) == 0 && (FaultValue & 0x0100) == 0)
            {
                Module1Status9 = "告警";
                Module1StatusColor9 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF00"));
            }
            else if ((FaultValue & 0x0100) != 0 && (OnLineValue & 0x0100) == 0 && (RunValue & 0x0100) == 0 && (AlarmValue & 0x0100) == 0)
            {
                Module1Status9 = "故障";
                Module1StatusColor9 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));
            }
            else if ((OnLineValue & 0x0100) == 0 && (RunValue & 0x0100) == 0 && (AlarmValue & 0x0100) == 0 && (FaultValue & 0x0100) == 0)
            {
                Module1Status9 = "离线";
                Module1StatusColor9 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A52A2A"));
            }

            // DC模组10状态
            if ((OnLineValue & 0x0200) != 0 && (RunValue & 0x0200) == 0 && (AlarmValue & 0x0200) == 0 && (FaultValue & 0x0200) == 0)
            {
                Module1Status10 = "在线";
                Module1StatusColor10 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00BFFF"));
            }
            else if ((RunValue & 0x0200) != 0 && (AlarmValue & 0x0200) == 0 && (FaultValue & 0x0200) == 0 && (OnLineValue & 0x0200) == 0)
            {
                Module1Status10 = "运行";
                Module1StatusColor10 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#00FF00"));
            }
            else if ((AlarmValue & 0x0200) != 0 && (OnLineValue & 0x0200) == 0 && (RunValue & 0x0200) == 0 && (FaultValue & 0x0200) == 0)
            {
                Module1Status10 = "告警";
                Module1StatusColor10 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFF00"));
            }
            else if ((FaultValue & 0x0200) != 0 && (OnLineValue & 0x0200) == 0 && (RunValue & 0x0200) == 0 && (AlarmValue & 0x0200) == 0)
            {
                Module1Status10 = "故障";
                Module1StatusColor10 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));
            }
            else if ((OnLineValue & 0x0200) == 0 && (RunValue & 0x0200) == 0 && (AlarmValue & 0x0200) == 0 && (FaultValue & 0x0200) == 0)
            {
                Module1Status10 = "离线";
                Module1StatusColor10 = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#A52A2A"));
            }
        }
    }
}
