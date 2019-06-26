using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    class Bubble
    {
        static int[] BubbleSort(int[] a)
        {
            int max;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                { 
                    if (a[i] > a[j])
                    {
                        max = a[i];
                        a[i] = a[j];
                        a[j] = max;
  
                    }
                }
            }
        return a;
        }
        static void Main(string[] args)
        {
            int[] mas = {54, 65, 45, 165, 0, 165, 89, 111};
            BubbleSort(mas);

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine($"Nuber {i + 1} is - {mas[i]}");
            }
            Console.ReadLine();
        }
    }
}
