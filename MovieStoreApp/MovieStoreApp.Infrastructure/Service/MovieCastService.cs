using MovieStoreApp.Core.Contract.Repository;
using MovieStoreApp.Core.Contract.Service;
using MovieStoreApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Infrastructure.Service
{
    public class MovieCastService : IMovieCastService
    {
        IMovieCastRepositoryAsync movieCastRepository;
        public MovieCastService(IMovieCastRepositoryAsync _movie)
        {
            movieCastRepository = _movie;
        }
        public async Task<IEnumerable<MovieCastModel>> GetAllByMovieId(int id)
        {
            var result = await movieCastRepository.GetAllByMovieIdAsync(id);
            List<MovieCastModel > list = new List<MovieCastModel>();
            foreach (var entity in result)
            {
                MovieCastModel model = new MovieCastModel();
                model.Id = entity.Id;
                model.CastId = entity.CastId;
                model.Cast = new CastModel() 
                { 
                    Id = entity.Cast.Id, 
                    Gender = entity.Cast.Gender,
                    Name = entity.Cast.Name,
                    ProfilePath = entity.Cast.ProfilePath,
                    TmdbUrl = entity.Cast.TmdbUrl
                };

                list.Add(model);
            }

            return list;
        }
    }
}
