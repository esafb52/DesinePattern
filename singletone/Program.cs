﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace singletone
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                Single getSingle = Single.GetSingle;
            }
            Console.ReadLine();

        }
    }
}
