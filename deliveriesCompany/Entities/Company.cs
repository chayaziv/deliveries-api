namespace deliveriesCompany.Entities
{
    
    public class Company
    {
        private static int _id = 0;
        public int Id { get; private set; }

        public string AddressOfWarehouse { get; set; }

        public int AgreementId { get; set; }

        public string  ContactPersonName { get; set; }

        public string ContactPersonPhon { get; set; }

        public string ContactPersonMail { get; set; }

        public  DateTime StartAgreementDate { get; set; }

        public Company()
        {
            Id = _id++;
        }

        public void copy(Company other)
        {
            AddressOfWarehouse = other.AddressOfWarehouse;
            AgreementId = other.AgreementId;
            ContactPersonName = other.ContactPersonName;
            ContactPersonMail = other.ContactPersonMail;
            ContactPersonPhon = other.ContactPersonPhon;
            StartAgreementDate = other.StartAgreementDate;
        }
        

    }
}
