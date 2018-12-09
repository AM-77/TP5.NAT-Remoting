using System;
namespace StackFactory
{
    public interface IStackFactory
    {
        Stack CreateStack(int size);
    }
}
