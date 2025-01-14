﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveriesCompany.Core.Entity;

namespace DeliveriesCompany.Core.Iservices
{
    public interface IDeliveryManService
    {

        public List<DeliveryMan> getall();

        public DeliveryMan getById(int id);

        public DeliveryMan add(DeliveryMan deliveryMan);

        public DeliveryMan update(int id, DeliveryMan deliveryMan);

        public bool delete(int id);
    }
}
