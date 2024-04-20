using BLM.DataAccess.ISERVICE;
using BLM_24032024.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BLM_24032024.Controllers
{
    public class BookController : Controller
    {
        private readonly IPublisherRepo publisher;
        public BookController(IPublisherRepo publisher)
        {
            this.publisher = publisher;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            BookCreateModel model = new BookCreateModel()
            {
                PublisherList = publisher.
                                GetPublisher.
                                Select(x => new SelectListItem()
                                {
                                    Text = x.Name,
                                    Value = x.Id.ToString()
                                }).ToList()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Create(BookCreateModel model)
        {
            //model.CoverImage.CopyTo(new FileStream("", FileMode.Create));
            return View();
        }

    }
}
