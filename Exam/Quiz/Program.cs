using System;
using System.Collections;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            TmpQuiz t = new TmpQuiz();
            GeneralQuiz[] generalQuiz = new GeneralQuiz[3];
            generalQuiz[0] = new GeneralQuiz();
            generalQuiz[1] = new GeneralQuiz();
            generalQuiz[2] = new GeneralQuiz();

            generalQuiz[0].Type = IQuiz.Type.Biology;
            generalQuiz[1].Type = IQuiz.Type.History;
            generalQuiz[2].Type = IQuiz.Type.Rnd;

            LoginAndRegisterServiceMethod(t, ref generalQuiz);

            Console.Clear();

            char choose = ' ';
            while (true)
            {
                Console.WriteLine($"+ - Start quiz");
                Console.WriteLine($"_ - Top 20");
                Console.WriteLine($"* - Change data");
                Console.WriteLine($". - Log Out");
                Console.WriteLine($"& - Exit");
                choose = Console.ReadLine()[0];

                switch (choose)
                {
                    case '+':
                        {
                            Console.Clear();

                            Console.WriteLine($"Types :");
                            Console.WriteLine($" 0 - Biology");
                            Console.WriteLine($" 1 - History");
                            Console.WriteLine($" 2 - Random");
                            int type = int.Parse(Console.ReadLine());

                            generalQuiz[type].Type = (IQuiz.Type)type;
                            // FillQuiz.Fill(ref generalQuiz.questions, generalQuiz.Type);
                            t.questionService.Add(generalQuiz[type]);

                            Console.Clear();

                            t.Start();
                            t.usersService.GetResults((IQuiz.Type)type);
                        } break;
                    case '_':
                        {
                            Console.Clear();

                            Console.WriteLine($"Types :");
                            Console.WriteLine($" 0 - Biology");
                            Console.WriteLine($" 1 - History");
                            Console.WriteLine($" 2 - Random");
                            int type = int.Parse(Console.ReadLine());

                            t.TopTwenty((IQuiz.Type)type);
                        } break;
                    case '*':
                        {
                            Console.Clear();

                            Console.WriteLine($"Types :");
                            Console.WriteLine($" 0 - Password and birthday");
                            Console.WriteLine($" 1 - Password");
                            Console.WriteLine($" 2 - Birthday");
                            int type = int.Parse(Console.ReadLine());

                            switch (type)
                            {
                                case 0:
                                    {
                                        Console.Write("Enter password : "); string password = Console.ReadLine();
                                        Console.Write("Enter birthday : "); string birth = Console.ReadLine();
                                        t.usersService.Change(password, DateTime.Parse(birth));
                                    } break;
                                case 1:
                                    {
                                        Console.Write("Enter password : "); string password = Console.ReadLine();
                                        t.usersService.Change(password);
                                    }
                                    break;
                                case 2:
                                    {
                                        Console.Write("Enter birthday : "); string birth = Console.ReadLine();
                                        t.usersService.Change(DateTime.Parse(birth));
                                    }
                                    break;
                                default:
                                    break;
                            }
                        } break;
                    case '.':
                        {
                            t.usersService.Exit();
                            LoginAndRegisterServiceMethod(t, ref generalQuiz);
                        } break;
                    case '&':
                        {
                            Environment.Exit(0);
                        } break;
                }

                Console.Clear();
            }
        }

        private static void LoginAndRegisterServiceMethod(TmpQuiz t, ref GeneralQuiz[] generalQuiz)
        {
            char loginChoose = ' ';
            Console.WriteLine($"+ - Login");
            Console.WriteLine($"- - Register");
            Console.WriteLine($"e - Edit");
            Console.WriteLine($"f - Fill");
            loginChoose = Console.ReadLine()[0];

            switch (loginChoose)
            {
                case '+':
                    {
                        Console.Write("Enter login : "); string login = Console.ReadLine();
                        Console.Write("Enter password : "); string passwd = Console.ReadLine();

                        t.usersService.Login(login, passwd);
                    }
                    break;
                case '-':
                    {
                        Console.Write("Enter login : "); string login = Console.ReadLine();
                        Console.Write("Enter password : "); string passwd = Console.ReadLine();
                        Console.Write("Enter birth date (5/1/2008 8:30:52 AM): "); string date = Console.ReadLine();

                        t.usersService.Register(login, passwd, DateTime.Parse(date));

                        Console.Clear();

                        Console.WriteLine("Login : ");
                        Console.Write("Enter login : "); string llogin = Console.ReadLine();
                        Console.Write("Enter password : "); string ppasswd = Console.ReadLine();

                        t.usersService.Login(llogin, ppasswd);
                    }
                    break;
                case 'e':
                    {
                        char tmp = ' ';
                        Console.WriteLine($"+ - Login");
                        Console.WriteLine($"- - Register");
                        tmp = Console.ReadLine()[0];

                        switch (tmp)
                        {
                            case '+':
                                {
                                    Console.Write("Enter login : "); string login = Console.ReadLine();
                                    Console.Write("Enter password : "); string passwd = Console.ReadLine();

                                    t.usersService.Login(login, passwd);
                                }
                                break;
                            case '-':
                                {
                                    Console.Write("Enter login : "); string login = Console.ReadLine();
                                    Console.Write("Enter password : "); string passwd = Console.ReadLine();
                                    Console.Write("Enter birth date (5/1/2008 8:30:52 AM): "); string date = Console.ReadLine();

                                    t.usersService.Register(login, passwd, DateTime.Parse(date));

                                    Console.Clear();

                                    Console.WriteLine("Login : ");
                                    Console.Write("Enter login : "); string llogin = Console.ReadLine();
                                    Console.Write("Enter password : "); string ppasswd = Console.ReadLine();

                                    t.usersService.Login(llogin, ppasswd);
                                }
                                break;
                        }

                        Console.WriteLine($"Types :");
                        Console.WriteLine($" 0 - Biology");
                        Console.WriteLine($" 1 - History");
                        Console.WriteLine($" 2 - Random");
                        int type = int.Parse(Console.ReadLine());

                        Console.Write($"Enter index : ");
                        int index = int.Parse(Console.ReadLine());
                        FillQuiz.Edit(ref generalQuiz[type], index, (IQuiz.Type)type);
                    } break;
                case 'f':
                    {
                        char tmp = ' ';
                        Console.WriteLine($"+ - Login");
                        Console.WriteLine($"- - Register");
                        tmp = Console.ReadLine()[0];

                        switch (tmp)
                        {
                            case '+':
                                {
                                    Console.Write("Enter login : "); string login = Console.ReadLine();
                                    Console.Write("Enter password : "); string passwd = Console.ReadLine();

                                    t.usersService.Login(login, passwd);
                                }
                                break;
                            case '-':
                                {
                                    Console.Write("Enter login : "); string login = Console.ReadLine();
                                    Console.Write("Enter password : "); string passwd = Console.ReadLine();
                                    Console.Write("Enter birth date (5/1/2008 8:30:52 AM): "); string date = Console.ReadLine();

                                    t.usersService.Register(login, passwd, DateTime.Parse(date));

                                    Console.Clear();

                                    Console.WriteLine("Login : ");
                                    Console.Write("Enter login : "); string llogin = Console.ReadLine();
                                    Console.Write("Enter password : "); string ppasswd = Console.ReadLine();

                                    t.usersService.Login(llogin, ppasswd);
                                }
                                break;
                        }

                        Console.WriteLine($"Types :");
                        Console.WriteLine($" 0 - Biology");
                        Console.WriteLine($" 1 - History");
                        Console.WriteLine($" 2 - Random");
                        int type = int.Parse(Console.ReadLine());

                        FillQuiz.Fill(ref generalQuiz[type], (IQuiz.Type)type);
                    }
                    break;
                default: LoginAndRegisterServiceMethod(t, ref generalQuiz);
                    break;
            }
        }
    }
}
