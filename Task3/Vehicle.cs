namespace Task3
{
    public class Vehicle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public decimal Price { get; set; }
        public double Speed { get; set; }
        public int CreateYear { get; set; }

        public Vehicle(int x, int y, decimal price, double speed, int createYear)
        {
            X = x;
            Y = y;
            Price = price;
            Speed = speed;
            CreateYear = createYear;
        }

        public virtual void Print()
        {
            Console.WriteLine("x = " + X + ", y = " + Y + ", price = " + Price + ", speed = " + Speed + ", create year = " + CreateYear);
        }
    }
}
