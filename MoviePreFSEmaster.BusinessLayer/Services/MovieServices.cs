using MongoDB.Driver;
using MoviePreFSEMaster.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TaskManager.BusinessLayer.Interface;
using TaskManager.BusinessLayer.Services.Repository;


namespace TaskManager.BusinessLayer.Services
{
    public class MovieServices : IMovieServices
    {
        /// <summary>
        /// reference of type IMovieRepository
        /// </summary>
        private readonly IMovieRepository _taskRepository;

        /// <summary>
        /// Injecting object of type MovieRepository to access it's methods
        /// </summary>
        /// <param name="taskRepository"></param>
        /// 
        

       
        public MovieServices(IMovieRepository taskRepository)
        {

            _taskRepository = taskRepository;
        }

        public async Task<string> AddAllot(AllotMovie allotMovie)
        {
            try
            {
                var result = await _taskRepository.AddAllot(allotMovie);
                return result;
            }
            catch(Exception exception)
            {
                throw exception;
            }
            
        }

        public async Task<string> AddMovieManagement(MovieManagement movieManagement)
        {
            try
            {
                var result = await _taskRepository.AddMovieManagement(movieManagement);
                return result;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public async Task<string> AddMultiplex(MultiplexManagement multiplexManagement)
        {
            try
            {
                var result = await _taskRepository.AddMultiplex(multiplexManagement);
                return result;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
       
        /// <summary>
        /// Call method to retrieve all movies present in db
        /// </summary>
        /// <returns></returns>
        public async Task<List<string>> GetAllMoviesAsync()
        {
            try
            {
                var LstTask = await _taskRepository.GetAllMoviesAsync();
                return LstTask;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// Call method to retrieve all multiplex details in db
        /// </summary>
        /// <returns></returns>

        public async Task<List<MultiplexManagement>> GetAllMultiplexAsync()
        {
            try
            {
                var LstMultip = await _taskRepository.GetAllMultiplexAsync();
                return LstMultip;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
        /// <summary>
        /// Call method to retrieve all alloted movies present in db
        /// </summary>
        /// <returns></returns>

        public async Task<List<string>> GetAllotMovieAsync()
        {
            try
            {
                var LastAllot = await _taskRepository.GetAllotMovieAsync();
                return LastAllot;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        Task<AllotMovie> IMovieServices.SearchByAllotMovieIdAsync(string MultiplexID)
        {
            //Business Logic here
            throw new NotImplementedException();
        }

        Task<MovieManagement> IMovieServices.SearchByMovieByIdAsync(string MovieId)
        {
            //Business Logic here
            throw new NotImplementedException();
        }

        Task<MultiplexManagement> IMovieServices.SearchByMultiplexIdAsync(string MultiplexID)
        {
            throw new NotImplementedException();
        }

       


    }
}
