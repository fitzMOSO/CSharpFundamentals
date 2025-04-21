using System;

namespace CSharpFundamentals.Classes
{
    public class DateTimeDemo
    {
        public static void ShowDateTimeAndTimeSpan()
        {
            DateTimeStaticMembers();
            DateTimeInstanceMembers();
            TimeSpanStaticMembers();
            TimeSpanInstanceMembers();

            DateTimeDifferences();
            TimeSpanDifferences();
        }

        private static void DateTimeStaticMembers()
        {
            Console.WriteLine("=== DateTime Static Members ===");

            // Static properties
            Console.WriteLine($"DateTime.Now: {DateTime.Now}");
            Console.WriteLine($"DateTime.Today: {DateTime.Today}");
            Console.WriteLine($"DateTime.UtcNow: {DateTime.UtcNow}");
            Console.WriteLine($"DateTime.MinValue: {DateTime.MinValue}");
            Console.WriteLine($"DateTime.MaxValue: {DateTime.MaxValue}");

            // Static methods
            Console.WriteLine($"DateTime.IsLeapYear(2024): {DateTime.IsLeapYear(2024)}");
            Console.WriteLine($"DateTime.DaysInMonth(2023, 2): {DateTime.DaysInMonth(2023, 2)}");

            // Parsing methods (static)
            string dateString = "2023-10-01 10:21";
            Console.WriteLine($"DateTime.Parse(\"{dateString}\"): {DateTime.Parse(dateString)}");
            Console.WriteLine(
                $"DateTime.ParseExact(\"{dateString}\", \"yyyy-MM-dd HH:mm\", null): {DateTime.ParseExact(dateString, "yyyy-MM-dd HH:mm", null)}"
            );

            // TryParse methods (static)
            bool success = DateTime.TryParse(dateString, out DateTime result);
            Console.WriteLine($"DateTime.TryParse result: {success}, Value: {result}");

            // Static comparison methods
            var date1 = new DateTime(2023, 10, 1);
            var date2 = new DateTime(2023, 10, 2);
            Console.WriteLine($"DateTime.Compare(date1, date2): {DateTime.Compare(date1, date2)}");

            Console.WriteLine();
        }

        private static void DateTimeInstanceMembers()
        {
            Console.WriteLine("=== DateTime Instance Members ===");

            // Create instance
            var dateTime = new DateTime(2023, 10, 1);
            Console.WriteLine($"Instance dateTime: {dateTime}");

            // Instance properties
            Console.WriteLine($"dateTime.Year: {dateTime.Year}");
            Console.WriteLine($"dateTime.Month: {dateTime.Month}");
            Console.WriteLine($"dateTime.Day: {dateTime.Day}");
            Console.WriteLine($"dateTime.Hour: {dateTime.Hour}");
            Console.WriteLine($"dateTime.Minute: {dateTime.Minute}");
            Console.WriteLine($"dateTime.Second: {dateTime.Second}");
            Console.WriteLine($"dateTime.Millisecond: {dateTime.Millisecond}");
            Console.WriteLine($"dateTime.DayOfWeek: {dateTime.DayOfWeek}");
            Console.WriteLine($"dateTime.DayOfYear: {dateTime.DayOfYear}");
            Console.WriteLine($"dateTime.Ticks: {dateTime.Ticks}");
            Console.WriteLine($"dateTime.Kind: {dateTime.Kind}");
            Console.WriteLine(
                $"dateTime.IsDaylightSavingTime(): {dateTime.IsDaylightSavingTime()}"
            );

            // Instance methods for adding/subtracting time
            var now = DateTime.Now;
            Console.WriteLine($"now.AddDays(5): {now.AddDays(5)}");
            Console.WriteLine($"now.AddHours(5): {now.AddHours(5)}");
            Console.WriteLine($"now.AddMinutes(5): {now.AddMinutes(5)}");
            Console.WriteLine($"now.AddSeconds(5): {now.AddSeconds(5)}");
            Console.WriteLine($"now.AddMilliseconds(5): {now.AddMilliseconds(5)}");
            Console.WriteLine($"now.AddMonths(5): {now.AddMonths(5)}");
            Console.WriteLine($"now.AddYears(5): {now.AddYears(5)}");
            Console.WriteLine($"now.AddTicks(5000): {now.AddTicks(5000)}");

            // Instance conversion methods
            Console.WriteLine($"now.ToLocalTime(): {now.ToLocalTime()}");
            Console.WriteLine($"now.ToUniversalTime(): {now.ToUniversalTime()}");
            Console.WriteLine($"now.ToLongDateString(): {now.ToLongDateString()}");
            Console.WriteLine($"now.ToShortDateString(): {now.ToShortDateString()}");
            Console.WriteLine($"now.ToLongTimeString(): {now.ToLongTimeString()}");
            Console.WriteLine($"now.ToShortTimeString(): {now.ToShortTimeString()}");

            // Instance formatting methods
            Console.WriteLine($"now.ToString(\"d\"): {now.ToString("d")}"); //Select a format using intellisense
            Console.WriteLine($"now.ToString(\"HH:mm:ss\"): {now:HH:mm:ss}");
            Console.WriteLine($"now.ToString(\"yyyy-MM-dd HH:mm:ss\"): {now:yyyy-MM-dd HH:mm:ss}");

            // Instance comparison methods
            var date1 = new DateTime(2023, 10, 1);
            var date2 = new DateTime(2023, 10, 2);
            Console.WriteLine($"date1.CompareTo(date2): {date1.CompareTo(date2)}");
            Console.WriteLine($"date1.Equals(date2): {date1.Equals(date2)}");

            Console.WriteLine();
        }

