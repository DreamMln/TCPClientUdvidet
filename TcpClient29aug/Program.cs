using DiceLib29aug;
using System;
using System.IO;
using System.Net.Sockets;
using System.Text.Json;

namespace TcpClient29aug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tcp Client!");

            //kommunikere med serveren, importer dll fil, udfra den protokol er 
            //defineret i serveren, 
            //værdier er hardcodede...
            
            ////////////////////////////////////////
            //brugeren der skal indtaste værdierne//
            ////////////////////////////////////////

            TcpClient socket = new TcpClient("localhost", 7);
            //send en strøm af data
            NetworkStream ns = socket.GetStream();
            //læs stream
            StreamReader reader = new StreamReader(ns);
            //skriv stream
            StreamWriter writer = new StreamWriter(ns);


            //slut client - skriver i console
            string messageReadline = Console.ReadLine();
            //sender det til serveren
            writer.WriteLine(messageReadline);
            //ryd cache - skyl ud!
            writer.Flush();
        
                //det modtages som en string
                    string replyFromServer = reader.ReadLine();
                    Console.WriteLine("Server sent this reply: " + replyFromServer);

        }
    }
}
