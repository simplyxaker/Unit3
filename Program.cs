using System;
using System.ComponentModel.Design;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics;

namespace Uni1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {

               
            Console.WriteLine("It is not an official version of Termux, and only consists of certain commands\r\n\r\n");
            
            Console.WriteLine("Welcome to NewTepmuh2.0 in C#!\r\n\r\n" +
                "Communities: https://termux.org/community\r\n" +
                "Gitter chat: https://gitter .im/termux/termux\r\n" +
                "IRC channel: #termux on libera.chat\r\n\r\n");

            Console.WriteLine("Just write help\n\r");

                while (true)
                {
                    Console.WriteLine("~" + " $");
                    string b = Console.ReadLine();

                    if (b == "help")
                    {
                        Console.WriteLine();
                        Console.WriteLine("1.EXPLORER\r\n" +
                            "2.START\r\n" +
                            "3.CMD\r\n" + "4.CLEAR\r\n");
                    }

                    else if (b == "EXPLORER") {
                        Process.Start("explorer.exe");
                    }

                    else if (b == "START")
                    {
                        Process.Start("explorer.exe", "shell:::{2559a1f3-21d7-11d4-bdaf-00c04f60b9f0}");
                    }

                    else if (b == "CMD")
                    {
                        Process.Start("cmd.exe");
                    }

                    else if (b == "CLEAR")
                    {
                        Console.Clear(); 
                    }
                }
            }
        }
    } 
} 
