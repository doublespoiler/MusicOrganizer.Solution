using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests 
{
  [TestClass]
  public class SRecordTests : IDisposable
  {
    public void Dispose()
    {
      Category.ClearAll();
    }
    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
    {

    }

  }
}