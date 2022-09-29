using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{
    public class SearchController : Controller
    {
      [HttpGet("/search")]
      public ActionResult Index()
      {
        List<Record> recordList = Record.GetAll();
        return View(recordList);
      }

      // [HttpPost("/search")]
      // public ActionResult 

      [HttpGet("/search/{artist}")]
      public ActionResult Show(string artist)
      {
        
        // make list matchSearch 
        // foreach album in the collection 
        //   if album.artist == artist
        //   list.add
        return View();
      }
    }
}