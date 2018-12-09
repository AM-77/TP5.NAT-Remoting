using System;
namespace StackFactory
{
    public interface IStack
    {
        bool Push(Student s);
        Student Pop();
        void Empty();
        int Size();
        int MaxSize();
    }
}
