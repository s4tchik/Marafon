﻿using Marafon.ClassHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using Marafon.Pages;

namespace Marafon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FrameApp.frmObj = mainFrame;
            mainFrame.Navigate(new PageMain());

            OdbConectHelper.dbobj = new DataBaseEntities();
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageMain());
        }
    }
}
