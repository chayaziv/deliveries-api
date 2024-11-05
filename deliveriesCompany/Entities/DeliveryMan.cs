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

        public double Salary { get; set; }
        public double Bonus { get; set; }

        public void copy(DeliveryMan other)
        {
            Name=other.Name;
            PhoneNumber=other.PhoneNumber;
            Email=other.Email;
            PreferedArea=other.PreferedArea;
            Vehicle=other.Vehicle;
            Salary
        }

    }
}
