namespace Algorithms.Implementation
{
    public static class TimeConversion
    {
        public static string timeConversion(string s)
        {
            var hour = int.Parse(s.Substring(0, 2));
            var minuetes = s.Substring(2, 6);
            var timeFormat = s.Substring(8, 2);
            if (timeFormat == "PM")
                hour += 12;
            if (hour == 24 || hour == 12)
                hour -= 12;
            return $"{hour:d2}{minuetes}";
        }
    }
}
