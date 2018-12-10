using System;
namespace StackFactory
{
    [Serializable]
    public class Student
    {

        public int id { set; get; }
        public String name { set; get; }
        public String f_name { set; get; }

        public Student(int id, String name, String f_name)
        {
            this.id = id;
            this.name = name;
            this.f_name = f_name;
        }
    }
}
