using AutoMapper;
using DeliveriesCompany.Api.PostModels;
using DeliveriesCompany.Core.EntityDTO;

namespace DeliveriesCompany.Api
{
    public class MappingPostModel:Profile
    {
        public MappingPostModel()
        {
            CreateMap<AgreementPostModel, AgreementDTO>();
            CreateMap<CompanyPostModel, CompanyDTO>();
            CreateMap<DeliveryManPostModel, DeliveryManDTO>();
            CreateMap<SendingPostModel, SendingDTO>();
        }
    }
}
