using System;

namespace DelegatesAndEvents
{
    /*1. Використати стандартний делегат  Func<> для класу Калькулятор(Calculator).
      У класі Calculator визначити 
    o	об’єкт func  стандартного делегату Func<>, якому буде призначатися метод(чи лямбда) додавання, віднімання, і т. і. 
        в залежності від параметра методу SetOperation( string operation),  можна operation оголосити як char або enum 
    o	метод double Calculate(double, double) повинен повертати результат обчислення, викликаючи функцію(чи лямбда) по делегату func*/
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Calculate(5, 5));
            calculator.SetOperation(Calculator.Type.Minus);
            Console.WriteLine(calculator.Calculate(5, 10));
            calculator.SetOperation(Calculator.Type.Mnozenna);
            Console.WriteLine(calculator.Calculate(5, 5));
            calculator.SetOperation(Calculator.Type.Dilenna);
            Console.WriteLine(calculator.Calculate(5, 5));
        }
    }
}
