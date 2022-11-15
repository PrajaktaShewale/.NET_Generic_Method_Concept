using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    internal class GenericOperation
    {
        public void ToPrintArray(int[] intArr)
        {
            foreach(var data in intArr)
            {
                Console.WriteLine(data);
            }
        }
        public void ToPrintArray(double[] doubleArr)
        {
            foreach (var data in doubleArr)
            {
                Console.WriteLine(data);
            }
        }
        public void ToPrintArray(char[] intArr)
        {
            foreach (var data in intArr)
            {
                Console.WriteLine(data);
            }
        }

    }
}
