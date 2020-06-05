using MicroRabbit.MVC.Models.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public class TransferService : ITransferService
    {
        private readonly HttpClient _apiCient;

        public TransferService(HttpClient apiClient)
        {
            _apiCient = apiClient;
        }
        public async Task Transfer(TransferDto transferDto)
        {
            var uri = "https://localhost:5001/api/banking";
            var transferContent = new StringContent(
                JsonConvert.SerializeObject(transferDto),
                System.Text.Encoding.UTF8,"application/json");

            var response = await _apiCient.PostAsync(uri, transferContent);
            response.EnsureSuccessStatusCode();
        }
    }
}
