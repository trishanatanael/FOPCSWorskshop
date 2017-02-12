﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOPCSWorskshop
{
    class WorkshopE6

    {
        public static void Main()
        {
            int sum = 0, j = 1;
            
            Console.WriteLine("Perfect number from 1-1000:");
            bool isPerfect = true;
            List<int> factors = new List<int>();

            for (j = 1; j < 1000; j++)
            {
                isPerfect = false;
                for (int i = 1; i < j; i++)
                { 
                    if (j % i == 0)
                    {
                        factors.Add(i);
                        
                    }
                }
                sum = factors.Sum();

                if (sum == j)
                {
                    isPerfect = true;                
                }
               
                if (isPerfect) Console.WriteLine(j);
               
                factors.Clear();
            }
            return;
        }
    }
}
