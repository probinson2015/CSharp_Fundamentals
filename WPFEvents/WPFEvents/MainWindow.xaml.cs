﻿using System;
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

namespace WPFEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.Click += buttonMyOtherClick ;
        }
        //created manually
        private void buttonMyOtherClick(object sender, RoutedEventArgs e)
        {
            myOtherLabel.Content = "Hello Again!";
        }
        //created by dbl clicking in the object properties event textbox
        private void button_Click(object sender, RoutedEventArgs e)
        {
            myLabel.Content = "Hello World!!";
        }
    }
}
