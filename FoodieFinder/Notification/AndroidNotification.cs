using Plugin.LocalNotification;

namespace FoodieFinder.Notification
{
    internal class AndroidNotification
    {
        public bool CreateNotification(int Hour, int Minutes, int Seconds)
        {
            TimeSpan Timer = new TimeSpan(Hour,Minutes, Seconds);

            TimeSpan RealEndTime = DateTime.Now.TimeOfDay;
            RealEndTime = RealEndTime.Add(Timer);
            var request = new NotificationRequest
            {
                NotificationId = 1337,
                Title = "Alarm is set to: " + RealEndTime.Hours.ToString() + " : " + RealEndTime.Minutes.ToString() + " : " + RealEndTime.Seconds.ToString(),
                Subtitle = "Alarm",
                Description = "",
                CategoryType = NotificationCategoryType.Status,
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now,
                    
                },

            };
            
            try
            {
                LocalNotificationCenter.Current.Show(request);

                Task.Run(async () =>
                {
                    TimeSpan StartTime = DateTime.Now.TimeOfDay;
                    TimeSpan DestinationTime = Timer;
                    while (true)
                    {

                        await Task.Delay(1000);
                        //request.Title = Timer.Hours.ToString() + " : " + Timer.Minutes.ToString() + " : " + Timer.Seconds.ToString();
                        
                        TimeSpan AfterTime = DateTime.Now.TimeOfDay - StartTime;
                        Timer = DestinationTime - AfterTime;
                        if (AfterTime >= DestinationTime)
                        {
                            LocalNotificationCenter.Current.Cancel(1337);
                            Set_Done_Notification();
                            
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
        private void Set_Done_Notification()
        {
            var requestdone = new NotificationRequest
            {
                NotificationId = 1338,
                Title = "",
                Subtitle = "Timer",
                Description = "DONE",
                CategoryType = NotificationCategoryType.Alarm,
                Schedule = new NotificationRequestSchedule
                {
                    NotifyTime = DateTime.Now,

                },

            };
            LocalNotificationCenter.Current.Show(requestdone);
            
        }
    }
   
}
