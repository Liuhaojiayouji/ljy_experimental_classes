using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person("asd", "男", "china1", 123, 322, "计算机");
            //Person person1 = new Person("asasdfd", "女", "china", 163, 22, "计算机1");
            //Person person2 = new Person("asasdd", "男", "china", 123, 322, "计算机2");
            //person.Introduce();
            //person.about();
            //person.Sayhello();


            //person1.Introduce();
            //person1.about();
            //person1.Sayhello();


            //person2.Introduce();
            //person2.about();
            //person2.Sayhello();

            //Chinese chinese = new Chinese("姓名", "xb", "guojia");
            //chinese.Sayhello();
            //chinese.Spec();
            //Japanese japanese = new Japanese("姓名", "xb", "japanese");
            //japanese.Sayhello();
            //japanese.Spec();
            //American american = new American("姓名", "xb", "usa");
            //american.Sayhello();
            //american.Spec();

            //Sout_koreans sout_Koreans = new Sout_koreans("姓名", "xb", "sou");
            //sout_Koreans.Sayhello();
            //sout_Koreans.Spec();


            //Italian italian = new Italian("姓名", "xb", "italian"); 
            //italian.Sayhello();
            //italian.Spec();
            Person person = new Italian("asd", "nan", "asd");
            person.Spec();
            Console.ReadKey();
        }
    }
}
