using deliveriesCompany.Controllers;
using deliveriesCompany.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.DeliveryMenTests
{
    public class PostTests
    {
        DeliveryMenController controller = new DeliveryMenController();
        [Fact]
        public void ReturnsOKRequest_was_added()
        {
            DeliveryMan newDeliveryMan=new DeliveryMan() { Email="test@gmail.com"};
            var count1 = controller.Get().Value.Count;

            var result=controller.Post(newDeliveryMan);
            var count2 = controller.Get().Value.Count;

            Assert.Equal(count1 + 1, count2);
            Assert.IsType<OkResult>(result);
        }
        [Fact]
        public void ReturnsBadRequest_null() 
        {
            DeliveryMan newDeliveryMan = null;

            var result=controller.Post(newDeliveryMan);

            Assert.IsType<BadRequestResult>(result);

        }
        [Fact]
        public void ReturnsBadRequest_without_email()
        {
            DeliveryMan newDeliveryMan = new DeliveryMan() { Name="test"};

            var result = controller.Post(newDeliveryMan);

            Assert.IsType<BadRequestResult>(result);
        }
        [Fact]

        public void ReturnOk_validId()
        {
            DeliveryMan newDeliveryMan = new DeliveryMan() { Email = "test@gmail.com",IdNumber="215252800" };

            var result = controller.Post(newDeliveryMan);

            Assert.IsType<OkResult>(result);
        }
        public void ReturnsBadRequest_not_validId()
        {
            DeliveryMan newDeliveryMan = new DeliveryMan() { Email = "test@gmail.com", IdNumber = "000000000" };

            var result = controller.Post(newDeliveryMan);

            Assert.IsType<OkResult>(result);
        }

    }
}
