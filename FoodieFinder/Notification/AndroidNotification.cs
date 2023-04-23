using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.LocalNotification;
using Plugin.LocalNotification.AndroidOption;
using Android.App;
using Android.Content;
using Android.Support.V4.App;
using System.Threading.Tasks;

namespace FoodieFinder.Notification
{
    internal class AndroidNotification
    {
        public bool CreateNotification(int Hour, int Minutes, int Seconds)
        {
            TimeSpan Timer = new TimeSpan(Hour,Minutes, Seconds);


            var request = new NotificationRequest
            {
                NotificationId = 1337,
                Title = Timer.Hours.ToString() + " : " + Timer.Minutes.ToString() + " : " + Timer.Seconds.ToString(),
                Subtitle = "Timer",
                Description = "",
                CategoryType = NotificationCategoryType.Status,
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now,
                    
                },

            };
            var requestdone = new NotificationRequest
            {
                NotificationId = 1338,
                Title = "Timer",
                Subtitle = "Timer",
                Description = "DONE",
                CategoryType = NotificationCategoryType.Alarm,
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now,

                },

            };
            try
            {
                //LocalNotificationCenter.Current.Show(request);

                Task.Run(async () =>
                {
                    TimeSpan StartTime = DateTime.Now.TimeOfDay;
                    TimeSpan DestinationTime = Timer;
                    while (true)
                    {

                        await Task.Delay(100);
                        request.Title = Timer.Hours.ToString() + " : " + Timer.Minutes.ToString() + " : " + Timer.Seconds.ToString();
                        LocalNotificationCenter.Current.Show(request);
                        TimeSpan AfterTime = DateTime.Now.TimeOfDay - StartTime;
                        Timer = DestinationTime - AfterTime;
                        if (AfterTime >= DestinationTime)
                        {
                            LocalNotificationCenter.Current.Cancel(1337);

                            await LocalNotificationCenter.Current.Show(requestdone);
                            break;
                        }
                    }
                });

                LocalNotificationCenter.Current.NotificationActionTapped += Current_NotificationActionTapped;
                return true;
            }
            catch
            {
                return false;
            }

        }
        private void Current_NotificationActionTapped(Plugin.LocalNotification.EventArgs.NotificationActionEventArgs e)
        {
            if (e.IsDismissed)
            {

            }
        }
    }
   
}
