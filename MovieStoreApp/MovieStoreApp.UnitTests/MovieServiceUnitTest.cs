using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieStoreApp.Infrastructure.Service;
using MovieStoreApp.Core.Contract.Repository;
using System.Threading.Tasks;
using System.Collections.Generic;
using MovieStoreApp.Core.Entity;
using Moq;
using MovieStoreApp.Core.Models;

namespace MovieStoreApp.UnitTests
{
    [TestClass]
    public class MovieServiceUnitTest
    {
        private MovieServiceAsync _sut;
        private static List<Movie> _movies;
        private Mock<IMovieRepositoryAsync> mockMovieRepository;

        // Moq class set up
        [ClassInitialize]
        public static void SetUp(TestContext testContext)
        {
            _movies = new List<Movie>
            {
                new Movie{ Id = 1, Title = "Star War", Budget = 100000}
            };

        }

        [TestInitialize]
        //[OneTimeSetup] in nUnit
        //will be called before all test cases
        public void OneTimeSetup()
        {
            mockMovieRepository = new Mock<IMovieRepositoryAsync>();


            //SUT: system under test: MovieService => GetTop10RevenueMoviesAsync

            // Arrange: process of creating mock objects, data, methods etc.
            _sut = new MovieServiceAsync(mockMovieRepository.Object);
            mockMovieRepository.Setup(m => m.GetTop10RevenueMoviesAsync()).ReturnsAsync(_movies);
            
        }

        


        [TestMethod]
        public async Task TestListOfHighestGrossingMoviesFromFakeData()
        {
            //SUT: system under test: MovieService => GetTop10RevenueMoviesAsync

            // Arrange: process of creating mock objects, data, methods etc.
            //_sut = new MovieServiceAsync(new MockMovieRepository());


            // Act
            var movies = await _sut.GetTop10RevenueMoviesAsync();

            // check the actual output with expected data
            // AAA: Arrange, Act, Assert

            // Assert
            Assert.IsNotNull(movies);
            Assert.IsInstanceOfType(movies, typeof(IEnumerable<MovieResponseModel>));
            //Assert.AreEqual(1, movies.Count());


        }
    }

    //not necessary, instead using moq
    public class MockMovieRepository : IMovieRepositoryAsync
    {
        public Task<int> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Movie>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Movie> GetAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetTop10RevenueMoviesAsync()
        {
            //this method will get the fake data
            var _movies = new List<Movie>
            {
                //fake data to test
                //the service method will be directed here since the constructor use this mock class
            };

            return _movies;
        }

        public Task<IEnumerable<Movie>> GetTop3LatestMoviesAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<int> InsertAsync(Movie entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> UpdateAsync(Movie entity)
        {
            throw new System.NotImplementedException();
        }
    }


}