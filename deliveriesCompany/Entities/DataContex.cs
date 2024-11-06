namespace deliveriesCompany.Entities
{
    public class DataContex
    {

        public List<Agreement> AgreementsList { get; set; } = new List<Agreement>()
        {
            new Agreement(){MinCountPackage=100},
            new Agreement(){MinCountPackage=100},
            new Agreement(){MinCountPackage=100},
            new Agreement(){MinCountPackage=100},
        };

        public List<Company> CompaniesList { get; set; } = new List<Company>()
        {
            new Company(){ StartAgreementDate=new DateTime(2000,3,2)
                ,ContactPersonMail="aa@gmail.com"},
            new Company(){ StartAgreementDate=new DateTime(2000,3,2)
                ,ContactPersonMail="aa@gmail.com"},
            new Company(){ StartAgreementDate=new DateTime(2000,3,2)
                ,ContactPersonMail="aa@gmail.com"}
        };
        public List<DeliveryMan> deliveryMenList = new List<DeliveryMan>()
        {
            new DeliveryMan(){ IdNumber="2156148555",PhoneNumber="055454878"},
            new DeliveryMan(){ IdNumber="2565959512",PhoneNumber="055454878"},
            new DeliveryMan(){ IdNumber="3453617717",PhoneNumber="055454878"},
        };
        public List<Sending> SendingsList { get; set; } = new List<Sending>()
        {
            new Sending() {DeliveryManId=1,  Breakable = true, DestinationFloor = 2, CraneNeed = true ,Status=Status.OnWay},
            new Sending() {DeliveryManId=2,  Breakable = true, DestinationFloor = 2, CraneNeed = true ,Status=Status.OnWay},
            new Sending() {DeliveryManId=1,  Breakable = true, DestinationFloor = 2, CraneNeed = true ,Status=Status.Ready}
        };
    }
}
