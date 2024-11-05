namespace deliveriesCompany.Entities
{
    public enum Area
    {
        North, Gush_Dan, Jerusalem, Haifa
    }
    public enum Vehicle
    {
        truck, car, motorcycle
    }


    public class DeliveryMan
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Area PreferedArea { get; set; }


        public Vehicle Vehicle { get; set; }

        public double salary { get; set; }
        public double Bonus { get; set; }

    }
}
