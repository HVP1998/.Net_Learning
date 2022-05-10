using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.索引器
{
    public enum GENDER { 男, 女, N }
    public class Person
    {
        public Person(string name, GENDER gender, int age, double chinese, double math, double english)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this["chinese"] = chinese;
            this["math"] = math;
            this["english"] = english;
        }

        private string _name;
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        private GENDER _gender;
        public GENDER Gender
        {
            get
            {
                return this._gender;
            }
            set
            {
                if (value is GENDER)
                    this._gender = value;
                else
                    this._gender = GENDER.N;
            }
        }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value is int)
                    this._age = value;
                else
                    this._age = 0;
            }
        }

        public double Chinese { get; set; }
        public double Math { get; set; }
        public double English { get; set; }

        public double this[string subject]
        {
            get
            {
                switch (subject)
                {
                    case "chinese": return Chinese;
                    case "math": return Math;
                    case "englisg": return English;
                    default: return 0.0;
                }
            }
            set
            {
                switch (subject)
                {
                    case "chinese": Chinese = value;
                        break;
                    case "math": Math = value;
                        break;
                    case "englisg": English = value;
                        break;
                }
            }
        }
    }
}
