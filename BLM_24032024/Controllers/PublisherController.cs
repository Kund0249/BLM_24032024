using BLM.DataAccess.EntityModel;
using BLM.DataAccess.ISERVICE;
using BLM.DataAccess.SERVICE;
using BLM.Model;
using Microsoft.AspNetCore.Mvc;


namespace BLM_24032024.Controllers
{
    public class PublisherController : Controller
    {
        private readonly IPublisherRepo publisher;

        public PublisherController(IPublisherRepo _repo)
        {
            // publisher = new PublisherRepo();
            publisher = _repo;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PublisherModel model)
        {
            if (ModelState.IsValid)
            {
                publisher.Add(PublisherModel.Convert(model));

            }
            return View();
        }
    }
}
