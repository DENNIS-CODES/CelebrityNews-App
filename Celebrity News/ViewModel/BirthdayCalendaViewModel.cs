using System;
using System.Collections.Generic;
using System.Text;

namespace Celebrity_News.ViewModel
{
    /// <summary> 
    /// Interaction logic for MainWindow.xaml 
    /// </summary> 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;
            DateTime? date = picker.SelectedDate;

            if (date == null)
            {
                this.Title = "No date";
            }
            else
            {
                this.Title = date.Value.ToShortDateString();
            }
        }
    }
}
