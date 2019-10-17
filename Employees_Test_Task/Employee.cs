using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_Test_Task
{
    class Employee
    {
        public enum Sex { Мужской, Женский, Другое }
        public int ID { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string MName { get; set; }
        public DateTime Birthday { get; set; }
        public Sex Gender { get; set; }
        public int? DepartmentID { get; set; }
    }
}
