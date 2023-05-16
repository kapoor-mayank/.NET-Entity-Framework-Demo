using EFDemo_Emp.Models;

namespace EFDemo_Emp
{
    internal class EmpMain
    {
        static void Main(string[] args)
        {
            EmpLayer layer = new EmpLayer();
            Employee employee = new Employee { Name = "Preetam Rana", Salary = 125000, DepartmentId = 2 };
            layer.AddEmployee(employee);
            List<Employee> list = layer.GetAll();
            list.ForEach(item => { Console.WriteLine($"EmpID: {item.EmpId}, Name: {item.Name}, Salary: {item.Salary}, DeptID: {item.DepartmentId}"); });
            layer.DeleteEmployee(4);
            Console.WriteLine("After Deleting");
            list = layer.GetAll();
            list.ForEach(item => { Console.WriteLine($"EmpID: {item.EmpId}, Name: {item.Name}, Salary: {item.Salary}, DeptID: {item.DepartmentId}"); });
            employee = new Employee { EmpId = 1, Name = "Mayankggf Kapoor", Salary = 125000, DepartmentId = 2 };
            layer.UpdateEmployee(employee, 1);
            list = layer.GetAll();
            list.ForEach(item => { Console.WriteLine($"EmpID: {item.EmpId}, Name: {item.Name}, Salary: {item.Salary}, DeptID: {item.DepartmentId}"); });
        }
    }
}