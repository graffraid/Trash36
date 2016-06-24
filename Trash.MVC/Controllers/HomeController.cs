using System.Web.Mvc;

namespace Trash.MVC.Controllers
{
    using System.Collections.Generic;

    using Trash.Domain.Entities;
    using Trash.Infrastructure.Models;
    using Trash.Repository.Interface;
    using Trash.Repository.Repository;

    public class HomeController : Controller
    {
        private IGenericRepository<VehicleBrand> repository;
        public HomeController()
        {
            repository = new GenericRepository<VehicleBrand>();
        }

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewVehicle()
        {
            var model = AutoMapper.Mapper.Map<List<VehicleBrandModel>>(repository.GetAll());
            return View(model);
        }
    }
}