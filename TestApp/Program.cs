Func<double, double, double> ArithmeticOperation = Sum;

Console.WriteLine(ArithmeticOperation(5, 5));

double Sum(double x, double y) => x + y;
