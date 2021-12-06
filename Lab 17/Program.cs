using System;

namespace Lab_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Bankaccount<string> bankaccount1 = new Bankaccount<string>("01", 122222,"Иванов Иван Иванович");
            Console.WriteLine("Номер счета: {0}",bankaccount1.Number);
            Console.WriteLine("Баланс: {0}",bankaccount1.Balance);
            Console.WriteLine("ФИО владельца: {0}",bankaccount1.Name);

            Bankaccount<int> bankaccount2 = new Bankaccount<int>(1, 122222, "Иванов Иван Иванович");
            Console.WriteLine("Номер счета: {0}", bankaccount2.Number);
            Console.WriteLine("Баланс: {0}", bankaccount2.Balance);
            Console.WriteLine("ФИО владельца: {0}", bankaccount2.Name);

        }
    }
    class Bankaccount <T>
    {
        public T Number { get; set; }
        public int Balance { get; set; }
        public string Name { get; set; }
        public Bankaccount (T number,int balance, string name)
        {
            this.Number = number;
            this.Balance = balance;
            this.Name = name;
        }
    }
}
