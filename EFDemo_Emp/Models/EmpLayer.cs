using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo_Emp.Models
{
    internal class EmpLayer
    {
        public static readonly EntitPracDB db = new EntitPracDB();
        public List<Employee> GetAll()
        {
            
            return db.Employee.ToList<Employee>();
        }
        public void AddEmployee(Employee employee)
        {
            db.Add<Employee>(employee);
            db.SaveChanges();
        }
        public void DeleteEmployee(int id)
        {
            Employee employee = db.Find<Employee>(id);
            if (employee != null)
            {
                db.Remove<Employee>(employee);
            }
            db.SaveChanges();
        }
        public void UpdateEmployee(Employee employee, int id)
        {
            EntitPracDB db=new EntitPracDB();
            if (employee != null && employee.EmpId == id)
            {
                db.Update<Employee>(employee);
                //db.Add<Employee>(employee);
            }
            db.SaveChanges();
        }
    }
}
