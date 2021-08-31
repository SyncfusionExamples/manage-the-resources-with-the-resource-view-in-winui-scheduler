using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.Scheduler;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace CustomResourceView
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            var currentDate = DateTime.Now;
            var casualLeave = new SpecialTimeRegion();
            casualLeave.Text = "Casual leave";
            casualLeave.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.AddDays(-2).Day, 0, 0, 0);
            casualLeave.EndTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.AddDays(-2).Day, 23, 59, 0);
            casualLeave.Background = new SolidColorBrush(Colors.DarkGray);
            casualLeave.Foreground = new SolidColorBrush(Colors.Black);
            casualLeave.RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=1";
            casualLeave.ResourceIdCollection = new ObservableCollection<object>() { "2" };

            var lunch = new SpecialTimeRegion();
            lunch.Text = "Lunch";
            lunch.Foreground = new SolidColorBrush(Colors.Black);
            lunch.StartTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.AddDays(-1).Day, 12, 0, 0);
            lunch.EndTime = new DateTime(currentDate.Year, currentDate.Month, currentDate.AddDays(-1).Day, 13, 0, 0);
            lunch.Background = new SolidColorBrush(Colors.DarkGray);
            lunch.Foreground = new SolidColorBrush(Colors.Black);
            lunch.ResourceIdCollection = new ObservableCollection<object>() { "3" };
            lunch.RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=1";

            Scheduler.DaysViewSettings.SpecialTimeRegions = new ObservableCollection<SpecialTimeRegion>() { casualLeave, lunch };

        }
    }
}
