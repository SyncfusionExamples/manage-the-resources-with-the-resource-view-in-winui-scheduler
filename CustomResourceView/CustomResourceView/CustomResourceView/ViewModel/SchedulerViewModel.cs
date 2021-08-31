using Microsoft.UI;
using Microsoft.UI.Xaml.Media;
using Syncfusion.UI.Xaml.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CustomResourceView
{
    public class SchedulerViewModel : NotificationObject
    {
        private ObservableCollection<Appointment> appointments;
        public SchedulerViewModel()
        {
            this.Appointments = new ObservableCollection<Appointment>();
            this.CreateAppointments();
        }

        /// <summary>
        /// list appointment collection
        /// </summary>
        public ObservableCollection<Appointment> Appointments
        {
            get
            {
                return appointments;
            }

            set
            {
                appointments = value;
                this.RaisePropertyChanged("Appointments");
            }
        }


        #region BookingAppointments

        /// <summary>
        /// Method for booking appointments.
        /// </summary>
        private void CreateAppointments()
        {
            DateTime date = DateTime.Now.Date;

            // Appointments of first Resource.
            // Normal appointments.
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 12, 0, 0), Title = "General CheckUp", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 13, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 15, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 19, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 21, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 13, 0, 0), Title = "Meeting", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 14, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 13, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.Day, 15, 0, 0), To = new DateTime(date.Year, date.Month, date.Day, 17, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 13, 0, 0), Title = "General CheckUp", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 13, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 15, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 19, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 21, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 13, 0, 0), Title = "Meeting", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 14, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 15, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });

            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 14, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 7, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 09, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 9, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 12, 0, 0), Title = "Meeting", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 15, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 15, 0, 0), Title = "General CheckUp", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 16, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 18, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 14, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 16, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.Day, 8, 0, 0), To = new DateTime(date.Year, date.Month, date.Day, 10, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 17, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 18, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 7, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 09, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 10, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 15, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 15, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 21, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 20, 0, 0), Title = "Meeting", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 18, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 18, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });

            //Sapnned appointments.
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 2, 11, 0, 0), To = new DateTime(date.Year, date.Month, 7, 12, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 8, 14, 0, 0), To = new DateTime(date.Year, date.Month, 15, 15, 0, 0), Title = "Project plan", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 16, 10, 0, 0), To = new DateTime(date.Year, date.Month, 21, 11, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 23, 5, 0, 0), To = new DateTime(date.Year, date.AddMonths(1).Month, 2, 6, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });

            //All day appointments.
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 5, 19, 0, 0), To = new DateTime(date.Year, date.Month, 5, 20, 0, 0), Title = "Surgery", IsAllDay = true, Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 10, 14, 0, 0), To = new DateTime(date.Year, date.Month, 10, 15, 0, 0), Title = "Consulting", IsAllDay = true, Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 15, 6, 0, 0), To = new DateTime(date.Year, date.Month, 15, 7, 0, 0), Title = "Consulting", IsAllDay = true, Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 22, 16, 0, 0), To = new DateTime(date.Year, date.Month, 22, 17, 0, 0), Title = "CheckUp", IsAllDay = true, Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 26, 17, 0, 0), To = new DateTime(date.Year, date.Month, 26, 18, 0, 0), Title = "Surgery", IsAllDay = true, Color = new SolidColorBrush(Colors.DarkViolet), Assignees = new ObservableCollection<object> { "1" } });

            // Appointments of second Resource.
            // Normal appointments.
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 9, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 11, 0, 0), Title = "General CheckUp", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 14, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 18, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 20, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 12, 0, 0), Title = "Meeting", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 13, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 12, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.Day, 14, 0, 0), To = new DateTime(date.Year, date.Month, date.Day, 16, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 12, 0, 0), Title = "General CheckUp", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 18, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 20, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 12, 0, 0), Title = "Meeting", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 13, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 12, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });

            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 13, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 15, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 8, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 10, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 13, 0, 0), Title = "Meeting", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 16, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 16, 0, 0), Title = "General CheckUp", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 17, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 19, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 15, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 17, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.Day, 9, 0, 0), To = new DateTime(date.Year, date.Month, date.Day, 11, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 17, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 19, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 09, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 11, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 14, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 16, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 20, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 21, 0, 0), Title = "Meeting", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 17, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 19, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });

            //Sapnned appointments.
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 1, 11, 0, 0), To = new DateTime(date.Year, date.Month, 6, 12, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 7, 14, 0, 0), To = new DateTime(date.Year, date.Month, 14, 15, 0, 0), Title = "Project plan", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 19, 10, 0, 0), To = new DateTime(date.Year, date.Month, 26, 11, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 27, 5, 0, 0), To = new DateTime(date.Year, date.AddMonths(1).Month, 1, 6, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });

            //All day appointments.
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 6, 19, 0, 0), To = new DateTime(date.Year, date.Month, 6, 20, 0, 0), Title = "Surgery", IsAllDay = true, Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 11, 14, 0, 0), To = new DateTime(date.Year, date.Month, 11, 15, 0, 0), Title = "Consulting", IsAllDay = true, Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 15, 6, 0, 0), To = new DateTime(date.Year, date.Month, 15, 7, 0, 0), Title = "Consulting", IsAllDay = true, Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 22, 16, 0, 0), To = new DateTime(date.Year, date.Month, 22, 17, 0, 0), Title = "CheckUp", IsAllDay = true, Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 26, 17, 0, 0), To = new DateTime(date.Year, date.Month, 26, 18, 0, 0), Title = "Surgery", IsAllDay = true, Color = new SolidColorBrush(Colors.OrangeRed), Assignees = new ObservableCollection<object> { "2" } });

            // Appointments of third Resource.
            // Normal appointments.
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 9, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 11, 0, 0), Title = "General CheckUp", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 14, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 18, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 20, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 12, 0, 0), Title = "Meeting", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 13, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 12, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.Day, 14, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 14, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 16, 0, 0), Title = "General CheckUp", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 14, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 13, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 15, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 12, 0, 0), Title = "Meeting", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 11, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 13, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 12, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });

            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 12, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-6).Day, 14, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 7, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-5).Day, 09, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 9, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-4).Day, 12, 0, 0), Title = "Meeting", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 15, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-3).Day, 15, 0, 0), Title = "General CheckUp", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 16, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-2).Day, 18, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 14, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(-1).Day, 16, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.Day, 8, 0, 0), To = new DateTime(date.Year, date.Month, date.Day, 10, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 17, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(1).Day, 18, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 9, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(2).Day, 11, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 10, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(3).Day, 10, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 15, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(4).Day, 15, 0, 0), Title = "Surgery", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 21, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(5).Day, 20, 0, 0), Title = "Meeting", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 18, 0, 0), To = new DateTime(date.Year, date.Month, date.AddDays(6).Day, 18, 0, 0), Title = "Consulting", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });

            //Sapnned appointments.
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 3, 11, 0, 0), To = new DateTime(date.Year, date.Month, 10, 12, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 13, 14, 0, 0), To = new DateTime(date.Year, date.Month, 16, 15, 0, 0), Title = "Project plan", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 17, 10, 0, 0), To = new DateTime(date.Year, date.Month, 25, 11, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 27, 5, 0, 0), To = new DateTime(date.Year, date.AddMonths(1).Month, 3, 6, 0, 0), Title = "CheckUp", Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });

            //All day appointments.
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 5, 19, 0, 0), To = new DateTime(date.Year, date.Month, 5, 20, 0, 0), Title = "Surgery", IsAllDay = true, Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 10, 14, 0, 0), To = new DateTime(date.Year, date.Month, 10, 15, 0, 0), Title = "Consulting", IsAllDay = true, Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 15, 6, 0, 0), To = new DateTime(date.Year, date.Month, 15, 7, 0, 0), Title = "Consulting", IsAllDay = true, Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 22, 16, 0, 0), To = new DateTime(date.Year, date.Month, 22, 17, 0, 0), Title = "CheckUp", IsAllDay = true, Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
            this.Appointments.Add(new Appointment() { From = new DateTime(date.Year, date.Month, 26, 17, 0, 0), To = new DateTime(date.Year, date.Month, 26, 18, 0, 0), Title = "Surgery", IsAllDay = true, Color = new SolidColorBrush(Colors.MediumSeaGreen), Assignees = new ObservableCollection<object> { "3" } });
        }

        #endregion BookingAppointments
    }
}
