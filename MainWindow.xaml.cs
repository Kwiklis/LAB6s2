﻿using System;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB6s2
{
    //test commit
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }
        public void plus_Click(object sender, RoutedEventArgs e)
        {
            if (A.Text.Length > 0 && B.Text.Length > 0)
            {
                Result.Content = Convert.ToInt32(A.Text)+Convert.ToInt32(B.Text);
            }
        }
        public void minus_Click(object sender, RoutedEventArgs e)
        {
            if (A.Text.Length > 0 && B.Text.Length > 0)
            {
                Result.Content = Convert.ToInt32(A.Text) - Convert.ToInt32(B.Text);
            }
        }
        public void umn_Click(object sender, RoutedEventArgs e)
        {
            if (A.Text.Length > 0 && B.Text.Length > 0)
            {
                Result.Content = Convert.ToInt32(A.Text) * Convert.ToInt32(B.Text);
            }
        }
    }
}
