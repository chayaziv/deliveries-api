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
    public class GetTest
    {
        DeliveryMenController controller = new DeliveryMenController();
        [Fact]
        public void ReturnOk_get_all()
        {
            var result = controller.Get();

            Assert.Equal(3, result.Value.Count);
            
        }

        [Fact]
        public void ReturnsBadRequest_id_not_exits()
        {
            var id = 9;
            
            var result = controller.Get(id);

            Assert.IsType<NotFoundResult>(result.Result);
        }
        [Fact]
        public void ReturnsOk_id_exits()
        {
            var id = 1;

            var result = controller.Get(id);

            Assert.IsType<OkObjectResult>(result.Result);
        }
    }
}
