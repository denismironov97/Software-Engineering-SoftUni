using System;
using System.Collections.Generic;

namespace Ex._09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int nCommands = int.Parse(Console.ReadLine());
            string message = string.Empty;
            Stack<string> messageBox = new Stack<string>();

            for (int i = 0; i < nCommands; i++)
            {
                string[] commandData = Console.ReadLine().Split();
                int numCommand = int.Parse(commandData[0]);

                if (numCommand == 1)
                {
                    messageBox.Push(message);
                    string messageToAppend = commandData[1];
                    message += messageToAppend;
                }
                else if (numCommand == 2)
                {
                    int countToRemove = int.Parse(commandData[1]);
                    messageBox.Push(message);
                    //message = message.Substring(0, message.Length - countToRemove); //important index position algorithm

                    int startIndex = message.Length - countToRemove;
                    message = message.Remove(startIndex, countToRemove);
                }
                else if (numCommand == 3)
                {
                    int returnIndex = int.Parse(commandData[1]) - 1;
                    char returnSymbol = message[returnIndex];
                    Console.WriteLine(returnSymbol);
                }
                else if (numCommand == 4)
                {
                    message = messageBox.Pop();
                }
            }
        }
    }
}
