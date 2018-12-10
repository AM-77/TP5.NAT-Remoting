using System;
using System.Collections;

namespace StackFactory 
{
    public class Stack : MarshalByRefObject, IStack
    {
        private readonly int size = 0;
        private ArrayList students = new ArrayList();

        public Stack(int size)
        {
            this.size = size;
        }


        bool IStack.Push(Student s)
        {
            if (students.Count == size)
            {
                return false;
            }

            students.Insert(0, s);

            return true;
        }

        Student IStack.Pop()
        {
            if (students.Count == 0)
            {
                return null;
            }
            else
            {
                Student s = (Student)this.students[this.students.Count - 1];
                students.Remove(s);
                return s;
            }
        }

        void IStack.Empty()
        {
            this.students.Clear();
        }

        int IStack.Size()
        {
            return this.students.Count;
        }

        int IStack.MaxSize()
        {
            return this.size;
        }
    }
}
