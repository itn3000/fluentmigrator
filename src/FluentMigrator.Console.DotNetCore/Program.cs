﻿using System;

namespace FluentMigrator.Console.DotNetCore
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                new MigratorConsole(args);
            }
            catch (ArgumentException ex)
            {
                System.Console.WriteLine(ex.Message);
            }
        }
    }
}