        private static void TimeSpanStaticMembers()
        {
            Console.WriteLine("=== TimeSpan Static Members ===");

            // Static properties
            Console.WriteLine($"TimeSpan.Zero: {TimeSpan.Zero}");
            Console.WriteLine($"TimeSpan.MinValue: {TimeSpan.MinValue}");
            Console.WriteLine($"TimeSpan.MaxValue: {TimeSpan.MaxValue}");

            // Static creation methods
            Console.WriteLine($"TimeSpan.FromDays(1): {TimeSpan.FromDays(1)}");
            Console.WriteLine($"TimeSpan.FromHours(2): {TimeSpan.FromHours(2)}");
            Console.WriteLine($"TimeSpan.FromMinutes(3): {TimeSpan.FromMinutes(3)}");
            Console.WriteLine($"TimeSpan.FromSeconds(4): {TimeSpan.FromSeconds(4)}");
            Console.WriteLine($"TimeSpan.FromMilliseconds(5): {TimeSpan.FromMilliseconds(5)}");
            Console.WriteLine($"TimeSpan.FromTicks(6): {TimeSpan.FromTicks(6)}");

            // Static parsing methods
            string timeSpanString = "1:02:03";
            Console.WriteLine(
                $"TimeSpan.Parse(\"{timeSpanString}\"): {TimeSpan.Parse(timeSpanString)}"
            );
            Console.WriteLine(
                $"TimeSpan.ParseExact(\"{timeSpanString}\", \"g\", null): {TimeSpan.ParseExact(timeSpanString, "g", null)}"
            );

            // Static TryParse methods
            bool success = TimeSpan.TryParse(timeSpanString, out TimeSpan result);
            Console.WriteLine($"TimeSpan.TryParse result: {success}, Value: {result}");

            // Static comparison method
            var ts1 = new TimeSpan(1, 0, 0);
            var ts2 = new TimeSpan(2, 0, 0);
            Console.WriteLine($"TimeSpan.Compare(ts1, ts2): {TimeSpan.Compare(ts1, ts2)}");

            Console.WriteLine();
        }

