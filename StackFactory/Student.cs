using System;
namespace StackFactory
{
    [Serializable]
    public class Student
    {

        private int id { set; get; }
        private String name { set; get; }
        private String f_name { set; get; }

        public Student(int id, String name, String f_name)
        {
            this.id = id;
            this.name = name;
            this.f_name = f_name;
        }
    }
}
