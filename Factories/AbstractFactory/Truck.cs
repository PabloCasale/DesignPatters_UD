namespace Factories.AbstractFactory
{
    public abstract class Truck
    {
        public string Name { get; set; }

        protected string description;

        public string Description
        {
            get { return description; }
        }
    }
}