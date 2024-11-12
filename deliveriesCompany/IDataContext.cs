using deliveriesCompany.Entities;

namespace deliveriesCompany
{
    public interface IDataContext
    {
        public List<DeliveryMan> loadDeliveryMen();
        public bool saveDeliveryMen(List<DeliveryMan> deliveryMen);

        #region all classes
        /*
        public List<Agreement> loadAgreements();
        public bool saveAgreements(List<Agreement> agreements);

        public List<Company> loadCompanies();
        public bool saveCompanies(List<Company> companies);

       
        public List<Sending> loadSendings();
        public bool saveSending(List<Sending> sendings);
        */
        #endregion
    }
}
