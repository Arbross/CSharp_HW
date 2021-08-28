using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class UsersService : ILogin
    {
        private List<User> data;
        public User currentUser;
        public UsersService()
        {
            data = new List<User>();
        }
        public List<User> Data
        {
            get => data;
        }
        public void Change(string pass, DateTime birth)
        {
            if (currentUser != null)
            {
                currentUser.Password = pass;
                currentUser.Birthday = birth;
            }
            else
            {
                throw new InvalidOperationException("You aren't login in the system. Please login or register your accout to enter.");
            }
        }
        public void Change(string pass)
        {
            if (currentUser != null)
            {
                currentUser.Password = pass;
            }
            else
            {
                throw new InvalidOperationException("You aren't login in the system. Please login or register your accout to enter.");
            }
        }
        public void Change(DateTime birth)
        {
            if (currentUser != null)
            {
                currentUser.Birthday = birth;
            }
            else
            {
                throw new InvalidOperationException("You aren't login in the system. Please login or register your accout to enter.");
            }
        }
        public void GetResults(IQuiz.Type type)
        {
            if (currentUser != null)
            {
                if (currentUser.Score[(int)type] < 20)
                {
                    Console.WriteLine($"{currentUser.Score[(int)type]}/20");
                }
                if (currentUser.Score[(int)type] == 20)
                {
                    Console.WriteLine($"You are the winner({currentUser.Score[(int)type]}/20)!");
                }

                Data.OrderByDescending(x => x.Score[(int)type]);
                int i = 0;
                foreach (User item in Data)
                {
                    if (item == currentUser)
                    {
                        Console.WriteLine($"Your position in rating - {i}.");
                    }
                    ++i;
                }

                Console.ReadKey();
            }
            else
            {
                throw new InvalidOperationException("You aren't login in the system. Please login or register your accout to enter.");
            }
        }
        public void Exit()
        {
            if (currentUser != null)
            {
                currentUser = null;
            }
            else
            {
                throw new InvalidOperationException("You aren't login in the system. Please login or register your accout to enter.");
            }
        }
        public void Register(string login, string pass, DateTime date)
        {
            foreach (var item in data)
            {
                if (item.Login == login)
                {
                    throw new Exception("User login already exists.");
                }
            }
            data.Add(new User(login, pass, date));
        }
        public void Login(string login, string pass)
        {
            foreach (var item in data)
            {
                if (item.Login == login && item.Password == pass)
                {
                    currentUser = item;
                    return;
                }
            }
            throw new Exception("Can't login. Change login or password to login. Or register using func Register()");
        }
    }
}
