using static System.Console;
Clear();

Write("Enter coordinate b1= ");
double b1 = int.Parse(ReadLine());
Write("Enter coordinate k1= ");
double k1 = int.Parse(ReadLine());
Write("Enter coordinate b2= ");
double b2 = int.Parse(ReadLine());
Write("Enter coordinate k2= ");
double k2 = int.Parse(ReadLine());



if (k1 == k2)
{
    if (b1 == b2) WriteLine("Straight lines are matched");
    else WriteLine("Lines are parallel");
}
else WriteLine($"The Point of intersection is at the ({x(b1, k1, b2, k2)};{y(b1, k1, x(b1, k1, b2, k2))})");



double x(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}
double y(double b, double k, double x)
{
    return k * x + b;
}