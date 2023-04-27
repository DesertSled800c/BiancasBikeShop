using BiancasBikeShop.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BiancasBikeShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BikeController : ControllerBase
    {
        private IBikeRepository _bikeRepo;

        public BikeController(IBikeRepository bikeRepo)
        {
            _bikeRepo = bikeRepo;
        }

        //Uncomment this and finish these controller methods...


        public IActionResult Get()
        {
            // add implementation here... 
            return Ok();
        }


        public IActionResult Get(int id)
        {
            //add implementation here... 
            return Ok();
        }


        public IActionResult GetBikesInShopCount()
        {
            //add implementation here...

            return Ok();
        }
    }
}
