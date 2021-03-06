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

namespace Calendar
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        

        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dpick_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            string DayOfWeek = (dpick.SelectedDate.Value.Day - 2).ToString();

            dpText.Text = dpick.SelectedDate.Value.Year.ToString() + "-" +
            dpick.SelectedDate.Value.Month.ToString() + "-" +
            dpick.SelectedDate.Value.Day.ToString() + " this " + DayOfWeek;

            CalendarWindow calendar = new CalendarWindow();
            calendar.Show();
        }
    }
}
