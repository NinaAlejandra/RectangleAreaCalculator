// See https://aka.ms/new-console-template for more information
Console.WriteLine("Rectangle Area Calculator");
Console.WriteLine("Enter the length if the rectangle");
double length = Convert.ToDouble(Console.ReadLine());   

Console.WriteLine("Enter the width if the rectangle");
double width = Convert.ToDouble(Console.ReadLine());  

double area = length * width;

Console.WriteLine($"The area of the rectangle is: {area}");

