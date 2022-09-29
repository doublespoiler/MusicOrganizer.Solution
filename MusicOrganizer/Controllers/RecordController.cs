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
        List<Record> allRecords = Record.GetAll();
        return View(allRecords);
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

      [HttpGet("/record/{id}")]
      public ActionResult Show(int id)
      {
        Record foundRecord = Record.Find(id);
        return View(foundRecord);
      }

      [HttpGet("/record/{id}/edit")]
      public ActionResult Edit(int id)
      {
        Record foundRecord = Record.Find(id);
        return View(foundRecord);
      }

      [HttpPost("/record/{id}")]
      public ActionResult Update(int id, string title, string artist, string genre, string type, List<Song> songs)
      {
        Record toUpdate = Record.Find(id);
        toUpdate.Title = title;
        toUpdate.Artist = artist;
        toUpdate.Genre = genre;
        toUpdate.Type = type.ToUpper();
        toUpdate.Songs = songs;
        return RedirectToAction("Show", new {id = id});
      }
    }
}