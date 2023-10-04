namespace AspLesson6.Services
{
    public class Month:IDayOrMonth
    {
        string[] month;
        public Month()
        {
            month = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "November", "October", "December" };
        }
        public string[] GetWords()
        {
            return month;
        }
    }
}
