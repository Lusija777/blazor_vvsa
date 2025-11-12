using System.Net.Http.Json;
using blazor_FE.Entities;

namespace blazor_FE.Services;

public class TransactionService
{
    private readonly HttpClient _httpClient;

    public TransactionService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Transaction>?> GetTransactionsAsync()
    {
        return await _httpClient.GetFromJsonAsync<List<Transaction>>("Transaction");
    }

    public async Task<Transaction?> GetTransactionByIdAsync(int id)
    {
        var response = await _httpClient.GetAsync($"Transaction/{id}");

        if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
        {
            return null;
        }
        
        response.EnsureSuccessStatusCode(); 

        return await response.Content.ReadFromJsonAsync<Transaction>();
    }
}