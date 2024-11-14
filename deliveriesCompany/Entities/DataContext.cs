using CsvHelper;
using System.Globalization;
using System.IO;

namespace deliveriesCompany.Entities
{
    public class DataContext<T> : IDataContext<T>
    {
       
        readonly string _filePath = "C:\\Users\\User\\Documents\\year2\\net core\\homework\\deliveryCompany\\deliveriesCompany\\Data\\";
       

        public List<T> loadData(string csvPath)
        {
            string path = Path.Combine(_filePath, csvPath);
            using var reader = new StreamReader(path);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var dlist = csv.GetRecords<T>().ToList();
            return dlist;
        }
      
        public bool saveData(List<T> deliveryMen,string csvPath)
        {
            try
            {
                
                string path = Path.Combine(_filePath, csvPath);
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

       

        //public List<Company> loadCompanies()
        //{
        //    string path = Path.Combine(_filePath, "companies.csv");
        //    using var reader = new StreamReader(path);
        //    using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        //    return csv.GetRecords<Company>().ToList();
        //}
        //public bool saveCompanies(List<Company> companies)
        //{
        //    try
        //    {
        //        string path = Path.Combine(_filePath, "companies.csv");
        //        using var writer = new StreamWriter(path);
        //        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        //        csv.WriteRecords(companies);
        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message  );
        //        return false;
        //    }
        //}   
        //public List<Sending> loadSendings()
        //{
        //    string path = Path.Combine(_filePath, "sendings.csv");
        //    using var reader = new StreamReader(path);
        //    using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        //    return csv.GetRecords<Sending>().ToList();
        //}   
        //public bool saveSendings(List<Sending> sendings)
        //{
        //    try
        //    {
        //        string path = Path.Combine(_filePath, "sendings.csv");
        //        using var writer = new StreamWriter(path);
        //        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        //        csv.WriteRecords(sendings);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}


    }
}
