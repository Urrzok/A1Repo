using System;
using System .Threading;
using System.IO;
using System.Runtime.InteropServices;

namespace ConsoleApplication23
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string file = "ticket.csv";
            string userChoice;

            do
            {
                Console.WriteLine("\n1: Read data from file");
                Console.WriteLine("2: Create file from data");
                Console.WriteLine("Any other key will exit the program");

                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {

                    if (File.Exists(file))
                    {
                        
                        StreamReader boop = new StreamReader(file);
                        while (!boop.EndOfStream)
                        {


                            string line = boop.ReadLine();

                            string[] arr = line.Split('|');
                            Console.Write("{0},{1},{2},{3},{4},{5},{6}|{6}|{6}",arr[0],arr[1],arr[2],arr [3],arr [4], arr[5],arr[6]);
                            
                        }
                        boop.Close();
                    }else {
                        Console.WriteLine("File does not exist");
                    }

                }
                
                else if (userChoice == "2")
                {
                    StreamWriter beep = new StreamWriter(file);
                    
                    

                    int ticketID = 1;
                    Console.WriteLine("Give a brief description of the issue you're having");
                    string issue = Console.ReadLine();

                    String status = "Open";
                    
                    Console.WriteLine("Enter proper priority level");
                    string priority = Console.ReadLine();
                    
                    Console.WriteLine("Enter your name");
                    string submitter = Console.ReadLine();

                    String Assigned = "Vergil Klief,John Frank,Dante Deede";
                    string watchingChoice;
                    do
                    {
                        Console.WriteLine("Enter the name of one person who is watching the ticket");
                        string watcher = Console.ReadLine();

                        Console.WriteLine("Do you want to enter another? Y/N");
                        watchingChoice = Console.ReadLine();
                        beep.Write("{0}|{1}|{2}|{3}|{4}|{5}|{6}", ticketID, issue, status, priority, submitter, Assigned, watcher);
                    } while (watchingChoice != "N");
                    
                    beep.Close();
                }
            } while (userChoice == "1" || userChoice == "2");
        }
    }
}
