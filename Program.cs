namespace taxi{
    class Program{
        static void Main(string[] args){

            //Membuat objek Taxi
            Taxi taxi = new Taxi();


            //Input nilai properties
            taxi.driverName = "Jono";
            taxi.boolOnDuty = false;
            taxi.numPassenger = 10;

            //Memanggil method
            taxi.writeInfo();
            taxi.writePickUpPassenger();
            taxi.writeDropOffPassenger();

            Console.ReadKey();

        }
    }
}