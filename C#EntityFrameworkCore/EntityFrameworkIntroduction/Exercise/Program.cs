using System.Linq;
using SoftUni.Data;
using SoftUni.Models;
using System;

using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            using (var db = new SoftUniContext())
            {


                //Console.WriteLine(GetEmployeesFullInformation(db));
                //Console.WriteLine(GetEmployeesWithSalaryOver50000(db));
                //Console.WriteLine(AddNewAddressToEmployee(db));

                //Console.WriteLine(GetEmployeesInPeriod(db));
                //Console.WriteLine(GetAddressesByTown(db));
                //Console.WriteLine(GetEmployee147(db));
               // Console.WriteLine(GetDepartmentsWithMoreThan5Employees(db));
              // Console.WriteLine(GetLatestProjects(db));
               // Console.WriteLine(IncreaseSalaries(db));
               // Console.WriteLine(GetEmployeesByFirstNameStartingWithSa(db));
               // Console.WriteLine(DeleteProjectById(db));
                Console.WriteLine(RemoveTown(db));







            }

        }
        //03.Employees Full Information
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            var sb = new StringBuilder();
            var towns = context.Employees
                   .Select(x => new Employee
                   {
                       FirstName = x.FirstName,
                       MiddleName = x.MiddleName,
                       LastName = x.LastName,
                       JobTitle = x.JobTitle,
                       Salary = x.Salary,
                       EmployeeId = x.EmployeeId

                   }).OrderBy(x => x.EmployeeId).ToList();

            foreach (var item in towns)
            {
                sb.AppendLine($"{item.FirstName} {item.LastName} {item.MiddleName} {item.JobTitle} {item.Salary:F2}");
            }
            return sb.ToString().TrimEnd();
        }
        //04.Employees with Salary Over 50 000
        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        //05.Employees from Research and Development
        {
            var sb = new StringBuilder();

            var result = context.Employees
                .Where(x => x.Salary > 50000)
                .Select(t => new Employee { FirstName = t.FirstName, Salary = t.Salary })
                .OrderBy(x => x.FirstName)
                .ToList();



            foreach (var item in result)
            {
                sb.AppendLine($"{item.FirstName} - {item.Salary:F2}");
            }

            return sb.ToString().TrimEnd();
        }
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            var sb = new StringBuilder();
            var result = context.Employees
                .Where(x => x.Department.Name == "Research and Development")
                .OrderBy(x => x.Salary).ThenByDescending(x => x.FirstName)
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName,
                    DepartmentName = x.Department.Name,
                    x.Salary
                })
                .ToList();






            foreach (var item in result)
            {
                sb.AppendLine($"{item.FirstName} {item.LastName} from {item.DepartmentName} - ${item.Salary:f2}");
            }
            return sb.ToString().TrimEnd();
        }
        //06.Adding a New Address and Updating Employee
        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            var sb = new StringBuilder();
            var addres = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            context.Employees.First(x => x.LastName == "Nakov").Address = addres;
            context.SaveChanges();

            context.Employees
                  .OrderByDescending(x => x.Address.AddressId)
                  .Take(10)
                  .Select(x => x.Address.AddressText)
                  .ToList().ForEach(s => sb.AppendLine(s));




            //foreach (var item in result)
            //{
            //    sb.AppendLine(item);
            //}
            return sb.ToString().TrimEnd();

        }
        //07.Employees and Projects
        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            var sb = new StringBuilder();
            var result = context.Employees
                .Where(x => x.EmployeesProjects.Any(c => c.Project.StartDate.Year >= 2001 && c.Project.StartDate.Year <= 2003))
                .Select(x => new
                {
                    x.FirstName,
                    x.LastName,
                    ManagerName = x.Manager.FirstName + " " + x.Manager.LastName,
                    project = x.EmployeesProjects.Select(c => c.Project)

                }).Take(10).ToList();

            foreach (var employee in result)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - Manager: {employee.ManagerName}");
                foreach (var project in employee.project)
                {
                    sb.AppendLine($"--{project.Name} - {project.StartDate} - {(project.EndDate == null ? "not finished" : project.EndDate.ToString())}");
                }
            }
            return sb.ToString().TrimEnd();
                   

        }
        //08.Addresses by Town
        public static string GetAddressesByTown(SoftUniContext context)
        {
            var sb = new StringBuilder();


            var result = context.Employees
                .GroupBy(a => new
                {
                    a.AddressId,
                    a.Address.AddressText,
                    a.Address.Town.Name



                }, (k, v) => new
                {
                    AddressText = k.AddressText,
                    TownName = k.Name,
                    EmployeCount = v.Count()

                }).OrderByDescending(x => x.EmployeCount).ThenBy(x => x.TownName).ThenBy(x => x.AddressText).Take(10);
            foreach (var item in result)
            {
                sb.AppendLine($"{item.AddressText}, {item.TownName} - {item.EmployeCount} employees");
            }
            return sb.ToString().TrimEnd();
        }
        //09.Employee 147
        public static string GetEmployee147(SoftUniContext context)
        {
            var sb = new StringBuilder();


            //var employe = context.Employees.FirstOrDefault(x => x.EmployeeId == 147);
            var projects = context.Employees.Where(x=>x.EmployeeId == 147).Select(x => new  
            {
               Fullname =  x.FirstName + " " + x.LastName,
                x.JobTitle,
                Projects = x.EmployeesProjects.Select(c => c.Project)
            }).ToList();

            foreach (var employee in projects)
            {
                sb.AppendLine($"{employee.Fullname} - {employee.JobTitle}");
                foreach (var item in employee.Projects.OrderBy(x=>x.Name))
                {
                    sb.AppendLine(item.Name);
                }
            }

            return sb.ToString().TrimEnd();

        }
        //10.Departments with More Than 5 Employees
        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            var sb = new StringBuilder();

            //var result = context.Employees.GroupBy(x => new
            //{
            //    x.EmployeeId,
            //    x.FirstName,
            //    x.LastName,
            //    jobTitle =  x.JobTitle,
            //    x.Manager,

            //}, (key, group) => new
            //{
            //    FullName = key.FirstName + " " + key.LastName,
            //    Count = group.Count(),
            //    EmpId = key.EmployeeId,

            //    manager= key.Manager.FirstName + " " + key.Manager.FirstName
            //}).Where(x => x.EmpId > 5).ToList();


            //foreach (var item in result)
            //{
            //    sb.AppendLine(item.FullName + " " + item.j)
            //}

            var result = context.Departments.Select(x => new
            {
                DepartmentName = x.Name,
                Employees = x.Employees,
                ManagerName = x.Manager.FirstName + " " + x.Manager.LastName

            }).Where(x => x.Employees.Count() > 5).OrderBy(x => x.DepartmentName);

            foreach (var item in result)
            {
                sb.AppendLine($"{item.DepartmentName} - {item.ManagerName}");
                foreach (var employees in item.Employees.OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName))
                {
                    sb.AppendLine($"{employees.FirstName} {employees.LastName} - {employees.JobTitle}");

                }
            }
            return sb.ToString().TrimEnd();
        }
        //11.Find Latest 10 Projects
        public static string GetLatestProjects(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var result = context.Projects.OrderByDescending(x=>x.StartDate).Take(10).Select(x => new
            {
                Name = x.Name,
                Desc = x.Description,
                StartDate = x.StartDate
            }).OrderBy(x => x.Name).ToList();
            //result.Reverse();

            foreach (var project in result)
            {
                sb.AppendLine($"{project.Name}");
                sb.AppendLine($"{project.Desc}");
                sb.AppendLine($"{project.StartDate}");


            }
            return sb.ToString().TrimEnd();
        }
        //12.Increase Salaries
        public static string IncreaseSalaries(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var result = context.Employees.Where(x => x.Department.Name == "Engineering" || x.Department.Name == "Tool Design"
            || x.Department.Name == "Marketing" || x.Department.Name == "Information Services").Select(x => new
            {
                x.FirstName,
                x.LastName,
                x.Department.Name,
                Salaryto = x.Salary + x.Salary * 0.12m
            }).OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName);

            foreach (var project in result)
            {
                sb.AppendLine($"{project.FirstName} {project.LastName} (${project.Salaryto:F2})");
                
                


            }
            return sb.ToString().TrimEnd();
        }
        //13.Find Employees by First Name Starting With "Sa"
        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var result = context.Employees.Where(x=>x.FirstName.StartsWith("Sa")).Select(x => new
            {
                x.FirstName,
                x.LastName,
                x.JobTitle,
                x.Salary
            }).OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var project in result)
            {
                sb.AppendLine($"{project.FirstName} {project.LastName} - {project.JobTitle} - (${project.Salary:F2})");




            }
            return sb.ToString().TrimEnd();
        }
        //14.Delete Project by Id
        public static string DeleteProjectById(SoftUniContext context)
        {
            var sb = new StringBuilder();

            var projects = context.Projects.Find(2);
            var delete = context.EmployeesProjects.Where(x => x.ProjectId == 2).ToList();
            foreach (var item in delete)
            {
                context.EmployeesProjects.Remove(item);
            }
            context.Projects.Remove(projects);
            var result = context.Projects.Take(10).Select(x => new
            {
                x.Name
            });
            context.SaveChanges();
            foreach (var project in result)
            {
                sb.AppendLine($"{project.Name}");




            }
            return sb.ToString().TrimEnd();
        }
        //15.Remove Town
        public static string RemoveTown(SoftUniContext context)
        {
            var sb = new StringBuilder();
            var addressesFromTheTargetTown = context
                .Addresses
                .Where(a => a.Town.Name.Equals("Seattle"))
                .ToList();

            foreach (var employee in context.Employees)
            {
                if (addressesFromTheTargetTown.Contains(employee.Address))
                {
                    employee.Address = null;
                }
            }

            context.Addresses.RemoveRange(addressesFromTheTargetTown);

            var townToBeDeleted = context.Towns.SingleOrDefault(t => t.Name.Equals("Seattle"));
            context.Towns.Remove(townToBeDeleted);

            context.SaveChanges();

            var removedAddressesCount = addressesFromTheTargetTown.Count();
            
            

            sb.Append(($"{removedAddressesCount} addresses in Seattle were deleted"));
            return sb.ToString().TrimEnd();
        }




    }
}

