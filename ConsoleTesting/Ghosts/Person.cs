using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{

    enum Sex { Male, Female, Transgender };

    class Person
    {

        public Sex Sex { get; set; }
        public string FullName => $"{Name} {AfterName}";

        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (value != "Peter")
                {
                    this.name = value;
                }
                else
                {
                    throw new Exception("Somebody tried to call Peter, god damn motherfuckers");
                }
            }
        }

        private string afterName;
        public string AfterName
        {
            get { return afterName; }
            set { afterName = value; }
        }


        private DateTime birthday;
        public DateTime Birthday
        {
            get { return birthday; }
            set
            {
                if (value <= DateTime.Now)
                {
                    birthday = value;
                }
                else
                {
                    throw new Exception("Man kann nicht in der Zukunft gebohrt werden, du Pimmel");
                }
            }
        }

    }
}
