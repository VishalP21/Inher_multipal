using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inher_multipal
{
    public class employeeManage
    {
        public string employeenumber {  get; set; }
        public string employeenumber2 { get; set; }

        public virtual void input()
        {
            employeenumber = "52586";
            employeenumber2 = "86548656";
        }
        public virtual void outpt()
        {
            Console.WriteLine(employeenumber);
            Console.WriteLine(employeenumber2);
        }
    }
}
