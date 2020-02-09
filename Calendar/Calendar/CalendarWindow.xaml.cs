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
using System.Windows.Shapes;

namespace Calendar
{
    /// <summary>
    /// Logika interakcji dla klasy CalendarWindow.xaml
    /// </summary>
    public partial class CalendarWindow : Window
    {
        public CalendarWindow()
        {
            InitializeComponent();
        }

        private void DpText_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AddNote addNote = new AddNote();
            addNote.Show();
        }

        private void dpick_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            dpText.Text = dpick.SelectedDate.Value.Year.ToString() + "-" +
            dpick.SelectedDate.Value.Month.ToString() + "-" +
            dpick.SelectedDate.Value.Day.ToString();
        }
    }
}
