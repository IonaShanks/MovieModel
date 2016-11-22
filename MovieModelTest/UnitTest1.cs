using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieModel;

namespace MovieModelTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MovieListing m1 = new MovieListing() {FilmID = "HP1", Title = "Harry potter 1", Certification = Certification.PG, Description = "fjeiejfij" , Genre = "Fantasy", RunTime = 198 };

            Console.WriteLine(m1);
        }
    }
}
