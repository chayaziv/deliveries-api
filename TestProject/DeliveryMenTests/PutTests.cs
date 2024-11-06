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
    public class PutTests
    {
        DeliveryMenController controller = new DeliveryMenController();
        [Fact]
        public void ReturnsBadRequest_not_exit()
        {
            var id = 9;
            DeliveryMan deliveryMan = new DeliveryMan() {Email="dlv@gmail.com" };

            var res = controller.Put(id, deliveryMan);

            Assert.IsType<NotFoundResult>(res);
        }

        [Fact]
        public void Update_Email()
        {
            var id = 1;
            var newEmail = "test2@gmail.com";
            DeliveryMan deliveryMan = new DeliveryMan() { Email = newEmail };

            var res = controller.Put(id, deliveryMan);
            var actual= ManagerDataContext.DataContex.deliveryMenList.Where(x => x.Id == id).FirstOrDefault().Email;
            Assert.Equal(newEmail, actual);
        }

    }
}
