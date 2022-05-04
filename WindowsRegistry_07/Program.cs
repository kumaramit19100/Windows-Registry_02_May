using System;
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
                Console.WriteLine("Value Name : "+v);
            }

            var val2 = registryKey.GetValue("TEMP");
            Console.WriteLine("Value is : "+val2.ToString());
            Console.WriteLine("------------------------------------------------------------------------------------------");
            
            






            
            Console.SetWindowSize(90, 33);  ///Set output windows size 
            //Console.Beep(1000, 10000);  ///a beep sound set on console output
            Console.ReadKey();
        }
    }
}
