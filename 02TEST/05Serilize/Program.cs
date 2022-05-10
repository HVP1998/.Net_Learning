using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _05Serialize
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
            string target = @"C:\Users\ASUS\Desktop\新建文件夹\person.txt";
            Person p = new Person("James", GENDER.男, 25);
            CreateClassFile(target, p);
            Console.ReadKey();
        }
        public static void CreateClassFile(string target,object o)
        {
            using(FileStream fswrite=new FileStream(target,FileMode.Create,FileAccess.Write))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fswrite, o);
            }
            Console.WriteLine("Serialize Complete");
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
        public string Name;
        public GENDER Gender;
        public int Age;
    }
}
