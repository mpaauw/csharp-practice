public class Program
{
    static void Main(string[] args)
    {
        Car car = new Car.CarBuilder().setMake("Volkswagen").setModel("Golf Gti").setColor("White").setNumDoors(2).setHp(300).setIsManual(true).build();
        car.describe();
    }

    public class Car
    {
        private string make;
        private string model;
        private string color;
        private int numDoors;
        private int hp;
        private bool isManual;

        public Car(CarBuilder builder)
        {
            this.make = builder.make;
            this.model = builder.model;
            this.color = builder.color;
            this.numDoors = builder.numDoors;
            this.hp = builder.hp;
            this.isManual = builder.isManual;
        }

        public void describe()
        {
            System.Diagnostics.Debug.WriteLine(make + "\n" + model + "\n" + color + "\n" + numDoors + "\n" + hp + "\n" + isManual);
        }

        public string getMake()
        {
            return make;
        }

        public void setMake(string make)
        {
            this.make = make;
        }

        public string getModel()
        {
            return model;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public string getColor()
        {
            return color;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public int getNumDoors()
        {
            return numDoors;
        }

        public void setNumDoors(int numDoors)
        {
            this.numDoors = numDoors;
        }

        public int getHp()
        {
            return hp;
        }

        public void setHp(int hp)
        {
            this.hp = hp;
        }

        public bool getIsManual()
        {
            return isManual;
        }

        public void setIsManual(bool isManual)
        {
            this.isManual = isManual;
        }

        public class CarBuilder
        {
            public string make;
            public string model;
            public string color;
            public int numDoors;
            public int hp;
            public bool isManual;

            public CarBuilder setMake(string make)
            {
                this.make = make;
                return this;
            }

            public CarBuilder setModel(string model)
            {
                this.model = model;
                return this;
            }

            public CarBuilder setColor(string color)
            {
                this.color = color;
                return this;
            }

            public CarBuilder setNumDoors(int numDoors)
            {
                this.numDoors = numDoors;
                return this;
            }

            public CarBuilder setHp(int hp)
            {
                this.hp = hp;
                return this;
            }

            public CarBuilder setIsManual(bool isManual)
            {
                this.isManual = isManual;
                return this;
            }

            public Car build()
            {
                return new Car(this);
            }
        }
    }
}