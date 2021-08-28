using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    interface ILogin
    {
        void Login(string login, string pass);
        void Register(string login, string pass, DateTime date);
        void Change(string pass, DateTime birth);
        void Change(string pass);
        void Change(DateTime birth);
        void GetResults(IQuiz.Type type);
        void Exit();
    }
    interface IQuiz
    {
        enum Type : byte { History, Biology, Rnd }
        void Start();
        void TopTwenty(IQuiz.Type type);
    }
}
