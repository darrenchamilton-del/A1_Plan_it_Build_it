namespace Sleeptracker.Models
{
    public class Alarm
    {
        public DateTime? AlarmTime { get; set; }
        public bool isAlarmSet => AlarmTime.HasValue;

        public bool isAlarmOn { get; set; }

        public DateTime? secondAlarmSet { get; set; }

    }
}
