namespace LearningClasses
{
    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }

        public Country(string name)
        {
            Name = name;
        }
    }

    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("nepal");
        }
    }
}