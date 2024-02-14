using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    public class Cat:Animal
    {
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Cat(string name)
            :base(name)
        {
            this.Name = name;
        }
        public override void Say()
        {
            Console.WriteLine("Кот говорит мяу");
        }
    }
}
