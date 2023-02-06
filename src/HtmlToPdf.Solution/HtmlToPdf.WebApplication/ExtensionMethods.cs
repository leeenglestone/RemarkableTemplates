namespace HtmlToPdf.WebApplication
{
    public static class ExtensionMethods
    {
        public static string ToFriendlyString(this DateTime dateTime)
        {
            // Desired format
            // Sunday 1st January 2023            

            string ordinal = "";

            if (dateTime.Day == 1)
            {
                ordinal = $"{dateTime.Day}st";
            }
            else if (dateTime.Day == 2)
            {
                ordinal = $"{dateTime.Day}nd";
            }
            else if (dateTime.Day == 3)
            {
                ordinal = $"{dateTime.Day}rd";
            }
            else if (dateTime.Day >= 4)
            {
                ordinal = $"{dateTime.Day}th";
            }
            else if (dateTime.Day > 20)
            {
                if (dateTime.Day.ToString().EndsWith("1"))
                {
                    ordinal = $"{dateTime.Day}st";
                }
                else if (dateTime.Day.ToString().EndsWith("2"))
                {
                    ordinal = $"{dateTime.Day}nd";
                }
                else if (dateTime.Day.ToString().EndsWith("3"))
                {
                    ordinal = $"{dateTime.Day}rd";
                }
                else
                {
                    ordinal = $"{dateTime.Day}th";
                }
            }

            return $"{dateTime:dddd} {ordinal} {dateTime:MMMM} {dateTime:yyyy}";
        }
    }
}
