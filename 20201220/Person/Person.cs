using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        private string name;
        private string sex;
        private string countrie;
        private int height;
        private int weight;
        private string professional;
        public string Name { get; set; }
        public string Countrie
        {
            get
            {
                if (this.countrie == "china")
                {
                    return "老乡";
                }
                else
                {
                    return "外国人";
                }
            }
            set { this.countrie = value; }
        }
        public string Sex { get; set; }
        public int Height { get; set; }
        public int Weight
        {
            get
            {
                if (this.weight > 200)
                {
                    return 200;
                }
                else if (this.weight < 80)
                {
                    return 100;
                }
                else
                {
                    return this.weight;
                };
            }
            set { this.weight = value; }
        }
        public string Professional { get; set; }
        public void Sayhello()
        {
            Console.WriteLine("姓名：{0}，性别：{1}，国家：{2}", Name, Sex, Countrie);
        }
        public void Introduce()
        {
            Console.WriteLine("姓名：{0}，性别：{1}，国家：{2},身高：{3}，体重：{4}", Name, Sex, Countrie, Height, Weight);
        }
        public void about()
        {
            Console.WriteLine("姓名：{0}，性别：{1}，国家：{2},专业{3}", Name, Sex, Countrie, Professional);
        }
        public Person() { }
        public Person(string name, string sex, string countrie, int height, int weight, string professional)
        {
            this.Name = name;
            this.Sex = sex;
            this.Countrie = countrie;
            this.Height = height;
            this.Weight = weight;
            this.Professional = professional;
        }
        //public Person(string Name):this(name,"","",0,0) {
            
        //}
        }
    
}