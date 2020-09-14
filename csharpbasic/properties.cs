public class Person
{
    internal int age = 23;

    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value > 20 && value < 30)
            {
                age = value;
            }
        }
    }
}