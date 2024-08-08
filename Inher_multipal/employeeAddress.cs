using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inher_multipal
{
    public class employeeAddress
    {
        public string address1 { get; set; }
        public string address2 { get; set; }


        public virtual void input()
        {
            address1 = "society";
            address2 = "100ft road";
        }
        public virtual void output()
        {
            Console.WriteLine(address1);
            Console.WriteLine(address2);
        }
    }
}
