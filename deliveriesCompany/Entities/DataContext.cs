using CsvHelper;
using System.Globalization;
using System.IO;

namespace deliveriesCompany.Entities
{
    public class DataContext : IDataContext
    {
       
        readonly string _filePath = "C:\\Users\\User\\Documents\\year2\\net core\\homework\\deliveryCompany\\deliveriesCompany\\Data\\";
        public List<DeliveryMan> loadDeliveryMen()
        {
            string path = Path.Combine(_filePath, "deliverymen.csv");

            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var dlist = csv.GetRecords<DeliveryMan>().ToList();
            return dlist;
        }
        public bool saveDeliveryMen(List<DeliveryMan> deliveryMen)
        {
            try
            {
                string path = Path.Combine(_filePath, "deliverymen.csv");
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);              
                csv.WriteRecords(deliveryMen);
                return true;
            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
        public List<Agreement> loadAgreements()
        {
           
            string path = Path.Combine(_filePath, "agreements.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Agreement>().ToList();
        }
        public bool saveAgreements(List<Agreement> agreements)
        {
            try
            {
                string path = Path.Combine(_filePath, "agreements.csv");
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(agreements);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine( e.Message);
                return false;
            }
        }

        public List<Company> loadCompanies()
        {
            string path = Path.Combine(_filePath, "companies.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Company>().ToList();
        }
        public bool saveCompanies(List<Company> companies)
        {
            try
            {
                string path = Path.Combine(_filePath, "companies.csv");
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(companies);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message  );
                return false;
            }
        }   
        public List<Sending> loadSendings()
        {
            string path = Path.Combine(_filePath, "sendings.csv");
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Sending>().ToList();
        }   
        public bool saveSendings(List<Sending> sendings)
        {
            try
            {
                string path = Path.Combine(_filePath, "sendings.csv");
                using var writer = new StreamWriter(path);
                using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
                csv.WriteRecords(sendings);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

      
    }
}
