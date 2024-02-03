using Task10.Models;

namespace Task10.Services;

public class BankApiService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly string _apiBaseUrl;

    public BankApiService(IHttpClientFactory httpClientFactory, IConfiguration configuration)
    {
        _httpClientFactory = httpClientFactory;
        _apiBaseUrl = configuration["ApiBaseUrl"];
    }

    public async Task<OperationResult<decimal>> CalculateDepositAsync(DepositModel depositModel)
    {
        try
        {
            var httpClient = _httpClientFactory.CreateClient();
            httpClient.BaseAddress = new Uri(_apiBaseUrl);

            var response = await httpClient.PostAsJsonAsync("api/Bank/CalculateDeposit", depositModel);

            if (!response.IsSuccessStatusCode)
            {
                return OperationResult<decimal>.CreateFailure("Ошибка при выполнении запроса к серверу.");
            }

            return await response.Content.ReadFromJsonAsync<OperationResult<decimal>>();
        }
        catch (Exception)
        {
            return OperationResult<decimal>.CreateFailure("Произошла неожиданная ошибка.");
        }
    }
}