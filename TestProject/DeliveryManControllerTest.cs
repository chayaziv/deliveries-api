using deliveriesCompany.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class DeliveryManControllerTest
    {
        
        [Fact]
        public void Delete_ReturnsBadRequest_not_exit()
        {
            var id = 6;
            var controller = new DeliveryMenController();

            var result = controller.Delete(id);
            
            Assert.IsType<BadRequestResult>(result);
        }
        [Fact]
        public void Delete_ReturnsBadRequest_not_valid()
        {
            var id = 1;
            var controller = new DeliveryMenController();

            var result = controller.Delete(id);

            Assert.IsType<BadRequestResult>(result);
        }
        [Fact]
        public void Delete_Returns_OKRequest()
        {
            var id = 3;
            var controller = new DeliveryMenController();

            var result = controller.Delete(id);

            //Assert.IsType<BadRequestObjectResult>(result);
            Assert.IsType<OkResult>(result);
        }
    }
}
