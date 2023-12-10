using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ClassLib;

namespace Mod15prac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type ClassType = typeof(MyClass);
            object obj = Activator.CreateInstance(ClassType); 

            Console.WriteLine($"Значение PublicProp до изменений: {(ClassType.GetProperty("PublicProp").GetValue(obj))}"); 
            
            ClassType.GetProperty("PublicProp").SetValue(obj, 10); 

            Console.WriteLine($"Значение PublicProp после изменений: {(ClassType.GetProperty("PublicProp").GetValue(obj))}"); 

            ClassType.GetMethod("PublicMethod").Invoke(obj, null); 

            var privateMethod = ClassType.GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
            string result = (string)privateMethod.Invoke(obj, null); 

            var privateMethod2 = ClassType.GetMethod("PrivateMethod2", BindingFlags.NonPublic | BindingFlags.Instance);
            privateMethod2.Invoke(obj, null); 
        }
    }
}
