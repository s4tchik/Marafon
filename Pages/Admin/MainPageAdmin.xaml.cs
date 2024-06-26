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

namespace Marafon.Pages.Admin
{
    /// <summary>
    /// Логика взаимодействия для MainPageAdmin.xaml
    /// </summary>
    public partial class MainPageAdmin : Page
    {
        public MainPageAdmin()
        {
            InitializeComponent();
        }

        private void btnFund_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageManagementOrganizations());
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageUsers());
        }

        private void btnValunteer_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new PageVolonter());
        }

        private void btnInventory_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
