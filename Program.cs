using System;

class Program
{
    static void Main(string[] args)
    {
        // Запрашиваем у пользователя ввод первого комплексного числа
        Console.WriteLine("Введите действительную часть первого комплексного числа:");
        double real1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите мнимую часть первого комплексного числа:");
        double imag1 = Convert.ToDouble(Console.ReadLine());

        ComplexNumber a = new ComplexNumber(real1, imag1);

        // Запрашиваем у пользователя ввод второго комплексного числа
        Console.WriteLine("Введите действительную часть второго комплексного числа:");
        double real2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите мнимую часть второго комплексного числа:");
        double imag2 = Convert.ToDouble(Console.ReadLine());

        ComplexNumber b = new ComplexNumber(real2, imag2);

        // Запрашиваем у пользователя выбор операции
        Console.WriteLine("Выберите операцию: 1 - сложение, 2 - умножение, 3 - деление");
        int operationChoice = Convert.ToInt32(Console.ReadLine());

        IOperation operation;
        switch (operationChoice)
        {
            case 1:
                operation = new Addition();
                break;
            case 2:
                operation = new Multiplication();
                break;
            case 3:
                operation = new Division();
                break;
            default:
                Console.WriteLine("Некорректный выбор операции.");
                return;
        }

        Calculator calculator = new Calculator(operation);
        ComplexNumber result = calculator.Calculate(a, b);
        Console.WriteLine("Результат: " + result);
    }
}