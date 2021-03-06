﻿using Shared;
using System;

namespace Aufgabe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var fahrzeuge = new Fahrzeug[]
            {
                new Fahrzeug
                {
                    Kennzeichen = "KA TE 4711"
                },
                new PKW
                {
                    Kennzeichen = "KA SC 1894"
                },
                new LKW
                {
                    Kennzeichen = "S OS 2342"
                }
            };


            foreach (var fahrzeug in fahrzeuge)
            {
                Console.WriteLine(fahrzeug.Drive());
            }

            Util.WaitForInput();
        }
    }
}
