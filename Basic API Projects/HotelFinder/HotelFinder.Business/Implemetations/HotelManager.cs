using HotelFinder.Business.İnterfaces;
using HotelFinder.DataAccess.Implementations;
using HotelFinder.DataAccess.Interfaces;
using HotelFinder.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.Business.Implemetations
{
    public class HotelManager : IHotelService
    {
        private readonly IHotelRepository _repository;

        public HotelManager(IHotelRepository repository)
        {
            _repository = repository;
        }
        
        public Hotel CreateHotel(Hotel hotel)
        {
            return _repository.CreateHotel(hotel);
        }

        public void DeleteHotel(int id)
        {
            _repository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotel()
        {
            return _repository.GetAllHotel();
        }

        public Hotel GetById(int id)
        {
            return _repository.GetById(id);
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _repository.UpdateHotel(hotel);
        }
    }
}
