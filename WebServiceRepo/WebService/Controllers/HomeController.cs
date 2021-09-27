using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebService.Models.Entities;
using WebService.Models.Interfaces;

namespace WebService.Controllers
{
    public class HomeController : Controller
    {
        IOrganisationRepository<Organisation> organisationRepository = new FakeDbOrganisationRepository();
        // GET: Home
        public ViewResult Index()
        {
            return View(organisationRepository.GetAll());
        }

        public ActionResult Create(Organisation organisation) 
        {
            organisationRepository.Create(organisation);
            return View("Index");
        }
    }
}