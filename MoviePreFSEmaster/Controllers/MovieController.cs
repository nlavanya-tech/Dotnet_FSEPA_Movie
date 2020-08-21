using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using MoviePreFSEMaster.Entities;
using TaskManager.BusinessLayer.Interface;

namespace TaskManager.Service.Controllers
{

    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieServices _taskService;
        public MovieController(IMovieServices taskService)
        {
            _taskService = taskService;
        }

        [Route("api/AllotMovie/AddAllot")]
        [HttpPost]
        public async Task<ActionResult<String>> AddAllot(AllotMovie newallot)
        {
            try
            {
                var result = await _taskService.AddAllot(newallot);
                return result;
            }
            catch (Exception exception)
            {
                return BadRequest(exception.ToString());
            }

        }

        [Route("api/Movie/AddMovieManagement")]
        [HttpPost]
        public async Task<ActionResult<String>> AddMovieManagement(MovieManagement movieManagement)
        {
            try
            {
                var resultGroup = await _taskService.AddMovieManagement(movieManagement);
                return resultGroup;

            }
            catch (Exception exception)
            {
                return BadRequest(exception.ToString());
            }

        }
        [Route("api/Movie/AddMultiplex")]
        [HttpPost]
        public async Task<ActionResult<String>> AddMultiplex(MultiplexManagement multiplexManagement)
        {
            try
            {
                var resultGroup = await _taskService.AddMultiplex(multiplexManagement);
                return resultGroup;

            }
            catch (Exception exception)
            {
                return BadRequest(exception.ToString());
            }

        }



        [Route("api/Movie/GetAllotMovieAsync")]
        [HttpPost]
        public async Task<ActionResult<List<AllotMovie>>> GetAllotMovieAsync()
        {
            try
            {
                var resultLstTask = await _taskService.GetAllotMovieAsync();
                return resultLstTask;
            }
            catch (Exception exception)
            {
                return BadRequest(exception.ToString());
            }

            [Route("api/Movie/GetAllMoviesAsync")]
            [HttpPost]
            public async Task<ActionResult<List<MovieManagement>>> GetAllMoviesAsync()
            {
                try
                {
                    var resultLstTask = await _taskService.GetAllMoviesAsync();
                    return resultLstTask;
                }
                catch (Exception exception)
                {
                    return BadRequest(exception.ToString());
                }



            }
        }
    }
}