using CIS3309_TheatreGroupProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CIS3309_TheatreGroupProject.Tests
{
    [TestClass()]
    public class MovieTests
    {
        [TestMethod()]
        public void MovieTest()
        {
            string title = "Test Movie";
            Movie.Genre genre = Movie.Genre.Comedy;
            string director = "Test Director";
            string rating = "PG-13";
            string description = "This is a test movie.";
            string img = "test.jpg";

            Movie movie1 = new Movie(title, genre, director, rating, description, img);
            Movie movie2 = new Movie(title, genre, director, rating, description, img);
            // TEST OVERALL OBJECT
            Assert.AreNotEqual(movie1, null);
            Assert.AreEqual(movie1, movie2);

            //   TEST FIELDS
            Assert.AreEqual(movie1.Title, title);
            Assert.AreEqual(movie1.Title, title);
            Assert.AreEqual(movie1.MovieGenre, genre);
            Assert.AreEqual(movie1.Director, director);
            Assert.AreEqual(movie1.Rating, rating);
            Assert.AreEqual(movie1.Description, description);
            Assert.AreEqual(movie1.Img, img);

            // TEST CHANGES TO FIELD
            movie1.Title = "Terminator";
            Assert.AreNotEqual(movie1.Title, title);
            Assert.AreEqual(movie1.Title, "Terminator");
        }

        [TestMethod()]
        public void GetGenreArrayTest()
        {
            //GENRE ENUMS: public enum Genre { Horror, Thriller, History, Action, Romance, Comedy, SciFi }


            // CREATE ARRAY OF GENRES 
            Array array = Enum.GetValues(typeof(Movie.Genre));

            Assert.IsNotNull(array);


            Assert.AreEqual(7, array.Length);

            // CHECK CONTENTS 
            Movie.Genre genre0 = (Movie.Genre)array.GetValue(0);
            Assert.AreEqual(Movie.Genre.Horror, genre0);

            Movie.Genre genre1 = (Movie.Genre)array.GetValue(1);
            Assert.AreEqual(Movie.Genre.Thriller, genre1);

            Movie.Genre genre2 = (Movie.Genre)array.GetValue(2);
            Assert.AreEqual(Movie.Genre.History, genre2);

            Movie.Genre genre3 = (Movie.Genre)array.GetValue(3);
            Assert.AreEqual(Movie.Genre.Action, genre3);

            Movie.Genre genre4 = (Movie.Genre)array.GetValue(4);
            Assert.AreEqual(Movie.Genre.Romance, genre4);

            Movie.Genre genre5 = (Movie.Genre)array.GetValue(5);
            Assert.AreEqual(Movie.Genre.Comedy, genre5);

            Movie.Genre genre6 = (Movie.Genre)array.GetValue(6);
            Assert.AreEqual(Movie.Genre.SciFi, genre6);
        }
    }
}