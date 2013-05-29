namespace CSharpApplication
{
    public class Diagnosis
    {
        public static bool HasFever(Temperature temperature)
        {
            if (temperature is Celcius)
            {
                return temperature.Value > 37.5;
            }
            if (temperature is Farenheit)
            {
                return temperature.Value > 99.5;
            }
        }
    }

    public abstract class Temperature
    {
        private readonly double value;

        protected Temperature(double value)
        {
            this.value = value;
        }

        public double Value { get { return value; }}
    }

    public class Celcius : Temperature
    {
        public Celcius(double value) : base(value) 
        {
            
        }
    }

    public class Farenheit : Temperature
    {
        public Farenheit(double value) : base(value)
        {

        }
    }
}