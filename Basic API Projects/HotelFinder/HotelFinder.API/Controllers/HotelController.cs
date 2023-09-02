using HotelFinder.Business.Implemetations;
using HotelFinder.Business.İnterfaces;
using HotelFinder.Model.Entity;
using Microsoft.AspNetCore.Mvc;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;
        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        [HttpGet]
        public List<Hotel> Get()
        {
            return _hotelService.GetAllHotel();
        }

        [HttpGet("{id}")]
        public Hotel GetById(int id) 
        {
            return _hotelService.GetById(id);
        }

        [HttpPost]
        public Hotel Post([FromBody]Hotel hotel) 
        {
            return _hotelService.CreateHotel(hotel);
        }

        [HttpPut]
        public Hotel Put([FromBody]Hotel hotel) 
        {
            return _hotelService.UpdateHotel(hotel);
        }

        [HttpDelete("{id}")]
        public void Delete(int id) 
        {
            _hotelService.DeleteHotel(id);
        }
    }
}
