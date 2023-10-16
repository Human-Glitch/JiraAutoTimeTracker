using AutoTimeTracker.Models;
using AutoTimeTracker.Services;
using Microsoft.AspNetCore.Mvc;

namespace AutoTimeTracker.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AutoTimeTrackerController : ControllerBase
    {

        public AutoTimeTrackerController() { }

        [HttpGet(Name = "Generate Time Tracking")]
        public async Task<IActionResult> GenerateTimeTrackingAsync(Employee employee)
        {
            try
            {
                HttpClient httpClient = new();

                string token = JiraService.GetToken();
                GetAllBoardsResponse getAllBoardsResponse = await JiraService.GetAllBoardsAsync(httpClient, token);

                GetAllSprintsResponse getAllSprintsResponse = new();
                if (getAllBoardsResponse is not null)
                {
                    getAllSprintsResponse = await JiraService.GetAllSprintsAsync
                    (
                        httpClient, 
                        token, 
                        getAllBoardsResponse.Values.FirstOrDefault().Id
                    );
                }

                GetBoardIssuesForSprintResponse getBoardIssuesForSprintResponse = new();
                if (getAllSprintsResponse is not null)
                {
                    getBoardIssuesForSprintResponse = await JiraService.GetBoardIssuesForSprintAsync
                    (
                        httpClient,
                        token,
                        getAllBoardsResponse.Values.FirstOrDefault().Id,
                        getAllSprintsResponse.Values.FirstOrDefault().Id
                    );
                }

                return Ok(employee.ToString());
            }
            catch(Exception ex)
            {
                return BadRequest(new {Message = ex.Message, InnerException = ex.InnerException, StackTrace = ex.StackTrace});
            }
        }
    }

    public enum Employee
    {
        KB,
        TS
    }
}