namespace deliveriesCompany.Entities
{
    
    public class Company
    {      
        public int Id { get;  set; }

        public string AddressOfWarehouse { get; set; }

        public int AgreementId { get; set; }

        public string  ContactPersonName { get; set; }

        public string ContactPersonPhon { get; set; }

        public string ContactPersonMail { get; set; }

        public  DateTime StartAgreementDate { get; set; }
       

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
