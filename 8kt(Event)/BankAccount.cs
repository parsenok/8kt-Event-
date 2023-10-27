//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _8kt_Event_
//{

//    //    class BankAccount
//    //    {
//    //        decimal Balance { get; set; }
//    //        public event Action<decimal> BalanceChanged;
//    //        public BankAccount(decimal initialBalance)
//    //        {
//    //            Balance = initialBalance;
//    //        }
//    //        public void Deposit(decimal amount)
//    //        {
//    //            BalanceChanged?.Invoke(Balance);
//    //            Balance += amount;

//    //        }
//    //        public void WithDraw(decimal amount)
//    //        {
//    //            BalanceChanged?.Invoke(Balance);
//    //            Balance -= amount;
//    //        }

//    //    }
//    //    class Logger
//    //    {
//    //        public void Info(BankAccount bankAccount)
//    //        {
//    //            bankAccount.BalanceChanged += BalanceChan;
//    //        }

//    //    }


//    using System;
//    using System.IO;
//    class BankAccount
//    {
//        private decimal balance;
//        public decimal Balance
//        {
//            get { return balance; }
//            private set { balance = value; }
//        }
//        public event Action<decimal> BalanceChanged;
//        public BankAccount(decimal initialBalance)
//        {
//            Balance = initialBalance;
//        }
//        public void Deposit(decimal amount)
//        {
//            Balance += amount;
//            BalanceChanged?.Invoke(Balance);
//        }
//        public void Withdraw(decimal amount)
//        {
//            Balance -= amount;
//            BalanceChanged?.Invoke(Balance);
//        }
//    }
//    class Logger
//    {
//        private string logFilePath;

//        public Logger(string filePath)
//        {
//            logFilePath = filePath;
//        }

//        public void LogBalanceChange(decimal newBalance)
//        {
//            string logMessage = $"Balance changed: {newBalance}";
//            File.AppendAllText(logFilePath, logMessage + Environment.NewLine);
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            BankAccount account = new BankAccount(1000.0m);
//            Logger logger = new Logger("E:\\практики по тестированию\\8kt(Event)\\8kt(Event)\\balance_log.txt");
//            account.BalanceChanged += logger.LogBalanceChange;
//            account.Deposit(500.0m);
//            account.Withdraw(200.0m);
//            Console.WriteLine("Current balance: " + account.Balance);
//            string[] logLines = File.ReadAllLines("E:\\практики по тестированию\\8kt(Event)\\8kt(Event)\\balance_log.txt");
//            Console.WriteLine("Balance change log:");
//            foreach (string line in logLines)
//            {
//                Console.WriteLine(line);
//            }
//        }
//    }


//}
