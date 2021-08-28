using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class FillQuiz
    {
        public static void Fill(ref GeneralQuiz generalQuiz, IQuiz.Type type)
        {
            generalQuiz.Type = (IQuiz.Type)type;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter question : "); string question = Console.ReadLine();
                Console.Write("Enter count of answers : "); int countOfAnswers = int.Parse(Console.ReadLine());

                List<string> answers = new List<string>();
                for (int j = 0; j < countOfAnswers; j++)
                {
                    Console.Write("Enter answer : "); string answer = Console.ReadLine();
                    answers.Add(answer);
                }

                Add(question, answers, ref generalQuiz.questions);
            }

            Console.Clear();
        }

        public static void Edit(ref GeneralQuiz generalQuiz, int index, IQuiz.Type type)
        {
            int i = 0;
            foreach (var item in generalQuiz.questions)
            {
                if (i == index)
                {
                    generalQuiz.questions.RemoveAt(i);

                    Console.Write("Enter question : "); string question = Console.ReadLine();
                    Console.Write("Enter count of answers : "); int countOfAnswers = int.Parse(Console.ReadLine());

                    List<string> answers = new List<string>();
                    for (int j = 0; j < countOfAnswers; j++)
                    {
                        Console.Write("Enter answer : "); string answer = Console.ReadLine();
                        answers.Add(answer);
                    }

                    Add(question, answers, ref generalQuiz.questions);
                    break;
                }
                ++i;
            }
        }

        public static void Add(string question, List<string> answer, ref SortedList<string, List<string>> questions)
        {
            questions.Add(question, answer);
        }
    }

    class GeneralQuiz
    {
        public SortedList<string, List<string>> questions;
        private IQuiz.Type type;
        public IQuiz.Type Type
        {
            get => type;
            set => type = value;
        }
        public GeneralQuiz(IQuiz.Type type)
        {
            this.type = type;
            questions = new SortedList<string, List<string>>();

            List<string> str = new List<string>();
            str.Add("qwe");
            FillQuiz.Add("qweqwe", str, ref questions);
        }
        public GeneralQuiz() : this(default(IQuiz.Type)) { }
    }
    class TmpQuiz
    {
        public UsersService usersService;
        public List<GeneralQuiz> questionService;
        public TmpQuiz()
        {
            usersService = new UsersService();
            questionService = new List<GeneralQuiz>();
        }
        public void TopTwenty(IQuiz.Type type)
        {
            int counter = 0;
            usersService.Data.OrderByDescending(x => x.Score[(int)type]);
            foreach (User item in usersService.Data)
            {
                Console.WriteLine($"{++counter}. {item.Login} - {item.Score[(int)type]}");
            }

            Console.ReadKey();
        }
        public void Start()
        {
            foreach (GeneralQuiz item in questionService)
            {
                if (item.Type == IQuiz.Type.Biology)
                {
                    foreach (var b in item.questions)
                    {
                        Console.WriteLine(b.Key);
                        foreach (var value in b.Value)
                        {
                            if (Console.ReadLine() == value)
                            {
                                usersService.currentUser.Score[(int)IQuiz.Type.Biology]++;
                            }
                        }
                    }
                }
                else if (item.Type == IQuiz.Type.History)
                {
                    foreach (var b in item.questions)
                    {
                        Console.WriteLine(b.Key);
                        foreach (var value in b.Value)
                        {
                            if (Console.ReadLine() == value)
                            {
                                usersService.currentUser.Score[(int)IQuiz.Type.History]++;
                            }
                        }
                    }
                }
                else if (item.Type == IQuiz.Type.Rnd)
                {
                    foreach (var b in item.questions)
                    {
                        Console.WriteLine(b.Key);
                        foreach (var value in b.Value)
                        {
                            if (Console.ReadLine() == value)
                            {
                                usersService.currentUser.Score[(int)IQuiz.Type.Rnd]++;
                            }
                        }
                    }
                }
            }
        }
    }
}
