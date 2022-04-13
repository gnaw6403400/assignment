using MovieStoreApp.WebMVC.Models;
namespace MovieStoreApp.WebMVC.Repository
{
    public class MovieRepository
    {
        List<MovieModel> movies;
        public MovieRepository()
        {
            movies = new List<MovieModel>(){
            new MovieModel(){Id=1, PosterUrl="https://static1.srcdn.com/wordpress/wp-content/uploads/2020/12/Vin-Diesel-Fast-and-furious-racing-action.jpg",  Title="Demo1", Duration=165, ReleaseDate= DateTime.Now.AddYears(-5).ToShortDateString(), Description="Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attri" },

            new MovieModel(){Id=2,  PosterUrl="https://static1.srcdn.com/wordpress/wp-content/uploads/2020/12/Vin-Diesel-Fast-and-furious-racing-action.jpg", Title="Fast & furious", Duration=165, ReleaseDate= DateTime.Now.AddYears(-5).ToShortDateString(), Description="Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attri" },

            new MovieModel(){Id=3, Title="Die hard", PosterUrl="https://static1.srcdn.com/wordpress/wp-content/uploads/2020/12/Vin-Diesel-Fast-and-furious-racing-action.jpg"  ,  Duration=165, ReleaseDate= DateTime.Now.AddYears(-5).ToShortDateString(), Description="Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attri" },

            new MovieModel(){Id=4, Title="Harry Potter" , PosterUrl="https://static1.srcdn.com/wordpress/wp-content/uploads/2020/12/Vin-Diesel-Fast-and-furious-racing-action.jpg", Duration=165, ReleaseDate= DateTime.Now.AddYears(-5).ToShortDateString(), Description="Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attri" },

            new MovieModel(){Id=5, Title="Lord of the Ringd", PosterUrl="https://static1.srcdn.com/wordpress/wp-content/uploads/2020/12/Vin-Diesel-Fast-and-furious-racing-action.jpg" , Duration=165, ReleaseDate= DateTime.Now.AddYears(-5).ToShortDateString(), Description="Lorem ipsum, or lipsum as it is sometimes known, is dummy text used in laying out print, graphic or web designs. The passage is attri" },
            };
        }

        public IEnumerable<MovieModel> GetAll()
        {
            return movies;
        }
        public MovieModel GetById(int id)
        {
            return movies.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
