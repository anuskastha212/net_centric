using System;
class CalendarView
{
    static void Main()
    {
        int daysInMonth = 31;
        int startDay = 3;  
        int weeks = (int)Math.Ceiling((daysInMonth + startDay) / 7.0);

        int[][] calendar = new int[weeks][];

        int day = 1;
        for (int i = 0; i < weeks; i++)
        {
            calendar[i] = new int[7]; 
            for (int j = 0; j < 7; j++)
            {
                if ((i == 0 && j < startDay) || day > daysInMonth)
                {
                    calendar[i][j] = 0; 
                }
                else
                {
                    calendar[i][j] = day++;
                }
            }
        }

        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");
        foreach (var week in calendar)
        {
            foreach (var d in week)
            {
                Console.Write(d == 0 ? "    " : $"{d,3} ");
            }
            Console.WriteLine();
        }
    }
}
