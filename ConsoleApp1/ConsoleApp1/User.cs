using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class User
    {
        public string Name;
        public string SurName;
        public string Email;
        public bool IsSingle;

        public Post[] Posts;
        public Comment[] Comments;


        private int _age;
        public int Age { 
            get {
                return _age;
            } 
            set {
                if (value > 0 && value <= 200)
                {
                    _age = value;
                }
            }
        }

        //public void SetAge(int age)
        //{
        //    if (age > 0 && age <= 200)
        //    {
        //        Age = age;
        //    }
        //}

        //public int GetAge()
        //{
        //    return Age;
        //}

    }
}
