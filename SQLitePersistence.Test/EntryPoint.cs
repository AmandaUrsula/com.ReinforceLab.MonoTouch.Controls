﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace net.ReinforceLab.iPhone.Utils.SQLitePersistence.Test
{
    class EntryPoint
    {
        [STAThread]
        public static void Main(String[] args)
        {
            var test = new PrimitiveTypeTest();
            //test.UpdateTest();
            test.ValueAccessTest();
            
            Console.ReadKey();

        }
    }
}
