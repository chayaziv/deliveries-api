using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using DeliveriesCompany.Core.Entity;

namespace DeliveriesCompany.Data
{
    public class DataContext
    {
        readonly string _filePath = "C:\\Users\\USER\\Documents\\year2\\net core\\homework\\deliveryCompany\\DeliveriesCompany.Data\\CsvFiles";

        public List<Company> companyList;

        public List<Sending> sendingList;

        public List<Agreement> agreementList;

        public List<DeliveryMan> deliveryMenlist;


        public DataContext()
        {
            companyList = loadCompanies();
            sendingList = loadSendings();
            agreementList = loadAgreements();
            deliveryMenlist = loadDeliveryMen();
        }

        public bool SaveData()
        {

            return saveDeliveryMen() &&
                     saveAgreements() &&
                     saveCompanies() &&
                     saveSendings();

        }
        public List<Company> loadCompanies()
        {
            string path = Path.Combine(_filePath, "companies.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Company>().ToList();
        }
        public List<Sending> loadSendings()
        {
            string path = Path.Combine(_filePath, "sendings.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Sending>().ToList();
        }
        public List<Agreement> loadAgreements()
        {
            string path = Path.Combine(_filePath, "agreements.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Agreement>().ToList();
        }
        public List<DeliveryMan> loadDeliveryMen()
        {
            string path = Path.Combine(_filePath, "deliverymen.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<DeliveryMan>().ToList();
        }
        public bool saveDeliveryMen()
        {
            try
            {
                string path = Path.Combine(_filePath, "deliverymen.csv");
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(this.deliveryMenlist);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool saveAgreements()
        {
            try
            {
                string path = Path.Combine(_filePath, "agreements.csv");
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(this.agreementList);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public bool saveSendings()
        {
            try
            {
                string path = Path.Combine(_filePath, "sendings.csv");
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(this.sendingList);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool saveCompanies()
        {
            try
            {
                string path = Path.Combine(_filePath, "companies.csv");
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(this.companyList);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

    }
}
