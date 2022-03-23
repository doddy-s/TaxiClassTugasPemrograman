namespace taxi{
    public class Taxi{

        //Properties
        public string? driverName{get; set;}
        public bool boolOnDuty{get; set;}
        public int numPassenger{get; set;}

        //Method
        public void writeInfo(){
            Console.WriteLine("Driver Name: {0}", driverName);
            var stringOnDuty = boolOnDuty ? "Yes" : "No";
            Console.WriteLine("On Duty: {0}", stringOnDuty);
            Console.WriteLine("Number of Passenger: {0}", numPassenger);
        }

        public void writePickUpPassenger(){
            Console.WriteLine("Jono sedang menjemput penumpang.");
        }

        public void writeDropOffPassenger(){
            Console.WriteLine("Jono selesai menjemput penumpang.");
        }
    }
}