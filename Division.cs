public class Division : IOperation
{
    public ComplexNumber Execute(ComplexNumber a, ComplexNumber b)
    {
        double denominator = b.Real * b.Real + b.Imaginary * b.Imaginary;
        double real = (a.Real * b.Real + a.Imaginary * b.Imaginary) / denominator;
        double imaginary = (a.Imaginary * b.Real - a.Real * b.Imaginary) / denominator;
        return new ComplexNumber(real, imaginary);
    }
}