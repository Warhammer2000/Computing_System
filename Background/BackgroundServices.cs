using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputingSystem.Background
{
    public static class BackgroundServices
    {
        public static void InitializeProgram()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
        }
        public static void Log(string message, int delay = 100)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(delay); 
            }
            Console.WriteLine();
        }
        public static void ShowCircularLoading(int duration = 3000)
        {
            char[] animation = new[] { '|', '/', '-', '\\' };
            int counter = 0;
            int start = Environment.TickCount;

            while (Environment.TickCount - start < duration)
            {
                Console.Write(animation[counter % animation.Length]);
                System.Threading.Thread.Sleep(100); 
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
                counter++;
            }
            Console.WriteLine("Загрузка завершена!");
        }
        public static void ShowProgressBar(int duration = 3000, int totalBlocks = 20)
        {
            Console.Write("[");
            for (int i = 0; i < totalBlocks; i++)
            {
                Console.Write(" ");
            }
            Console.Write("]");

            int start = Environment.TickCount;
            int blocksFilled = 0;

            while (Environment.TickCount - start < duration)
            {
                int percentageComplete = (Environment.TickCount - start) * 100 / duration;
                int blocksToFill = percentageComplete * totalBlocks / 100;

                while (blocksFilled < blocksToFill)
                {
                    Console.SetCursorPosition(blocksFilled + 1, Console.CursorTop);
                    Console.Write("█");
                    blocksFilled++;
                }

                System.Threading.Thread.Sleep(100); 
            }

            Console.SetCursorPosition(totalBlocks + 2, Console.CursorTop);
            Console.WriteLine(" 100%");
        }
    }
}
