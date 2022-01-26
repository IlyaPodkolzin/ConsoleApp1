using System;
using System.Diagnostics;

namespace DirsFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new TaskManager();
            String Str = "Hello, World!";
            String[] Str2 = { };
            while (true)
            {
                Console.Write("console>>");
                Str = Console.ReadLine();
                if (Str == "help")
                {
                    Console.WriteLine();
                    Console.WriteLine("FindTask <название задачи>            поиск всех задач с введённым названием");
                    Console.WriteLine("KillTaskById <ID>                     завершение задачи с введённым ID");
                    Console.WriteLine("KillTaskByName <название задачи>      завершение всех задач с введённым названием (рекомендуется по возможности не использовать)");
                    Console.WriteLine("PrintAllTasks                         вывод названий и ID всех активных задач");
                    Console.WriteLine("end                                   завершение работы консоли");
                    Console.WriteLine("help                                  получение справки о командах консоли");
                    Console.WriteLine();
                }
                else
                {
                    if (Str == null) { Str = "Hello, World!"; }
                    Str2 = Str.Split(' ');
                    if (Str2[0] == "FindTask" && Str2.Length > 1)
                    {
                        obj.FindTask(Str2[1]);
                    }
                    else if (Str2[0] == "KillTaskById" && Str2.Length > 1 && int.TryParse(Str2[1], out _))
                    {
                        obj.KillTaskById(Convert.ToInt32(Str2[1]));
                    }
                    else if (Str2[0] == "KillTaskByName" && Str2.Length > 1)
                    {
                        obj.KillTaskByName(Str2[1]);
                    }
                    else if (Str2[0] == "PrintAllTasks")
                    {
                        obj.PrintAllTasks();
                    }
                    else if (Str2[0] == "end")
                    {
                        obj.KillTaskByName("ConsoleApp1");
                    }
                }
            }
        }
    }
}
