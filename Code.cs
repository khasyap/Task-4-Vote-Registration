using System.ComponentModel.Design;
using System.Net.Mime;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;

namespace Task4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a,age,b;
            string name, email, phone, address, vid, fname, mname; 
            
            
            Console.WriteLine("                 VOTER REGISTRATION    ");
            Console.WriteLine();
            Console.WriteLine("Welcome to Election Commission of india");
            Console.WriteLine("Are you a new user or not ?");
            Console.WriteLine("1.YES\n2.NO");
            a=Convert.ToInt32(Console.ReadLine());
            if(a==1)
            {
                Console.Write("Age                     : ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age>=18)
                {
                    Console.WriteLine("Welcome to Registration page");
                    Console.Write("Enter your name       : ");
                    name = Console.ReadLine();
                    Console.Write("Enter your Father name: ");
                    fname = Console.ReadLine();
                    Console.Write("Enter your Mother name: ");
                    mname = Console.ReadLine();
                    Console.Write("Phone No.             : ");
                    phone = Console.ReadLine();
                    Console.Write("Email                 : ");
                    email = Console.ReadLine();
                    Console.Write("Address               : ");
                    address = Console.ReadLine();
                    Console.Write("VID                   : ");
                    vid = Console.ReadLine();
                    Console.WriteLine("Thank you for Registration");
                    int k;
                    string l;
                    Console.WriteLine("Are you want to login?");
                    Console.WriteLine("1.YES\n2.NO");
                    k = Convert.ToInt32(Console.ReadLine());
                    if (k == 1)
                    {
                        Console.WriteLine("Login Page");
                        Console.Write("Enter your voter id: ");
                        l = Console.ReadLine();
                        if (l==vid)
                        {
                            Console.WriteLine("Name       : "+name);
                            Console.WriteLine("Father Name: "+fname);
                            Console.WriteLine("Mother Name: "+mname);
                            Console.WriteLine("Phone No.  : "+phone);
                            Console.WriteLine("Email      : "+email);
                            Console.WriteLine("Address    : "+address);
                        }
                        else
                        {
                            Console.WriteLine("Enter a vaild number ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter a vaild details");
                    }
                }

                else
                {
                        Console.WriteLine("Your are not elgible to registration");
                }
            }
            else if(a==2)
            {
                Console.Write("Enter your voter id        :");
                Console.ReadLine();
                Console.WriteLine("Invalid number");
                Console.WriteLine("Register here");
                Console.Write("Enter your name            : ");
                name = Console.ReadLine();
                Console.Write("Enter your Father name     : ");
                fname = Console.ReadLine();
                Console.Write("Enter your Mother name     : ");
                mname = Console.ReadLine();
                Console.Write("Phone No.                  : ");
                phone = Console.ReadLine();
                Console.Write("Email                      : ");
                email = Console.ReadLine();
                Console.Write("Address                    : ");
                address = Console.ReadLine();
                Console.Write("VID                        : ");
                vid = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Please enter 1 or 2 options");
            }
           



            int p=0,q=0,c=0,v,d,e,f;
            Console.Write("Enter your vote                : ");
            Console.WriteLine("1.P\n2.Q\n3.C\n");
            v=Convert.ToInt32(Console.ReadLine());
            if(v==1)
            {
                 d= p++;
                Console.WriteLine("P                    : "+p);
            }
            else if(v==2) {
                e = q++;
                Console.WriteLine("Q                    : "+q);

            }
            else if(v==3)
            {
                f = c++;
                Console.WriteLine("C                    : "+c);
            }
            else
            {
                Console.WriteLine("Enter above options only");
            }
            Console.WriteLine("Thank you for votting");
        






        }
    }
}
