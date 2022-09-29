using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
    public class RecordController : Controller
    {
      [HttpGet("/record")] 
      public ActionResult Index() //shows all records
      {
        return View();
      }

      [HttpGet("/record/new")]
      public ActionResult New()
      {
        return View();
      }

      [HttpPost("/record")]
      public ActionResult Create(string title, string artist, string genre, string type)
      {
        Record newRecord = new Record(title, artist, genre, type);
        return RedirectToAction("Index");
      }
    }
}