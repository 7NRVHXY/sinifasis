namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Vehicle vehicle1 = new Car();
           Vehicle vehicle2 = new Bus();

            Car car1 =vehicle1 as Car;
            if(car1 != null ) 
            {
                car1.Drive();
            }
            else
            {
                Console.WriteLine("as islederek , car deyl");
            }
            Bus bus1 = vehicle1 as Bus;
            if (bus1 != null)
            {
                bus1.Drive();
            }
            else
            {
                Console.WriteLine("as islederek , bus deyl");
            }

            //if (vehicle1 is Car )
            //{
            //    vehicle1.Drive();
            //}
            //else
            //{
            //    Console.WriteLine("bu car deyl");
            //}
            //if (vehicle2 is Bus)
            //{
            //    vehicle2.Drive();
            //}
            //else 
            //{
            //    Console.WriteLine("bu bus deyl");
            //}


        }
    }
}