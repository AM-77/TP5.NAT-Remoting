using System;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using StackFactory;


namespace TheClient
{
    class TheClient
    {
        public static void Main(string[] args)
        {
            int id;
            String name, f_name, res;
            bool pushed;
            try
            {
                TcpChannel chl = new TcpChannel();
                ChannelServices.RegisterChannel(chl, false);

                IStackFactory stackFactory = (IStackFactory)Activator.GetObject(typeof(StackFactory.StackFactory), "tcp://localhost:1234/IStackFactory");

                Console.WriteLine("---------- .NET Remoting TP ----------");

                Console.Write("Enter the stack's size : ");
                int size = (int)Console.Read();
                Console.WriteLine();

                IStack stack = (IStack)stackFactory.CreateStack(size);

                Console.WriteLine("The current size is : {0}", stack.Size());
                Console.WriteLine("The max size is : {0}", stack.MaxSize());


                Console.Write("Press Enter To Continue ...");
                Console.Read();

                while (true)
                {

                    int choise = Choose();

                    if (choise == 1)
                    {
                        while (true)
                        {

                            Console.Write("\n[*] Add a new student to the stack: \n");

                            Console.Write("\n[*] Enter id: ");
                            id = (int)Console.Read();

                            Console.Write("\n[*] Enter name: ");
                            name = Console.ReadLine();

                            Console.Write("\n[*] Enter familly name: ");
                            f_name = Console.ReadLine();
                            Student s = new StackFactory.Student(id, name, f_name);
                            pushed = stack.Push(s);

                            if (pushed)
                            {
                                Console.WriteLine("\n[+] Student added succesfuly.");
                            }
                            else
                            {
                                Console.WriteLine("\n[!] There was an error in adding the student to the stack.");
                                Console.Read();
                                System.Environment.Exit(1);
                            }

                            Console.Write("\n[*] Add new Y/N: ");
                            res = Console.ReadLine();

                            if (res.Equals("N"))
                            {
                                break;
                            }
                            else
                            {
                                if(stack.Size() == stack.MaxSize()-1)
                                {
                                    Console.Write("\n[!] Can not add new students, the stack is filled.\n");
                                    break;
                                }
                            }

                        }
                    }
                    else
                    {
                        if (choise == 2)
                        {
                            StackFactory.Student student = stack.Pop();
                            Console.WriteLine("Student : \n\tID: {0}\n\tName: {1}\n\tFamily name: {2}\n", student.id, student.name, student.f_name);
                        }
                        else
                        {
                            if (choise == 3)
                            {
                                Console.WriteLine("The size of the stack is: {0}", stack.Size());
                            }
                            else
                            {
                                if (choise == 4)
                                {
                                    Console.WriteLine("The max size of the stack is: {0}", stack.MaxSize());
                                }
                                else
                                {
                                    System.Environment.Exit(0);
                                }
                            }
                        }
                    }

                    Console.Write("Press Enter To Continue ...");
                    Console.Read();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("There was an error in the ClientSender : {0}", e.Message);
                Console.Read();
            }

        }


        public static int Choose()
        {
            Console.Clear();
            Console.WriteLine("---------- .NET Remoting TP ----------");
            Console.WriteLine("[1] Push an item to the stack.");
            Console.WriteLine("[2] Pop an item from the stack.");
            Console.WriteLine("[3] Display the size of the stack.");
            Console.WriteLine("[4] Display the maxsize of the stack.");
            Console.WriteLine("[5] Exit.");

            Console.Write("Enter your choise: ");
            return (int)Console.Read();
        }
    }
}
