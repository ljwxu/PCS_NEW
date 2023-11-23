﻿using PCS_NEW.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PCS_NEW
{
    


    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        MainViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();

            viewModel = new MainViewModel();
            this.DataContext = viewModel;

            PCSMonitorView.DataContext = viewModel.pCSMonitorViewModel;
            DCStatusView.DataContext = viewModel.dCStatusViewModel;
            PCSSettingView.DataContext = viewModel.pCSSettingViewModel;
            FaultView.DataContext = viewModel.faultViewModel;
            
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            viewModel.isRead = false;

            if(viewModel.thread!=null)
            {
                if (viewModel.thread.ThreadState == ThreadState.Stopped)
                {
                     viewModel.thread = null;
                }
            }
        }
    }
}