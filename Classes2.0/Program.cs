﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tafel> tafels = new List<Tafel>();
            Random rndGen = new Random();

            for (var i = 0; i < 10; i++)
            {
                var w = rndGen.Next(50, 200);
                var h = rndGen.Next(50, 200);
                tafels.Add(new Tafel(w, h));
            }
            foreach (var table in tafels)
            {
                table.ShowData();
            }
        }

    }
}
