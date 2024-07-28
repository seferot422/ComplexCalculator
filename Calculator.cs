using System;
using System.IO;

public class Calculator
{
    private IOperation _operation;
    private readonly string _logFilePath = "calculator.log";

    public Calculator(IOperation operation)
    {
        _operation = operation;
    }

    public void SetOperation(IOperation operation)
    {
        _operation = operation;
    }

    public ComplexNumber Calculate(ComplexNumber a, ComplexNumber b)
    {
        ComplexNumber result = _operation.Execute(a, b);
        LogOperation(a, b, result);
        return result;
    }

    private void LogOperation(ComplexNumber a, ComplexNumber b, ComplexNumber result)
    {
        string logMessage = $"{DateTime.Now}: Operation: {_operation.GetType().Name}, Operands: {a}, {b}, Result: {result}";
        Console.WriteLine(logMessage);
        File.AppendAllText(_logFilePath, logMessage + Environment.NewLine);
    }
}