﻿using BuildingBlocks;
using ObserverLibrary.NewspaperExample.Publishers;
using ObserverLibrary.NewspaperExample.Subscribers;

namespace ObserverLibrary.NewspaperExample;

public static class NewspaperExecutor
{
    public static void Execute()
    {
        ConsoleExtension.WriteSeparator("Newspaper example");

        var dailyMail = new DailyMail();
        dailyMail.Subscribe(new User("Emma Davis", "emma", 5));
        dailyMail.Subscribe(new User("Mary Miller", "marry", 10));
        dailyMail.Subscribe(new User("Ube Miller", "ube", 6));

        Console.WriteLine();
        dailyMail.MonthlyPrice = 6;

        Console.WriteLine();
        dailyMail.MonthlyPrice = 8;
    }
}
