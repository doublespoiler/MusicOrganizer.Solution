using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests 
{
  [TestClass]
  public class RecordTests : IDisposable
  {
    public Record newRecord;
    public string title;  
    public string artist;
    public string genre; 
    public string type; 

    public void Dispose()
    {
      Record.ClearAll();
    }
    [TestInitialize]
    public void TestInitialize()
    {
      title = "Deloused at the Comatorum";
      artist = "The Mars Volta";
      genre = "Prog Rock";
      type = "CD";
      newRecord = new Record(title, artist, genre, type);
    }
    [TestMethod]
    public void RecordConstructor_CreatesInstanceOfRecord_Record()
    {
      Assert.AreEqual(typeof(Record), newRecord.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnTitle_String()
    {
      string result = newRecord.Title;
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetAll_ReturnList_List()
    {
      string titleTwo = "The White Album";
      string artistTwo = "The Beatles";
      string genreTwo = "Classic Rock";
      string typeTwo = "vinyl";
      Record recordTwo = new Record(titleTwo, artistTwo, genreTwo, typeTwo);
      List<Record> newList = new List<Record> { newRecord, recordTwo };
      List<Record> result = Record.GetAll();

      CollectionAssert.AreEqual(newList, result); 
    }

    [TestMethod]
    public void Find_ReturnRecordById_Record()
    {
      Assert.AreEqual(newRecord, Record.Find(1));
    }
  }
}