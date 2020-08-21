using MongoDB.Driver;
using MoviePreFSEmaster.DataLayer;
using MoviePreFSEMaster.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace TaskManager.BusinessLayer.Services.Repository
{
    public class MovieRepository : IMovieRepository
    {
        /// <summary>
        /// private references to perform Mongodb operations
        /// </summary>
        private readonly IMongoDBContext _mongoContext;
        private readonly IMongoCollection<MovieManagement> _moviedbCollection;
        private readonly IMongoCollection<MultiplexManagement> _moviedbCollectionMultiplex;

        private readonly IMongoCollection<AllotMovie> _moviedbCollectionAllot;



        ///// <summary>
        /// Inject mongodbcontext object 
        /// </summary>
        /// <param name="mongoDBContext"></param>
        public MovieRepository(IMongoDBContext mongoDBContext)
        {
            _mongoContext = mongoDBContext;
            _moviedbCollection = _mongoContext.GetCollection<MovieManagement>(typeof(MovieManagement).Name);
            _moviedbCollectionMultiplex = _mongoContext.GetCollection<MultiplexManagement>(typeof(MultiplexManagement).Name);
            _moviedbCollectionAllot = _mongoContext.GetCollection<AllotMovie>(typeof(AllotMovie).Name);


        }





        public async Task<string> AddAllot(AllotMovie allotMovie)
        {
            // business logic goes here
            try
            {
                await _moviedbCollectionAllot.InsertOneAsync(allotMovie);
                return "New Movie alloted";

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// MongoDB logic to add new movie  into db 
        /// </summary>
        /// <returns></returns>
        public async Task<string> AddMovieManagement(MovieManagement movieManagement)
        {
            // business logic goes here
            try
            {
                await _moviedbCollection.InsertOneAsync(movieManagement);
                return "New Movie Added";

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// MongoDB logic to add new muliplex  into db 
        /// </summary>
        /// <returns></returns>
        /// 
        public async Task<string> AddMultiplex(MultiplexManagement multiplexManagement)
        {


            // business logic goes here
            try
            {
                await _moviedbCollectionMultiplex.InsertOneAsync(multiplexManagement);
                return "New Multiplex  Added";

            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        /// MongoDB logic to retrieve all Moives present in db
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<MovieManagement>> GetAllMoviesAsync()
        {
            //business logic goes here
            try
            {
                var LstMovie = await _moviedbCollection.FindAsync(FilterDefinition<MovieManagement>.Empty);
                return LstMovie.ToList();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        /// <summary>
        ///  MongoDB logic to retrieve all Alloted movie present in db
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<AllotMovie>> GetAllotMovieAsync()
        {
            try
            {
                var LstMovie = await _moviedbCollectionAllot.FindAsync(FilterDefinition<AllotMovie>.Empty);
                return LstMovie.ToList();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        Task<AllotMovie> IMovieRepository.SearchByAllotMovieIdAsync(string MultiplexID)
        {//Business logic goes here
            throw new NotImplementedException();
        }

      

        Task<MovieManagement> IMovieRepository.SearchByMovieByIdAsync(string MovieId)
        {
            //business logic goes here
            throw new NotImplementedException();
        }

        public async Task<List<MultiplexManagement>> GetAllMultiplexAsync()
        {
            //business logic goes here
            try
            {
                var LstMovie = await _moviedbCollectionMultiplex.FindAsync(FilterDefinition<MultiplexManagement>.Empty);
                return LstMovie.ToList();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        Task<MultiplexManagement> IMovieRepository.SearchByMultiplexIdAsync(string MultiplexID)
        {
            //business logic goes here
            throw new NotImplementedException();
        }

       

       
    }



}