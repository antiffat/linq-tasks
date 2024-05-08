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
            int[] numbersList = {1, 1, 3, 4, 4, 10, 0, 7, 7, 8, 3, 7, 3}; // SHOULD PRINT 3
            int numAppearsOddTimes = LinqTasks.Task13(numbersList);
            var deptsWithFiveOrNoEmps = LinqTasks.Task14();
            var jobCounts2 = LinqTasks.Task15();
            var jobCombos = LinqTasks.Task16();
            
            Console.WriteLine("Job Counts (where job titles contain 'A' and there are more than 2 employees):");
            foreach (dynamic job in jobCounts2)
            {
                Console.WriteLine($"Job: {job.Praca}, Number of Employees: {job.LiczbaPracownikow}");
            }
            
            Console.WriteLine("Task 14:");
            foreach (var dept in deptsWithFiveOrNoEmps)
            {
                Console.WriteLine($"Deptno: {dept.Deptno}, Dname: {dept.Dname}, Loc: {dept.Loc}");
            }
            Console.WriteLine($"Task 13: {numAppearsOddTimes}");
            
            Console.WriteLine("Task 16:");
            Console.WriteLine("Empno\tEname\tJob\tHireDate\tSalary\tMgr\tDeptno(Emp)\tDeptno(Dept)\tDname\tLoc");

            foreach (dynamic combo in jobCombos)
            {
                Console.WriteLine($"{combo.Empno}\t{combo.Ename}\t{combo.Job}\t{combo.HireDate}\t{combo.Salary}\t{combo.Mgr}\t{combo.DeptnoEmp}\t{combo.DeptnoDept}\t{combo.Dname}\t{combo.Loc}");
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
