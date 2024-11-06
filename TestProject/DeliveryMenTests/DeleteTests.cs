using deliveriesCompany.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.DeliveryMenTests
{
    public class DeleteTests
    {

        DeliveryMenController controller = new DeliveryMenController();
        [Fact]
        public void ReturnsBadRequest_not_exit()
        {
            var id = 6;
            
            var result = controller.Delete(id);

            Assert.IsType<BadRequestResult>(result);
        }
        [Fact]
        public void ReturnsBadRequest_not_valid()
        {
            var id = 1;
            
            var result = controller.Delete(id);

            Assert.IsType<BadRequestResult>(result);
        }
        [Fact]
        public void Returns_OKRequest()
        {
            var id = 3;

            var result = controller.Delete(id);

            Assert.IsType<OkResult>(result);
        }
    }
}
