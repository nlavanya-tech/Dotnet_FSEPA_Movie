using MoviePreFSEMaster.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace TaskManager.BusinessLayer.Interface
{
    public interface IMovieServices
    {
       
        Task<List<String>> GetAllotMovieAsync();
        Task<AllotMovie> SearchByAllotMovieIdAsync(string MultiplexID);
        Task<String> AddAllot(AllotMovie allotMovie);

        Task<List<String>> GetAllMoviesAsync();
        Task<MovieManagement> SearchByMovieByIdAsync(string MovieId);
        Task<String> AddMovieManagement(MovieManagement movieManagement);

        Task<List<MultiplexManagement>> GetAllMultiplexAsync();
        Task<MultiplexManagement> SearchByMultiplexIdAsync(string MultiplexID);

        Task<String> AddMultiplex(MultiplexManagement multiplexManagement);


       
    }
}