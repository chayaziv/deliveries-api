using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DeliveriesCompany.Core.Entity;
using DeliveriesCompany.Core.EntityDTO;

namespace DeliveriesCompany.Core
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Agreement,AgreementDTO>().ReverseMap();
            CreateMap<Company,CompanyDTO>().ReverseMap();
            CreateMap<DeliveryMan,DeliveryManDTO>().ReverseMap();   
            CreateMap<Sending,SendingDTO>().ReverseMap();
        }
    }
}
