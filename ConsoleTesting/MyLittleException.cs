using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class MyLittleException : Exception
    {
        public string Sing { get; set; } = "You fucked up badly, you fucked up badly, la la la laaaa...";
    }
}
