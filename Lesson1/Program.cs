﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //calling @method HelloWorldToConsole
            HelloWorldToConsole();
        }

        /*
         * @description This is my Hello World method
         * @method HelloWorldToConsole
         * @returns {string} HelloWorldString
         */
        public static string HelloWorldToConsole()
        {
            string HelloWorldString = "Hello, World!";
            Console.WriteLine(HelloWorldString);
            return HelloWorldString;
        }
    }
}
