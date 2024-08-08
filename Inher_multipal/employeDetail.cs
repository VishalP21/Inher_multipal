using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inher_multipal
{
    public class employeDetail : employeeAddress , employeeManage
    {
        public string employeefirstName {  get; set; }
        public string employelastname { get; set; }

        public override void input()
        {
            employeefirstName = "vishal";
            employelastname = "pj";
            address1 = "iuygfhb";
            address2 = "ygyhuijk";
            employeenumber = "896565";
            employeenumber2 = "58945596";
        }
        public override void output()
        {
            Console.WriteLine(employeefirstName);
            Console.WriteLine(employelastname);
            Console.WriteLine(address1);
            Console.WriteLine(address2);
        }
    }
}
