using BLM.DataAccess.ISERVICE;
using BLM.Model;
using BLM_24032024.Models;
using Microsoft.AspNetCore.Hosting;
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
        private readonly IWebHostEnvironment Env;
        private readonly IBookRepository book;
        public BookController(IPublisherRepo publisher,
            IWebHostEnvironment Env,
            IBookRepository book)
        {
            this.publisher = publisher;
            this.Env = Env;
            this.book = book;
        }
        public IActionResult Index(int page = 1)
        {
            //skip = (page-1)*RecordPerPage
           
            var data = book.GetBooks();

            int TotalRecord = data.Count();//18
            int RecordPerPage = 5;
            int TotalPages = (int)Math.Ceiling((double)TotalRecord / RecordPerPage);

            Pager pager = new Pager()
            {
                CurrentPage = page,
                StartPage = Math.Max(1, Math.Min(page - 3, page + 6)),
                EndPage = Math.Min(page + 6, TotalPages),
                TotalPage = TotalPages,
                ControllerName = "Book",
                ActionName = "Index"
            };

            List<BookModel> bookList = data.Skip((page - 1) * RecordPerPage).Take(RecordPerPage).
                                       Select(x => BookModel.Convert(x)).ToList();

            BookListWrapper wrapper = new BookListWrapper()
            {
                Books = bookList,
                PageInfo = pager
            };
            return View(wrapper);
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
            if(model.CoverImage != null)
            {
                string folder = "BookCoverImage";
                string serverFolder = Path.Combine(Env.WebRootPath, folder);
                string FileName = Guid.NewGuid().ToString() + "_" + model.CoverImage.FileName;
                string filePath = Path.Combine(serverFolder, FileName);
                model.CoverImage.CopyTo(new FileStream(filePath, FileMode.Create));

                BookModel bookModel = new BookModel()
                {
                    BookName = model.BookName,
                    NoPages = model.NoPage,
                    Price = model.Price,
                    CoverImagePath = FileName
                };

                book.AddBook(BookModel.Convert(bookModel));
                return RedirectToAction(nameof(Index));
            }

            model.PublisherList = publisher.
                                    GetPublisher.
                                    Select(x => new SelectListItem()
                                    {
                                        Text = x.Name,
                                        Value = x.Id.ToString()
                                    }).ToList();
           
            return View(model);
        }

    }
}
