using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace _7_4HD
{

    public class ExchangeRateService
    {
        private readonly string apiUrl;
        public string BaseCurrency { get; set; }

        // dictionary to store exchange rates as key value pairs 
        public Dictionary<string, decimal>? Rates { get; private set; } 

        public ExchangeRateService(string baseCurrency)
        {
            BaseCurrency = baseCurrency ?? throw new ArgumentNullException(nameof(baseCurrency));
            apiUrl = $"https://open.er-api.com/v6/latest/{BaseCurrency}";
            Rates = null; // Start as null
        }

        // asynchronous method to fetch exchange rates from the API.
        public async Task FetchRatesAsync()
        {
            // Create an HTTP client for API requests.
            using (HttpClient client = new HttpClient())
            {
                // add neccessary headres for the api call
                client.DefaultRequestHeaders.Add("User-Agent", "CurrencyExchangeApp/1.0");

                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine($"Error fetching rates: {response.StatusCode}");
                        return;
                    }

                    // get the response content.
                    string responseBody = await response.Content.ReadAsStringAsync();
                    // deserialize the JSON response.
                    var rateData = JsonSerializer.Deserialize<ExchangeRateResponse>(responseBody);
                    
                    // Console.WriteLine($"API Response: {responseBody}");
                    
                    // assigne the fetched rates to dictionary Rates
                    if (rateData?.Rates != null)
                    {
                        Rates = rateData.Rates;
                    }
                    else
                    {
                        throw new Exception("Failed to deserialize exchange rates.");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unexpected error: {ex.Message}");
                }
            }
        }

        public decimal GetRate(string targetCurrency)
        {
            // check if rates are fetched first
            if (Rates == null)
            {
                throw new Exception("Exchange rates not loaded. Call FetchRatesAsync() first.");
            }

            // check if the target currency exists in the rates.
            if (Rates.ContainsKey(targetCurrency))
            {
                return Rates[targetCurrency];
            }else
            {
                throw new Exception($"Rate for {targetCurrency} is not available.");
            }
        }

        public void DisplayRates()
        {
            if (Rates == null)
            {
                Console.WriteLine("Exchange rates have not been loaded. Please fetch rates first.");
                return;
            }

            Console.WriteLine($"Base Currency: {BaseCurrency}");
            Console.WriteLine("Available Exchange Rates:");
            // loop and display all the rates
            foreach (var rate in Rates)
            {
                Console.WriteLine($"{rate.Key}: {rate.Value}");
            }
        }

    }

}
