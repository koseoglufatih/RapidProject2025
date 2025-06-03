using HotelProject.WebUI.Dtos.FollowersDto;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace HotelProject.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<ResultInstagramFollowersDto> resultInstagramFollowersDtos = new List<ResultInstagramFollowersDto>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofile/therock"),
                Headers =
        {
            { "x-rapidapi-key", "bae831392fmsh0ffd6d0fe3f4810p126e8ejsn23f3a237b4d7" },
            { "x-rapidapi-host", "instagram-profile1.p.rapidapi.com" },
        },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                resultInstagramFollowersDtos = JsonConvert.DeserializeObject<List<ResultInstagramFollowersDto>>(body);
                return View(resultInstagramFollowersDtos);
            }
        }
    }
}
