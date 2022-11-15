using System;
namespace GenericDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5, 6, };
            double[] doubleArr = { 1.5, 2.5, 3.5, 4.5, 5.5 };
            char[] charArr = { 'a', 'b', 'c', 'd', 'e' };
            GenericOperation generic = new GenericOperation();
            generic.ToPrintArray(intArr);
            generic.ToPrintArray(doubleArr);
            generic.ToPrintArray(charArr);
        }
    }
}