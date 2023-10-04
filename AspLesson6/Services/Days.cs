namespace AspLesson6.Services
{
    public class Days : IDayOrMonth
    {
        string[] days;
        public Days()
        {
            days = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        }

        public string[] GetWords()
        {
            return days;
        }
    }
}
