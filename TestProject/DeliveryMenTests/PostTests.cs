using deliveriesCompany.Controllers;
using deliveriesCompany.Entities;
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
        public void test1()
        {
            DeliveryMan newDeliveryMan=new DeliveryMan() { Email="test@gmail.com"};
            var count1 = controller.Get().Value.Count;

            var res=controller.Post(newDeliveryMan);
            var count2 = controller.Get().Value.Count;

            Assert.Equal(count1 + 1, count2);
        }
    }
}
