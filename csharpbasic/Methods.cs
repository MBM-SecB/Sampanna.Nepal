using System;
public class MethodTeacher
{
    //passing variable number of arguments
    public int Multiply(params int[] numbers)
    {
        int product = 1;
        foreach (int num in numbers)
        {
            product = product * num;
        }
        return product;
    }
    internal (int, int) FindMaxMin(params int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num < min)
                min = num;
            if (num > max)
                max = num;
        }
        return (max, min);
    }
}



public class MethodTester
{
    void TestMethod()
    {
        MethodTeacher methodTeacher = new MethodTeacher();
        int product = methodTeacher.Multiply(2, 6, 8);

        (int Min, int Max) result = methodTeacher.FindMaxMin(2, 4, 5, 6, 6, 9);
        // var result = methodTeacher.FindMaxMin(2, 4, 5, 6, 6, 9);
        Console.Write($"minimum:{result.Min},Maximum:{result.Max}");
    }
}