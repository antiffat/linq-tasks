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
            var employeesWithHighestSal = LinqTasks.Task4();
            var aliasedEmployees = LinqTasks.Task5();
            var mergedTable = LinqTasks.Task6();
            var jobCounts = LinqTasks.Task7();
            var hasBackendProgrammer = LinqTasks.Task8();
            var newestFrontendDeveloper = LinqTasks.Task9();
            var results = LinqTasks.Task10();
            var departmentGroups = LinqTasks.Task11();
            var managersWithSubordinates = LinqTasks.Task12();
            int[] numbersList = {1, 1, 3, 4, 4, 10, 0, 7, 7, 8, 3, 7, 3};
            int numAppearsOddTimes = LinqTasks.Task13(numbersList);
            Console.WriteLine($"Task 13: {numAppearsOddTimes}");
            
            Console.WriteLine("Task 16:");
            Console.WriteLine("Empno\tEname\tJob\tHireDate\tSalary\tMgr\tDeptno(Emp)\tDeptno(Dept)\tDname\tLoc");

            foreach (var emp in LinqTasks.Emps)
            {
                foreach (var dept in LinqTasks.Depts)
                {
                    // Assuming Mgr is another employee, we may want to print the manager's employee number
                    var mgrEmpno = emp.Mgr?.Empno.ToString() ?? "null";

                    // Print each combination of employee and department details
                    Console.WriteLine($"{emp.Empno}\t{emp.Ename}\t{emp.Job}\t{emp.HireDate:yyyy/MM/dd}\t{emp.Salary}\t{mgrEmpno}\t{emp.Deptno}\t{dept.Deptno}\t{dept.Dname}\t{dept.Loc}");
                }
            }
            
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
            foreach (var emp in employeesWithHighestSal)
            {
                Console.WriteLine($"ID: {emp.Empno}, Name: {emp.Ename}, Job: {emp.Job}, Salary: {emp.Salary}");
            }
            
            Console.WriteLine("Aliased employees:");
            foreach (var emp in aliasedEmployees)
            {
                Console.WriteLine(emp);
            }
            
            Console.WriteLine("Emps and Depts table merged");
            foreach (var item in mergedTable)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Job counts:");
            foreach (var job in jobCounts)
            {
                Console.WriteLine(job);
            }
            
            Console.WriteLine($"We have a backend programmer (True/False): {hasBackendProgrammer}");
            
            Console.WriteLine($"Last hired frontend developer: {newestFrontendDeveloper.Ename}, Hired: {newestFrontendDeveloper.HireDate}");
            
            Console.WriteLine("Task 10:");
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Task 11:");
            foreach (var department in departmentGroups)
            {
                Console.WriteLine(department);
            }
            
            Console.WriteLine("Task 12:");
            foreach (var manager in managersWithSubordinates)
            {
                Console.WriteLine(manager);
            }
        }
    }
}