        private static void TimeSpanInstanceMembers()
        {
            Console.WriteLine("=== TimeSpan Instance Members ===");

            // Create instance
            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine($"Instance timeSpan: {timeSpan}");

            // Instance properties
            Console.WriteLine($"timeSpan.Days: {timeSpan.Days}");
            Console.WriteLine($"timeSpan.Hours: {timeSpan.Hours}");
            Console.WriteLine($"timeSpan.Minutes: {timeSpan.Minutes}");
            Console.WriteLine($"timeSpan.Seconds: {timeSpan.Seconds}");
            Console.WriteLine($"timeSpan.Milliseconds: {timeSpan.Milliseconds}");
            Console.WriteLine($"timeSpan.Ticks: {timeSpan.Ticks}");

            // Total properties (instance)
            Console.WriteLine($"timeSpan.TotalDays: {timeSpan.TotalDays}");
            Console.WriteLine($"timeSpan.TotalHours: {timeSpan.TotalHours}");
            Console.WriteLine($"timeSpan.TotalMinutes: {timeSpan.TotalMinutes}");
            Console.WriteLine($"timeSpan.TotalSeconds: {timeSpan.TotalSeconds}");
            Console.WriteLine($"timeSpan.TotalMilliseconds: {timeSpan.TotalMilliseconds}");

            // Instance arithmetic methods
            var ts1 = new TimeSpan(1, 0, 0);
            var ts2 = new TimeSpan(0, 30, 0);
            Console.WriteLine($"ts1.Add(ts2): {ts1.Add(TimeSpan.FromMinutes(5))}");
            Console.WriteLine($"ts1.Subtract(ts2): {ts1.Subtract(ts2)}");
            Console.WriteLine($"ts1.Negate(): {ts1.Negate()}");
            Console.WriteLine($"ts1.Duration(): {ts1.Duration()}");
            Console.WriteLine(
                $"TimeSpan.FromDays(-1).Duration(): {TimeSpan.FromDays(-1).Duration()}"
            );

            // Instance comparison methods
            Console.WriteLine($"ts1.CompareTo(ts2): {ts1.CompareTo(ts2)}");
            Console.WriteLine($"ts1.Equals(ts2): {ts1.Equals(ts2)}");

            // Instance formatting methods
            Console.WriteLine($"timeSpan.ToString(): {timeSpan.ToString()}");
            Console.WriteLine($"timeSpan.ToString(\"g\"): {timeSpan.ToString("g")}");
            Console.WriteLine($"timeSpan.ToString(\"c\"): {timeSpan.ToString("c")}");

            Console.WriteLine();
        }

