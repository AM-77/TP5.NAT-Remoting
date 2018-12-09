using System;
namespace StackFactory
{
    public class StackFactory : MarshalByRefObject, IStackFactory
    {
        public StackFactory()
        {
        }

        public Stack CreateStack(int size)
        {
            return new Stack(size);
        }
    }
}
