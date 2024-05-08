using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            // Backend Programmers
            Console.WriteLine("TASK 1: Backend Programmers:");
            var backendProgrammers = LinqTasks.Task1();
            foreach (var emp in backendProgrammers)
            {
                Console.WriteLine($"ID: {emp.Empno}, Name: {emp.Ename}, Job: {emp.Job}, Salary: {emp.Salary}");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Frontend Programmers
            Console.WriteLine("TASK 2: Frontend Programmers with salary over 1000, sorted by name descending:");
            var frontendProgrammers = LinqTasks.Task2();
            foreach (var emp in frontendProgrammers)
            {
                Console.WriteLine($"ID: {emp.Empno}, Name: {emp.Ename}, Job: {emp.Job}, Salary: {emp.Salary}");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Maximum Salary
            Console.WriteLine("TASK 3: Maximum Salary Across All Employees:");
            var salary = LinqTasks.Task3();
            Console.WriteLine($"Maximum salary: {salary}");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Employee with the Highest Salary
            Console.WriteLine("TAS 4: Employee with the Highest Salary:");
            var employeesWithHighestSal = LinqTasks.Task4();
            foreach (var emp in employeesWithHighestSal)
            {
                Console.WriteLine($"ID: {emp.Empno}, Name: {emp.Ename}, Job: {emp.Job}, Salary: {emp.Salary}");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Aliased Employees
            Console.WriteLine("TASK 5: Aliased Employees (Custom Output Formats):");
            var aliasedEmployees = LinqTasks.Task5();
            foreach (dynamic emp in aliasedEmployees)
            {
                Console.WriteLine($"Name: {emp.Nazwisko}, Job: {emp.Praca}");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Merged Emps and Depts Table
            Console.WriteLine("TASK 6: Merged Emps and Depts Table:");
            var mergedTable = LinqTasks.Task6();
            foreach (dynamic item in mergedTable)
            {
                Console.WriteLine($"Name: {item.Ename}, Job: {item.Job}, Department: {item.Dname}");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Job Counts
            Console.WriteLine("TASK 7: Job Counts:");
            var jobCounts = LinqTasks.Task7();
            foreach (dynamic job in jobCounts)
            {
                Console.WriteLine($"Job: {job.Praca}, Number of Employees: {job.LiczbaPracownikow}");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Check for Backend Programmers Existence
            Console.WriteLine("TASK 8: Check for Backend Programmers Existence:");
            var hasBackendProgrammer = LinqTasks.Task8();
            Console.WriteLine($"We have a backend programmer (True/False): {hasBackendProgrammer}");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Newest Frontend Developer
            Console.WriteLine("TASK 9: Newest Frontend Developer:");
            var newestFrontendDeveloper = LinqTasks.Task9();
            Console.WriteLine($"Last hired frontend developer: {newestFrontendDeveloper.Ename}, Hired: {newestFrontendDeveloper.HireDate:yyyy/MM/dd}");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Union of Employee Info with a Default Entry
            Console.WriteLine("TASK 10: Union of Employee Info with a Default Entry:");
            var results = LinqTasks.Task10();
            foreach (dynamic item in results)
            {
                string formattedHireDate = item.HireDate != null ? item.HireDate.ToString("yyyy/MM/dd") : "null";                
                Console.WriteLine($"Name: {item.Ename}, Job: {item.Job ?? "No Job"}, HireDate: {formattedHireDate}");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Employees by Department
            Console.WriteLine("TASK 11: Employees by Department:");
            var departmentGroups = LinqTasks.Task11();
            foreach (dynamic department in departmentGroups)
            {
                Console.WriteLine($"Department: {department.name}, Number of Employees: {department.numOfEmployees}");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Employees with Subordinates
            Console.WriteLine("TASK 12: Employees with Subordinates:");
            var managersWithSubordinates = LinqTasks.Task12();
            foreach (var manager in managersWithSubordinates)
            {
                Console.WriteLine($"Manager: {manager.Ename}, Salary: {manager.Salary}");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Number that Appears Odd Times in Array
            Console.WriteLine("TASK 13: Number that Appears Odd Times in Array:");
            int[] numbersList = {1, 1, 3, 4, 4, 10, 0, 7, 7, 8, 3, 7, 3}; // Should print 3
            int numAppearsOddTimes = LinqTasks.Task13(numbersList);
            Console.WriteLine($"Number that appears odd times: {numAppearsOddTimes}");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Departments with Five or No Employees
            Console.WriteLine("TASK 14: Departments with Five or No Employees:");
            var deptsWithFiveOrNoEmps = LinqTasks.Task14();
            foreach (var dept in deptsWithFiveOrNoEmps)
            {
                Console.WriteLine($"Deptno: {dept.Deptno}, Dname: {dept.Dname}, Loc: {dept.Loc}");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Job Counts with 'A' in the Job Title
            Console.WriteLine("TASK 15: Job Counts (where job titles contain 'A' and there are more than 2 employees):");
            var jobCounts2 = LinqTasks.Task15();
            foreach (dynamic job in jobCounts2)
            {
                Console.WriteLine($"Job: {job.Praca}, Number of Employees: {job.LiczbaPracownikow}");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine();

            // Cartesian Product of Emps and Depts
            Console.WriteLine("TASK 16: Cartesian Product of Emps and Depts:");
            Console.WriteLine("Empno\tEname\tJob\tHireDate\tSalary\tMgr\tDeptno(Emp)\tDeptno(Dept)\tDname\tLoc");
            var jobCombos = LinqTasks.Task16();
            foreach (dynamic combo in jobCombos)
            {
                Console.WriteLine($"{combo.Empno}\t{combo.Ename}\t{combo.Job}\t{combo.HireDate}\t{combo.Salary}\t{combo.Mgr}\t{combo.DeptnoEmp}\t{combo.DeptnoDept}\t{combo.Dname}\t{combo.Loc}");
            }
            Console.WriteLine();
        }
    }
}
