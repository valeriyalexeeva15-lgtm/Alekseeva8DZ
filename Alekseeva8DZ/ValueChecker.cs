using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alekseeva8DZ
{
    internal class ValueChecker
    {
        public void CheckType(object input)
        {
            if (input is int)
            {
                Console.WriteLine("Значимый тип (int)");
            }
            else if (input is string)
            {
                Console.WriteLine("Ссылочный тип (string)");
            }
        }
    }
}