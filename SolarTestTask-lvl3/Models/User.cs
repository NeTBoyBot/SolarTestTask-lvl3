namespace SolarTestTask_lvl3.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string? UserName { get; set; }

        public DateTime birthDay { get; set; }

        public DateTime nearestbirthDay { get; set; }

        public TimeSpan TimeBeforeBirthday
        {
            get => DateTime.Now - nearestbirthDay;
        }

        public override string ToString()
        {
            return $"[{UserID}] {UserName} {birthDay.ToString("d")}";
        }

    }
}
