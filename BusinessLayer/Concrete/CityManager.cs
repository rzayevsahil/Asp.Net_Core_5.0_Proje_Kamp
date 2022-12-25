using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CityManager : GenericManager<City>, ICityService
    {
        public CityManager() : base(new EfCityRepository())
        {
        }
    }
}
