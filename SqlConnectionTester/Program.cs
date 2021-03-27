using Microsoft.Data.SqlClient;
using System;

namespace AzureSqlConnectionTester
{
    class Program
    {
        static void Main(string[] args)
        {
            bool again = true;
            while(again)
            {
                Console.WriteLine("Enter the SQL connexion string you want to test :");
                string connetionString = Console.ReadLine();
                using (var connexion = new SqlConnection(connetionString))
                {
                    try
                    {
                        connexion.Open();
                        WriteSuccess("Connection opened !");
                        connexion.Close();
                    }
                    catch (Exception ex)
                    {
                        WriteFaillure("Can not open connection !");
                        WriteFaillure(ex.Message);
                    }
                }
                Console.WriteLine();
            }
        }

        static void WriteSuccess(string message)
        {
            WriteLine(message, ConsoleColor.Green);
        }

        static void WriteFaillure(string message)
        {
            WriteLine(message, ConsoleColor.Red);
        }

        static void WriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message.PadRight(Console.WindowWidth - 1));
            Console.ResetColor();
        }
    }
}
