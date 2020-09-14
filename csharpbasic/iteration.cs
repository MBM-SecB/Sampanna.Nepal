using System;
class IterationStatement
{
    static void Main()
    {
        IterationStatement IterationStatementObj = new IterationStatement();
        IterationStatementObj.ForLoop();

        Person person = new Person();
        person.Age = 34;
    }
    void ForLoop()
    {
        // int i;
        // for (i = 0; i < 10; i++)
        // {
        //     Console.WriteLine("hello");
        // }

        byte[] personAges = { 23, 45, 55, 78, 99 };

        foreach (byte age in personAges)
        {
            if (age % 2 == 0)
            {
                Console.WriteLine(age + " is even");
            }
            else
            {
                Console.WriteLine(age + " is odd");
            }
        }
        void LearnWhileLoops()
        {
            char confirm = 'y';
            while (confirm == 'y')
            {
                Console.WriteLine("iam inside while");
                Console.Write("Enter Y to continue");
                confirm = Console.ReadKey().KeyChar;

            }
        }
    }
}