        //Getting the Diff of two Dates/TimeSpans
        private static void DateTimeDifferences()
        {
            Console.WriteLine("=== DateTime Differences ===");

            // Create sample dates
            DateTime past = new DateTime(2023, 1, 1, 8, 30, 0);
            DateTime now = DateTime.Now;
            DateTime future = new DateTime(2025, 12, 31, 23, 59, 59);

            Console.WriteLine($"Past date: {past:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Current date: {now:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"Future date: {future:yyyy-MM-dd HH:mm:ss}\n");

            // Method 1: Subtract dates to get TimeSpan
            Console.WriteLine("Method 1: Subtract dates directly to get TimeSpan");
            TimeSpan difference1 = now - past;
            TimeSpan difference2 = future - now;

            Console.WriteLine(
                $"Time elapsed since past date: {difference1.Days} days, {difference1.Hours} hours, {difference1.Minutes} minutes"
            );
            Console.WriteLine(
                $"Time until future date: {difference2.Days} days, {difference2.Hours} hours, {difference2.Minutes} minutes\n"
            );

            // Method 2: Using TimeSpan properties for total values
            Console.WriteLine("Method 2: Using TimeSpan properties for total values");
            Console.WriteLine($"Total days since past date: {difference1.TotalDays} days");
            Console.WriteLine($"Total hours since past date: {difference1.TotalHours} hours");
            Console.WriteLine($"Total minutes since past date: {difference1.TotalMinutes} minutes");
            Console.WriteLine(
                $"Total seconds since past date: {difference1.TotalSeconds} seconds\n"
            );

            // Method 3: Using DateTime.Subtract method
            Console.WriteLine("Method 3: Using DateTime.Subtract method");
            TimeSpan subtractDifference = now.Subtract(past);
            Console.WriteLine(
                $"Time since past date: {subtractDifference.Days} days, {subtractDifference.Hours} hours, {subtractDifference.Minutes} minutes\n"
            );

            // Method 4: Calculate specific time units
            Console.WriteLine("Method 4: Calculate specific time units");

            // Calculate years, months and remaining days between dates
            int yearsPassed = CalculateYears(past, now);
            int monthsPassed = CalculateMonths(past, now);
            int remainingDays = CalculateRemainingDays(past, now);

            Console.WriteLine($"Years since past date: {yearsPassed}");
            Console.WriteLine($"Months since past date: {monthsPassed}");
            Console.WriteLine(
                $"Approximate years and months: {yearsPassed} years, {monthsPassed % 12} months, {remainingDays} days\n"
            );

            // Method 5: Getting specific date components
            Console.WriteLine("Method 5: Getting time between specific date components");
            DateTime today = DateTime.Today;
            DateTime yesterday = today.AddDays(-1);
            DateTime tomorrow = today.AddDays(1);
            DateTime nextWeek = today.AddDays(7);
            DateTime nextMonth = today.AddMonths(1);
            DateTime nextYear = today.AddYears(1);

            Console.WriteLine($"Hours since midnight: {(DateTime.Now - today).TotalHours:F2}");
            Console.WriteLine(
                $"Hours until midnight: {(today.AddDays(1) - DateTime.Now).TotalHours:F2}"
            );
            Console.WriteLine($"Hours until tomorrow: {(tomorrow - DateTime.Now).TotalHours:F2}");
            Console.WriteLine($"Days until next week: {(nextWeek - today).TotalDays:F0}");
            Console.WriteLine($"Days until next month: {(nextMonth - today).Days}");
            Console.WriteLine($"Days until next year: {(nextYear - today).Days}\n");

            // Method 6: Business days calculation
            Console.WriteLine("Method 6: Business days calculation");
            DateTime startDate = new DateTime(2023, 4, 10); // Monday
            DateTime endDate = new DateTime(2023, 4, 21); // Friday

            int businessDays = CalculateBusinessDays(startDate, endDate);
            Console.WriteLine(
                $"Business days between {startDate:yyyy-MM-dd} and {endDate:yyyy-MM-dd}: {businessDays}"
            );

            Console.WriteLine();
        }

        private static void TimeSpanDifferences()
        {
            Console.WriteLine("=== TimeSpan Differences ===");

            // Create sample TimeSpans
            TimeSpan workDay = new TimeSpan(8, 0, 0); // 8 hours
            TimeSpan breakTime = new TimeSpan(0, 30, 0); // 30 minutes
            TimeSpan lunchTime = new TimeSpan(1, 0, 0); // 1 hour
            TimeSpan meetingTime = new TimeSpan(1, 30, 0); // 1 hour 30 minutes

            Console.WriteLine($"Work day duration: {workDay}");
            Console.WriteLine($"Break time: {breakTime}");
            Console.WriteLine($"Lunch time: {lunchTime}");
            Console.WriteLine($"Meeting time: {meetingTime}\n");

            // Method 1: Subtract TimeSpans
            Console.WriteLine("Method 1: Subtract TimeSpans");
            TimeSpan workMinusBreaks = workDay - (breakTime + lunchTime);
            Console.WriteLine($"Work time minus breaks: {workMinusBreaks}");
            Console.WriteLine($"Actual working hours: {workMinusBreaks.TotalHours:F2} hours\n");

            // Method 2: Difference between TimeSpans
            Console.WriteLine("Method 2: Difference between TimeSpans");
            TimeSpan difference = lunchTime - breakTime;
            Console.WriteLine($"Difference between lunch and break: {difference}");
            Console.WriteLine(
                $"Lunch is {difference.TotalMinutes:F0} minutes longer than a break\n"
            );

            // Method 3: Calculate percentage of time
            Console.WriteLine("Method 3: Calculate percentage of time");
            double meetingPercentage = (meetingTime.TotalMinutes / workDay.TotalMinutes) * 100;
            double breakPercentage = (breakTime.TotalMinutes / workDay.TotalMinutes) * 100;
            double lunchPercentage = (lunchTime.TotalMinutes / workDay.TotalMinutes) * 100;
            double productiveTimePercentage =
                (
                    (workDay - (meetingTime + breakTime + lunchTime)).TotalMinutes
                    / workDay.TotalMinutes
                ) * 100;

            Console.WriteLine($"Meetings take {meetingPercentage:F1}% of work day");
            Console.WriteLine($"Breaks take {breakPercentage:F1}% of work day");
            Console.WriteLine($"Lunch takes {lunchPercentage:F1}% of work day");
            Console.WriteLine($"Productive time is {productiveTimePercentage:F1}% of work day\n");

            // Method 4: Comparing TimeSpans
            Console.WriteLine("Method 4: Comparing TimeSpans");
            Console.WriteLine($"Is meeting longer than lunch? {meetingTime > lunchTime}");
            Console.WriteLine($"Is break shorter than lunch? {breakTime < lunchTime}");
            Console.WriteLine(
                $"Is meeting equal to 1.5 hours? {meetingTime == TimeSpan.FromHours(1.5)}\n"
            );

            // Method 5: Formatting TimeSpan differences
            Console.WriteLine("Method 5: Formatting TimeSpan differences");
            TimeSpan workWeek = TimeSpan.FromHours(40);
            TimeSpan actualWorked = TimeSpan.FromHours(43.5);
            TimeSpan overtime = actualWorked - workWeek;

            Console.WriteLine($"Standard work week: {FormatTimeSpan(workWeek)}");
            Console.WriteLine($"Actual hours worked: {FormatTimeSpan(actualWorked)}");
            Console.WriteLine($"Overtime: {FormatTimeSpan(overtime)}");
            Console.WriteLine($"Overtime in minutes: {overtime.TotalMinutes:F0} minutes");

            Console.WriteLine();
        }

        // Helper methods for working with date differences
        private static int CalculateYears(DateTime startDate, DateTime endDate)
        {
            int years = endDate.Year - startDate.Year;

            // Adjust for incomplete years
            if (
                endDate.Month < startDate.Month
                || (endDate.Month == startDate.Month && endDate.Day < startDate.Day)
            )
            {
                years--;
            }

            return years;
        }

        private static int CalculateMonths(DateTime startDate, DateTime endDate)
        {
            return (endDate.Year - startDate.Year) * 12 + endDate.Month - startDate.Month;
        }

        private static int CalculateRemainingDays(DateTime startDate, DateTime endDate)
        {
            DateTime tempDate = startDate.AddMonths(CalculateMonths(startDate, endDate));
            return (endDate - tempDate).Days;
        }

        private static int CalculateBusinessDays(DateTime startDate, DateTime endDate)
        {
            // Initialize count with number of days between dates
            int businessDays = 0;
            DateTime currentDate = startDate;

            while (currentDate <= endDate)
            {
                // Check if current day is not Saturday (6) or Sunday (0)
                if (
                    currentDate.DayOfWeek != DayOfWeek.Saturday
                    && currentDate.DayOfWeek != DayOfWeek.Sunday
                )
                {
                    businessDays++;
                }

                currentDate = currentDate.AddDays(1);
            }

            return businessDays;
        }

        private static string FormatTimeSpan(TimeSpan timeSpan)
        {
            return $"{(int)timeSpan.TotalHours} hours, {timeSpan.Minutes} minutes";
        }
    }
}
