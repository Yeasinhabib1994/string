using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @string
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullname = "yeasin habib ";
            Console.WriteLine("trim: '{0}'", fullname.Trim());
            Console.WriteLine("toupper: '{0}'", fullname.Trim().ToUpper());

            var index = fullname.IndexOf(' ');
            var firstname = fullname.Substring(0, index);
            var lastname = fullname.Substring(index + 1);
            Console.WriteLine("first name: " + firstname);
            Console.WriteLine("last name: " + lastname);

            var names = fullname.Split(' ');
            Console.WriteLine("first name: " + names[0]);
            Console.WriteLine("last name: " + names[1]);

            Console.WriteLine(fullname.Replace("yeasin", "S.M. yeasin"));

            var name = new string[4] { "S.M.", "yeasin", "habib", "rony" };
            Console.WriteLine("fullname: " + string.Join(" ", name));

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("invalid");

            float price = 29.95f;
            Console.WriteLine(price.ToString());
        }
    }
}
