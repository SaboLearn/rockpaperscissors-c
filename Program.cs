using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Security.Principal;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int player = 0;
            int pc;
            int points = 0;
            int pc_points = 0;
            int spam;
            bool win = false;
            //when starting (story)
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Welcome to my game!");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("This is a game for your life...");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("Be smart and win in the agent game of");
            System.Threading.Thread.Sleep(1500);
            Console.Write("Rock ");
            System.Threading.Thread.Sleep(500);
            Console.Write("Paper ");
            System.Threading.Thread.Sleep(500);
            Console.Write("Scissors!");
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            //when starting (choice )
            while (pc_points != 3 && points != 3 && win != true)
            {
                if (pc_points != 3 && points != 3)
                {
                    //layout
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("");
                    Console.WriteLine(" ███████╗ █████╗ ██████╗  ██████╗ ");
                    Console.WriteLine(" ██╔════╝██╔══██╗██╔══██╗██╔═══██╗");
                    Console.WriteLine(" ███████╗███████║██████╔╝██║   ██║");
                    Console.WriteLine(" ╚════██║██╔══██║██╔══██╗██║   ██║");
                    Console.WriteLine(" ███████║██║  ██║██████╔╝╚██████╔╝");
                    Console.WriteLine(" ╚══════╝╚═╝  ╚═╝╚═════╝  ╚═════╝ ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" ---------------------------------");
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(" Your Score: {0}", points);
                    Console.WriteLine(" Computer Score: {0}", pc_points);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" ---------------------------------");
                    Console.WriteLine(" Choose what you want!");
                    Console.WriteLine(" [1] Rock");
                    Console.WriteLine(" [2] Paper");
                    Console.WriteLine(" [3] Scissors");
                    Console.WriteLine("");
                    Console.Write(" [1/3] >> ");
                    //choise
                    int x;
                    x = int.Parse(Console.ReadLine());
                    if (x == 1)
                    {
                        player = 1;
                        Console.WriteLine("");
                        Console.WriteLine("You picked Rock!");
                        System.Threading.Thread.Sleep(3000);
                    }
                    else if (x == 2)
                    {
                        player = 2;
                        Console.WriteLine("");
                        Console.WriteLine("You picked Paper!");
                        System.Threading.Thread.Sleep(3000);
                    }
                    else if (x == 3)
                    {
                        player = 3;
                        Console.WriteLine("");
                        Console.WriteLine("You picked Scissors!");
                        System.Threading.Thread.Sleep(3000);
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid Choice, latest choise has been auto selected.");
                        System.Threading.Thread.Sleep(3000);
                    }
                    //pc choose
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" .----------------. ");
                    Console.WriteLine("| .--------------. |");
                    Console.WriteLine("| |    ______    | |");
                    Console.WriteLine("| |   / ____ `.  | |");
                    Console.WriteLine("| |   `'  __) |  | |");
                    Console.WriteLine("| |   _  |__ '.  | |");
                    Console.WriteLine("| |  | |____) |  | |");
                    Console.WriteLine("| |  |_______.'  | |");
                    Console.WriteLine("| |              | |");
                    Console.WriteLine("| '--------------' |");
                    Console.WriteLine(" '----------------' ");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" .----------------. ");
                    Console.WriteLine("| .--------------. |");
                    Console.WriteLine("| |    _____     | |");
                    Console.WriteLine("| |   / ___ `.   | |");
                    Console.WriteLine("| |  |_/___) |   | |");
                    Console.WriteLine("| |   .'____.'   | |");
                    Console.WriteLine("| |  / /____     | |");
                    Console.WriteLine("| |  |_______|   | |");
                    Console.WriteLine("| |              | |");
                    Console.WriteLine("| '--------------' |");
                    Console.WriteLine(" '----------------' ");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" .----------------. ");
                    Console.WriteLine("| .--------------. |");
                    Console.WriteLine("| |     __       | |");
                    Console.WriteLine("| |    /  |      | |");
                    Console.WriteLine("| |    `| |      | |");
                    Console.WriteLine("| |     | |      | |");
                    Console.WriteLine("| |    _| |_     | |");
                    Console.WriteLine("| |   |_____|    | |");
                    Console.WriteLine("| |              | |");
                    Console.WriteLine("| '--------------' |");
                    Console.WriteLine(" '----------------' ");
                    System.Threading.Thread.Sleep(1000);
                    Random rnd = new Random();
                    pc = rnd.Next(1, 3);
                    //win or lose
                    //tie
                    Console.Clear();
                    if (pc == 1 & player == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("    ███      ▄█     ▄████████ ");
                        Console.WriteLine("▀█████████▄ ███    ███    ███ ");
                        Console.WriteLine("   ▀███▀▀██ ███▌   ███    █▀  ");
                        Console.WriteLine("    ███   ▀ ███▌  ▄███▄▄▄     ");
                        Console.WriteLine("    ███     ███▌ ▀▀███▀▀▀     ");
                        Console.WriteLine("    ███     ███    ███    █▄  ");
                        Console.WriteLine("    ███     ███    ███    ███ ");
                        Console.WriteLine("   ▄████▀   █▀     ██████████ ");
                        System.Threading.Thread.Sleep(3000);
                    }
                    else if (pc == 2 & player == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("    ███      ▄█     ▄████████ ");
                        Console.WriteLine("▀█████████▄ ███    ███    ███ ");
                        Console.WriteLine("   ▀███▀▀██ ███▌   ███    █▀  ");
                        Console.WriteLine("    ███   ▀ ███▌  ▄███▄▄▄     ");
                        Console.WriteLine("    ███     ███▌ ▀▀███▀▀▀     ");
                        Console.WriteLine("    ███     ███    ███    █▄  ");
                        Console.WriteLine("    ███     ███    ███    ███ ");
                        Console.WriteLine("   ▄████▀   █▀     ██████████ "); ;
                        System.Threading.Thread.Sleep(3000);
                    }
                    else if (pc == 3 & player == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("    ███      ▄█     ▄████████ ");
                        Console.WriteLine("▀█████████▄ ███    ███    ███ ");
                        Console.WriteLine("   ▀███▀▀██ ███▌   ███    █▀  ");
                        Console.WriteLine("    ███   ▀ ███▌  ▄███▄▄▄     ");
                        Console.WriteLine("    ███     ███▌ ▀▀███▀▀▀     ");
                        Console.WriteLine("    ███     ███    ███    █▄  ");
                        Console.WriteLine("    ███     ███    ███    ███ ");
                        Console.WriteLine("   ▄████▀   █▀     ██████████ ");
                        System.Threading.Thread.Sleep(3000);
                    }
                    //player
                    else if (pc == 1 & player == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("   ▄███████▄  ▄█          ▄████████ ▄██   ▄      ▄████████    ▄████████       ▄█     █▄   ▄██████▄  ███▄▄▄▄   ");
                        Console.WriteLine("  ███    ███ ███         ███    ███ ███   ██▄   ███    ███   ███    ███      ███     ███ ███    ███ ███▀▀▀██▄ ");
                        Console.WriteLine("  ███    ███ ███         ███    ███ ███▄▄▄███   ███    █▀    ███    ███      ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███    ███ ███         ███    ███ ▀▀▀▀▀▀███  ▄███▄▄▄      ▄███▄▄▄▄██▀      ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("▀█████████▀  ███       ▀███████████ ▄██   ███ ▀▀███▀▀▀     ▀▀███▀▀▀▀▀        ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███        ███         ███    ███ ███   ███   ███    █▄  ▀███████████      ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███        ███▌    ▄   ███    ███ ███   ███   ███    ███   ███    ███      ███ ▄█▄ ███ ███    ███ ███   ███ ");
                        Console.WriteLine(" ▄████▀      █████▄▄██   ███    █▀   ▀█████▀    ██████████   ███    ███       ▀███▀███▀   ▀██████▀   ▀█   █▀  ");
                        Console.WriteLine("             ▀                                               ███    ███                                       ");
                        points++;
                        System.Threading.Thread.Sleep(3000);
                    }
                    else if (pc == 2 & player == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("   ▄███████▄  ▄█          ▄████████ ▄██   ▄      ▄████████    ▄████████       ▄█     █▄   ▄██████▄  ███▄▄▄▄   ");
                        Console.WriteLine("  ███    ███ ███         ███    ███ ███   ██▄   ███    ███   ███    ███      ███     ███ ███    ███ ███▀▀▀██▄ ");
                        Console.WriteLine("  ███    ███ ███         ███    ███ ███▄▄▄███   ███    █▀    ███    ███      ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███    ███ ███         ███    ███ ▀▀▀▀▀▀███  ▄███▄▄▄      ▄███▄▄▄▄██▀      ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("▀█████████▀  ███       ▀███████████ ▄██   ███ ▀▀███▀▀▀     ▀▀███▀▀▀▀▀        ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███        ███         ███    ███ ███   ███   ███    █▄  ▀███████████      ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███        ███▌    ▄   ███    ███ ███   ███   ███    ███   ███    ███      ███ ▄█▄ ███ ███    ███ ███   ███ ");
                        Console.WriteLine(" ▄████▀      █████▄▄██   ███    █▀   ▀█████▀    ██████████   ███    ███       ▀███▀███▀   ▀██████▀   ▀█   █▀  ");
                        Console.WriteLine("             ▀                                               ███    ███                                       ");
                        points++;
                        System.Threading.Thread.Sleep(3000);
                    }
                    else if (pc == 3 & player == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("   ▄███████▄  ▄█          ▄████████ ▄██   ▄      ▄████████    ▄████████       ▄█     █▄   ▄██████▄  ███▄▄▄▄   ");
                        Console.WriteLine("  ███    ███ ███         ███    ███ ███   ██▄   ███    ███   ███    ███      ███     ███ ███    ███ ███▀▀▀██▄ ");
                        Console.WriteLine("  ███    ███ ███         ███    ███ ███▄▄▄███   ███    █▀    ███    ███      ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███    ███ ███         ███    ███ ▀▀▀▀▀▀███  ▄███▄▄▄      ▄███▄▄▄▄██▀      ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("▀█████████▀  ███       ▀███████████ ▄██   ███ ▀▀███▀▀▀     ▀▀███▀▀▀▀▀        ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███        ███         ███    ███ ███   ███   ███    █▄  ▀███████████      ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███        ███▌    ▄   ███    ███ ███   ███   ███    ███   ███    ███      ███ ▄█▄ ███ ███    ███ ███   ███ ");
                        Console.WriteLine(" ▄████▀      █████▄▄██   ███    █▀   ▀█████▀    ██████████   ███    ███       ▀███▀███▀   ▀██████▀   ▀█   █▀  ");
                        Console.WriteLine("             ▀                                               ███    ███                                       ");
                        points++;
                        System.Threading.Thread.Sleep(3000);
                    }
                    //pc
                    else if (pc == 2 & player == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("   ▄███████▄  ▄████████       ▄█     █▄   ▄██████▄  ███▄▄▄▄   ");
                        Console.WriteLine("  ███    ███ ███    ███      ███     ███ ███    ███ ███▀▀▀██▄ ");
                        Console.WriteLine("  ███    ███ ███    █▀       ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███    ███ ███             ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("▀█████████▀  ███             ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███        ███    █▄       ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███        ███    ███      ███ ▄█▄ ███ ███    ███ ███   ███ ");
                        Console.WriteLine(" ▄████▀      ████████▀        ▀███▀███▀   ▀██████▀   ▀█   █▀  ");
                        pc_points++;
                        System.Threading.Thread.Sleep(3000);
                    }
                    else if (pc == 3 & player == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("   ▄███████▄  ▄████████       ▄█     █▄   ▄██████▄  ███▄▄▄▄   ");
                        Console.WriteLine("  ███    ███ ███    ███      ███     ███ ███    ███ ███▀▀▀██▄ ");
                        Console.WriteLine("  ███    ███ ███    █▀       ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███    ███ ███             ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("▀█████████▀  ███             ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███        ███    █▄       ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███        ███    ███      ███ ▄█▄ ███ ███    ███ ███   ███ ");
                        Console.WriteLine(" ▄████▀      ████████▀        ▀███▀███▀   ▀██████▀   ▀█   █▀  ");
                        pc_points++;
                        System.Threading.Thread.Sleep(3000);
                    }
                    else if (pc == 1 & player == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("   ▄███████▄  ▄████████       ▄█     █▄   ▄██████▄  ███▄▄▄▄   ");
                        Console.WriteLine("  ███    ███ ███    ███      ███     ███ ███    ███ ███▀▀▀██▄ ");
                        Console.WriteLine("  ███    ███ ███    █▀       ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███    ███ ███             ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("▀█████████▀  ███             ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███        ███    █▄       ███     ███ ███    ███ ███   ███ ");
                        Console.WriteLine("  ███        ███    ███      ███ ▄█▄ ███ ███    ███ ███   ███ ");
                        Console.WriteLine(" ▄████▀      ████████▀        ▀███▀███▀   ▀██████▀   ▀█   █▀  ");
                        pc_points++;
                        System.Threading.Thread.Sleep(3000);
                    }
                }
                
                else
                {
                    win = true;
                }
                Console.Clear();
                if (pc_points == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("   ▄███████▄  ▄████████       ▄█     █▄   ▄██████▄  ███▄▄▄▄   ");
                    Console.WriteLine("  ███    ███ ███    ███      ███     ███ ███    ███ ███▀▀▀██▄ ");
                    Console.WriteLine("  ███    ███ ███    █▀       ███     ███ ███    ███ ███   ███ ");
                    Console.WriteLine("  ███    ███ ███             ███     ███ ███    ███ ███   ███ ");
                    Console.WriteLine("▀█████████▀  ███             ███     ███ ███    ███ ███   ███ ");
                    Console.WriteLine("  ███        ███    █▄       ███     ███ ███    ███ ███   ███ ");
                    Console.WriteLine("  ███        ███    ███      ███ ▄█▄ ███ ███    ███ ███   ███ ");
                    Console.WriteLine(" ▄████▀      ████████▀        ▀███▀███▀   ▀██████▀   ▀█   █▀  ");
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("                          You Suck                            ");
                    Console.WriteLine("--------------------------------------------------------------");
                }
                else if (player == 3)
                {
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("   ▄███████▄  ▄█          ▄████████ ▄██   ▄      ▄████████    ▄████████       ▄█     █▄   ▄██████▄  ███▄▄▄▄   ");
                    Console.WriteLine("  ███    ███ ███         ███    ███ ███   ██▄   ███    ███   ███    ███      ███     ███ ███    ███ ███▀▀▀██▄ ");
                    Console.WriteLine("  ███    ███ ███         ███    ███ ███▄▄▄███   ███    █▀    ███    ███      ███     ███ ███    ███ ███   ███ ");
                    Console.WriteLine("  ███    ███ ███         ███    ███ ▀▀▀▀▀▀███  ▄███▄▄▄      ▄███▄▄▄▄██▀      ███     ███ ███    ███ ███   ███ ");
                    Console.WriteLine("▀█████████▀  ███       ▀███████████ ▄██   ███ ▀▀███▀▀▀     ▀▀███▀▀▀▀▀        ███     ███ ███    ███ ███   ███ ");
                    Console.WriteLine("  ███        ███         ███    ███ ███   ███   ███    █▄  ▀███████████      ███     ███ ███    ███ ███   ███ ");
                    Console.WriteLine("  ███        ███▌    ▄   ███    ███ ███   ███   ███    ███   ███    ███      ███ ▄█▄ ███ ███    ███ ███   ███ ");
                    Console.WriteLine(" ▄████▀      █████▄▄██   ███    █▀   ▀█████▀    ██████████   ███    ███       ▀███▀███▀   ▀██████▀   ▀█   █▀  ");
                    Console.WriteLine("             ▀                                               ███    ███                                       ");
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                }
            }
        }
        
    }
}
