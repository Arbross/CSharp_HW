using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class User
    {
        private string login;
        private string pass;
        private DateTime birth;
        private int[] score;
        public int[] Score
        {
            get => score;
            set => score = value;
        }
        public string Login
        {
            get => login;
            set => login = value;
        }
        public string Password
        {
            get => pass;
            set => pass = value;
        }
        public DateTime Birthday
        {
            get => birth;
            set => birth = value;
        }
        public User(string login, string pass, DateTime birth)
        {
            score = new int[3];
            Login = login;
            Password = pass;
            Birthday = birth;
        }
        public override string ToString()
        {
            return $"Login : {Login}, Score : /20, Password : {Password}, Birthday : {Birthday}";
        }
    }
}
