using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace WindowsRegistry_07
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(@"Environment\");
            var val = registryKey.GetValueNames();
            foreach(var v in val)
            {
                Console.WriteLine(v);
            }

            var val2 = registryKey.GetValue("TEMP");
            Console.WriteLine(val2.ToString());

            Console.ReadKey();
        }
    }
}
