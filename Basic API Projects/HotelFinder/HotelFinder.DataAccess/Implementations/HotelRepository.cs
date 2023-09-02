using HotelFinder.DataAccess.Interfaces;
using HotelFinder.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelFinder.DataAccess.Implementations
{
    public class HotelRepository : IHotelRepository
    {
        public Hotel CreateHotel(Hotel hotel)
        {
            using(HotelFinderContext context = new HotelFinderContext())
            {
                context.Hotels.Add(hotel);
                context.SaveChanges();
                return hotel;
            }
        }

        public void DeleteHotel(int id)
        {
            using (HotelFinderContext context = new HotelFinderContext())
            {
                var result = context.Hotels.Find(id);
                context.Hotels.Remove(result!);
                context.SaveChanges();
                
            }
        }

        public List<Hotel> GetAllHotel()
        {
            using(HotelFinderContext context = new HotelFinderContext())
            {
                return context.Hotels.ToList();
            }
        }

        public Hotel GetById(int id)
        {
            using (HotelFinderContext context = new HotelFinderContext())
            {
                var result = context.Hotels.Find(id);
                return result!;
            }
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            using (HotelFinderContext context = new HotelFinderContext())
            {
                context.Hotels.Update(hotel);
                context.SaveChanges();
                return hotel;
            }
        }
    }
}
