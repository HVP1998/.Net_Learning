using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _05.Class_Serialize
{
    public enum GENDER
    {
        男,
        女,
    }
    class Program
    {
        static void Main(string[] args)
        {
            string target = @"C:\Users\ASUS\Desktop\1.txt";
            Person p = new Person("尤格萨隆", GENDER.男, 250);
            CreateFile(p, target);
            Console.WriteLine("Creating Completed");
            Console.ReadKey();
        }

        public static void CreateFile(object o,string target)
        {
            using (FileStream fswrite = new FileStream(target,FileMode.Create,FileAccess.Write))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fswrite, o);
            }
        }
    }
    [Serializable]
    public class Person
    {
        public Person(string name,GENDER gender,int age)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
        }
        public string Name { get; set; }
        public GENDER Gender { get; set; }
        public int Age { get; set; }
    }
}
