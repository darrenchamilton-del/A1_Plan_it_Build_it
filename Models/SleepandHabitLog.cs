namespace SleepTracker.Models
{
    public class SleepAndHabitLog
    {
        public DateTime Bedtime { get; set; }
        public DateTime Waketime { get; set; }
        public double HoursSlept { get; set; }
        public int SleepQuality { get; set; }

        public DateTime LastCaffeine { get; set; }
        public DateTime LastAte { get; set; }
        public DateTime LastExercised { get; set; }
        public DateTime WakeUpTime { get; set; }
        public DateTime MedicationTime { get; set; }
    }
}