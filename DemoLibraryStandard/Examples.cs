﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public static class Examples
    {

        public static string ExampleLoadTextFile(string file)
        {
            if(file.Length<5)
            {
                throw new  System.IO.FileNotFoundException();
            }

            return "The File Correctly loaded";

        }

    }
}
