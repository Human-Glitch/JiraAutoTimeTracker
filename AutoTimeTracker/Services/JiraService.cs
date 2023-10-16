using System.Text;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net;
using static System.Net.WebRequestMethods;
using AutoTimeTracker.Models;
using System.Text.Json;

namespace AutoTimeTracker.Services
{
    public static class JiraService
    {
        public static string GetToken()
        {
            string userName = "pbx9xtz56n@privaterelay.appleid.com";
            string accessKey = "ATATT3xFfGF08c1SmtbizB24P1QtFDgIYhik1cYo7uzjv0GwK8uEar54E81BeMlvAtR8QqVEmE3UwAmOOJvCgeuGJPCaPOV8QE4ko97qs-jOwt8doMPqR5NWcHJgsDbb_uyt7wfhfYZlD2JeSifpvz3l-RV_dm0VhC690YymeemAEOkEvYKR0WM=89BFFA22";

            return Convert.ToBase64String(Encoding.ASCII.GetBytes($"{userName}:{accessKey}"));
        }

        public static async Task<GetAllBoardsResponse> GetAllBoardsAsync(HttpClient httpClient, string token)
        {
            GetAllBoardsResponse getAllBoardsResponse = new();

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", token);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.GetAsync("https://dritsm.atlassian.net/rest/agile/1.0/board");
            var content = await response.Content.ReadAsStringAsync();

            if(response.StatusCode is HttpStatusCode.OK)
            {
                getAllBoardsResponse = JsonSerializer.Deserialize<GetAllBoardsResponse>(content);
            }
            else
            {
                throw new Exception($"Exception: {content}");
            }

            return getAllBoardsResponse;
        }  

        public static async Task<GetAllSprintsResponse> GetAllSprintsAsync(HttpClient httpClient, string token, int boardId)
        {
            GetAllSprintsResponse getAllSprintsResponse = new();

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", token);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.GetAsync($"https://dritsm.atlassian.net/rest/agile/1.0/board/{boardId}/sprint");
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode is HttpStatusCode.OK)
            {
                getAllSprintsResponse = JsonSerializer.Deserialize<GetAllSprintsResponse>(content);
            }
            else
            {
                throw new Exception($"Exception: {content}");
            }

            return getAllSprintsResponse;
        }

        public static async Task<GetBoardIssuesForSprintResponse> GetBoardIssuesForSprintAsync(HttpClient httpClient, string token, int boardId, int sprintId)
        {
            GetBoardIssuesForSprintResponse getBoardIssuesForSprintResponse = new();

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", token);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = await httpClient.GetAsync($"https://dritsm.atlassian.net/rest/agile/1.0/board/{boardId}/sprint/{sprintId}/issue");
            var content = await response.Content.ReadAsStringAsync();

            if (response.StatusCode is HttpStatusCode.OK)
            {
                getBoardIssuesForSprintResponse = JsonSerializer.Deserialize<GetBoardIssuesForSprintResponse>(content);
            }
            else
            {
                throw new Exception($"Exception: {content}");
            }

            return getBoardIssuesForSprintResponse;
        }
    }
}
