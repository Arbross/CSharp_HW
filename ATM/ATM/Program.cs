using System;

namespace ATM
{
    class CreditCard
    {
        private uint uid;
        public CreditCard() {  }
        public uint UID
        {
            get => uid;
            set => uid = value;
        }

        public override string ToString()
        {
            return $"ID : {UID}";
        }
    }
    class ATM
    {
        private int money;
        private string log;
        private string pass;
        private CreditCard credit = new CreditCard();
        public int Money
        {
            get => money;
            set => money = value;
        }

        public ATM(uint id, int money, string log, string pass)
        {
            credit.UID = id;
            Money = money;
            this.pass = pass;
            this.log = log;
        }

        public bool isEquel(uint uid)
        {
            if (credit.UID == uid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void showBalance()
        {
            Console.WriteLine($"Your balance : {money}");
        }

        public void addBalance(int money)
        {
            Money += money;
        }

        public void withDraw(int money)
        {
            // Летять помилки коли пробую через if
            // Та коли пробую : 
            // Money -= money;
            Money = Money - money;

            //if (Money <= money)
            //{
                
            //}
            //else {
            //    throw new Exception("Money is to low to draw them");
            //}
        }

        public override string ToString()
        {
            return $"ID : {credit.UID} Money : {Money}";
        }
    }
    class Program
    {
        static void Main()
        {
            ATM num = new ATM(5, 50, "log", "pass");

            while (true)
            {
                Console.Write("Enter your own uid to continue : ");
                uint number = uint.Parse(Console.ReadLine());
                if (num.isEquel(number))
                {
                    Console.WriteLine("[+]. Show balance");
                    Console.WriteLine("[-]. With draw");
                    Console.WriteLine("[*]. Add balance");
                    char choose = char.Parse(Console.ReadLine());

                    switch (choose)
                    {
                        case '+':
                            {
                                num.showBalance();
                            }
                            break;
                        case '-':
                            {
                                Console.Write("Enter sum to draw : ");
                                int sum = int.Parse(Console.ReadLine());
                                num.withDraw(sum);
                            }
                            break;
                        case '*':
                            {
                                Console.Write("Enter sum to add : ");
                                int sum = int.Parse(Console.ReadLine());
                                num.addBalance(sum);
                            }
                            break;
                    }
                }
                else
                {
                    throw new Exception("Invalid uid.");
                }
            }
        }
    }
}
