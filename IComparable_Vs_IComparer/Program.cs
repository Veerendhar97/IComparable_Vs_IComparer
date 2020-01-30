using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_Vs_IComparer
{
    #region IComparable
    class Employee :IComparable<Employee>
    {
        public int eno { get; set; }
        public string ename { get; set; }
        public  double sal { get; set; }

        public int CompareTo(Employee oth)
        {
            if (this.eno < oth.eno)
                return -1;
            if (this.eno > oth.eno)
                return 1;
            else
                return 0;

        }
    }
    #endregion IComparable
    #region IComparer
    class SortEmployee : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            if (x.sal < y.sal)
                return -1;
            if (x.sal > y.sal)
                return 1;
            else
                return 0;
        }
    }
    #endregion IComparer
    class Program
    {
        public int String_Cmp(Employee e1, Employee e2)
        {
            return e1.ename.CompareTo(e2.ename);
        }
        static void Main(string[] args)
        {

            #region Initialization
            Program p1 = new Program();
            Employee e1 = new Employee { eno = 5, ename="Arun", sal= 10000 };
            Employee e2 = new Employee { eno = 10, ename="Pranay", sal = 25000 };
            Employee e3 = new Employee { eno = 1, ename="Zubair", sal = 30000 };
            Employee e4 = new Employee { eno = 7, ename="Varun", sal = 19000 };
            Employee e5 = new Employee { eno = 14, ename="Arun", sal = 10000 };
            List<Employee> e = new List <Employee>() {e1,e2,e3,e4,e5};
            SortEmployee se = new SortEmployee();
            #endregion Initialization
           // e.Sort();
            e.Sort(se);
           // e.Sort(p1.String_Cmp);
            #region foreach
            foreach (Employee p2 in e)
            {
                Console.WriteLine(p2.eno+"   "+p2.ename+"   "+p2.sal);
            }
            #endregion foreach
            Console.ReadKey();
        }
    }
}
