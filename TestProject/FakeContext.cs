using CsvHelper;
using deliveriesCompany;
using deliveriesCompany.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{

    public class FakeContext : IDataContext
    {
        public static List<Agreement> AgreementsList { get; set; } = new List<Agreement>()
        {
            new Agreement(){Id=1,MinCountPackage=100},
            new Agreement(){Id=2,MinCountPackage=100},
            new Agreement(){Id=3,MinCountPackage=100},
            new Agreement(){Id=4,MinCountPackage=100},
        };

        public static List<Company> CompaniesList { get; set; } = new List<Company>()
        {
            new Company(){Id=1, StartAgreementDate=new DateTime(2000,3,2)
                ,ContactPersonMail="aa@gmail.com"},
            new Company(){Id=2, StartAgreementDate=new DateTime(2000,3,2)
                ,ContactPersonMail="aa@gmail.com"},
            new Company(){Id=3, StartAgreementDate=new DateTime(2000,3,2)
                ,ContactPersonMail="aa@gmail.com"}
        };
        public static List<DeliveryMan> deliveryMenList = new List<DeliveryMan>()
        {
            new DeliveryMan(){Id=1, IdNumber="2156148555",PhoneNumber="055454878"},
            new DeliveryMan(){Id=2,  IdNumber="2565959512",PhoneNumber="055454878"},
            new DeliveryMan(){Id=3,  IdNumber="3453617717",PhoneNumber="055454878"},
        };
        public static List<Sending> SendingsList { get; set; } = new List<Sending>()
        {
            new Sending() {Id=1,DeliveryManId=1,  Breakable = true, DestinationFloor = 2, CraneNeed = true ,Status=Status.OnWay},
            new Sending() {Id=2,DeliveryManId=2,  Breakable = true, DestinationFloor = 2, CraneNeed = true ,Status=Status.OnWay},
            new Sending() {Id=3,DeliveryManId=1,  Breakable = true, DestinationFloor = 2, CraneNeed = true ,Status=Status.Ready}
        };

        public List<DeliveryMan> loadDeliveryMen()
        {
            return deliveryMenList;
        }

        public bool saveDeliveryMen(List<DeliveryMan> deliveryMen)
        {
            deliveryMenList = deliveryMen;
            return true;
        }

        public List<Agreement> loadAgreements()
        {
            return AgreementsList;
        }

        public bool saveAgreements(List<Agreement> agreements)
        {
            AgreementsList = agreements;
            return true;
        }

        public List<Company> loadCompanies()
        {
            return CompaniesList;
        }

        public bool saveCompanies(List<Company> companies)
        {
            CompaniesList = companies;
            return true;
        }

        public List<Sending> loadSendings()
        {
            return SendingsList;
        }

        public bool saveSendings(List<Sending> sendings)
        {
            SendingsList = sendings;
            return true;
        }
    }
}
