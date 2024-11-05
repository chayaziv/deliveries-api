namespace deliveriesCompany.Entities
{
    
    public class Company
    {
        
        public int Id { get; set; }

        public string AddressOfWarehouse { get; set; }

        public Agreement Agreement { get; set; }

        public string  ContactPersonName { get; set; }

        public string ContactPersonPhon { get; set; }

        public string ContactPersonMail { get; set; }

        public  DateTime StartAgreementDate { get; set; }

        

    }
}
