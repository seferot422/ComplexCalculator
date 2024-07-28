public class Multiplication : IOperation
{
    public ComplexNumber Execute(ComplexNumber a, ComplexNumber b)
    {
        double real = a.Real * b.Real - a.Imaginary * b.Imaginary;
        double imaginary = a.Real * b.Imaginary + a.Imaginary * b.Real;
        return new ComplexNumber(real, imaginary);
    }
}