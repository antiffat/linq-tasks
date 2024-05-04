using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var backendProgrammers = LinqTasks.Task1();
            var frontendProgrammers = LinqTasks.Task2();
            var salary = LinqTasks.Task3();
            var empsWithHighestSal = LinqTasks.Task4();

            Console.WriteLine("All backend programmers:");
            foreach (var emp in backendProgrammers)
            {
                Console.WriteLine($"ID: {emp.Empno}, Name: {emp.Ename}, Job: {emp.Job}, Salary: {emp.Salary}");
            }

            Console.WriteLine("All frontend programmers with salary higher than 1000 sorted in a descending order.");
            foreach (var emp in frontendProgrammers)
            {
                Console.WriteLine($"ID: {emp.Empno}, Name: {emp.Ename}, Job: {emp.Job}, Salary: {emp.Salary}");
            }
            
            Console.WriteLine($"Maximum salary: {salary}");
            
            Console.WriteLine("Employee with the highest salary:");
            foreach (var emp in empsWithHighestSal)
            {
                Console.WriteLine($"ID: {emp.Empno}, Name: {emp.Ename}, Job: {emp.Job}, Salary: {emp.Salary}");
            }
            
        }
    }
}
