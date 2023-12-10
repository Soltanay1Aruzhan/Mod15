using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Mod15Dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TASK 1
            Type consoleType = typeof(Console);

            MethodInfo[] methods = consoleType.GetMethods();

            foreach (var method in methods) 
            {
                Console.WriteLine(method.Name);
            }

            //TASK 2
            Class С = new Class();

            С.Prop1 = 42;
            С.Prop2 = "Salam";

            Type СType = С.GetType();

            foreach (var property in СType.GetProperties()) 
            {
                object value = property.GetValue(С);
                Console.WriteLine($"{property.Name}: {value}");
            }

            //TASK 3
            string S = "Hello world!";

            Type SType = typeof(string);

            MethodInfo substringMethod = SType.GetMethod("Substring", new Type[] { typeof(int), typeof(int) });


            object[] parameters = { 6, 6 };
            object result = substringMethod.Invoke(S, parameters); 

            Console.WriteLine(result);

            //TASK 4
            Type LType = typeof(List<>);

            ConstructorInfo[] constructors = LType.GetConstructors();

            
            foreach (var constructor in constructors) 
            {
                Console.WriteLine(constructor);
            }
        }

        class Class
        {
            public int Prop1 { get; set; }
            public string Prop2 { get; set; }
        }
    }
}
