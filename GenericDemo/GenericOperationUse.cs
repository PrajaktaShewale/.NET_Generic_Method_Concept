using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class GenericOperationUse
    {
        public void ToPrintArray<T>(T[] intArr)
        {
            foreach(var data in intArr)
            {
                Console.WriteLine(data);
            }
            Console.WriteLine("Arrays Printed by Generic Operation");
        }
    }
}
