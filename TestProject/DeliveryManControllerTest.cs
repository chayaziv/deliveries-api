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
        public void Delete_ReturnsBadRequest()
        {
            var id = 6;
            var controller = new DeliveryMenController();

            var result = controller.Delete(id);

            Assert.IsType<BadRequestObjectResult>(result);
        }


    }
}
