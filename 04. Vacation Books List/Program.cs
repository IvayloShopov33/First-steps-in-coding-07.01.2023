﻿using System;

namespace _04._Vacation_Books_List
{
    class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int totalHours = pages / pagesPerHour;
            int hoursPerDay = totalHours / days;
            Console.WriteLine(hoursPerDay);
        }
    }
}
