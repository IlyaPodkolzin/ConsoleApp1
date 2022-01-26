using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Text;

namespace DirsFiles
{
    interface ITaskManager
    {
        public void PrintAllTasks();
        public void KillTaskByName(string TaskName);
        public void KillTaskById(int Id);
        public void FindTask(string Str);
    }
    class TaskManager : ITaskManager
    {
        public void FindTask(string Str)
        {
            Console.WriteLine();
            Console.WriteLine("Найденные задачи:");
            Console.WriteLine("Название                                            ID");
            var task_list = Process.GetProcesses();
            for (int i = 0; i < task_list.Length; i++)
            {
                if (task_list[i].ProcessName.ToLower().IndexOf(Str.ToLower()) >= 0)
                {
                    Console.WriteLine($"{task_list[i].ProcessName, 50}  {task_list[i].Id}");
                }
            }
            Console.WriteLine();
        }

        public void KillTaskById(int Id)
        {
            var task_list = Process.GetProcesses();
            for (int i = 0; i < task_list.Length; i++)
            {
                if (task_list[i].Id == Id)
                {
                    task_list[i].Kill();
                }
            }
        }

        public void KillTaskByName(string TaskName)
        {
            var task_list = Process.GetProcesses();
            for (int i = 0; i < task_list.Length; i++)
            {
                if (task_list[i].ProcessName == TaskName)
                {
                    task_list[i].Kill();
                }
            }
        }

        public void PrintAllTasks()
        {
            Console.WriteLine();
            Console.WriteLine("Активные задачи задачи:");
            Console.WriteLine("Название                                            ID");
            var task_list = Process.GetProcesses();
            for (int i=0; i < task_list.Length; i++)
            {
                Console.WriteLine($"{task_list[i].ProcessName, 50}  {task_list[i].Id}");
            }
            Console.WriteLine();
        }
    }
}
