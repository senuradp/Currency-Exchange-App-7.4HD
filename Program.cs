using System;
using System.Threading.Tasks;

namespace _7_4HD
{
    class Program
    {
        // The main method is defined as async to allow asynchronous operations and Task is used to represent the asynchronous operation of the program
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Initializing Currency Exchange Program...");
            var exchangeRateService = new ExchangeRateService("AUD");

            while (true)
            {
                Console.WriteLine("\n--- Currency Exchange Menu ---");
                Console.WriteLine("1. View Exchange Rates");
                Console.WriteLine("2. Convert Currency");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // Check if rates are already fetched
                        if (exchangeRateService.Rates == null)
                        {
                            Console.WriteLine("Fetching exchange rates...");
                            // fetch rates asynchronously
                            await exchangeRateService.FetchRatesAsync();
                        }

                    case "2":
                        // Ensure rates are available for conversion
                        if (exchangeRateService.Rates == null)
                        {
                            Console.WriteLine("Fetching exchange rates...");
                            await exchangeRateService.FetchRatesAsync();
                        }

                        Console.Write("Enter target currency: ");
                        // Convert input to uppercase
                        string targetCurrency = Console.ReadLine()?.ToUpper();
                        // Validate currency input
                        if (string.IsNullOrEmpty(targetCurrency))
                        {
                            Console.WriteLine("Invalid currency entered.");
                            break;
                        }

                        Console.Write("Enter amount in base currency: ");
                        // Read amount from user
                        string input = Console.ReadLine();

                        if (input != null)
                        {
                            try
                            {
                                // Parse the input to decimal
                                decimal amount = decimal.Parse(input);
                                // get exchange rate
                                decimal rate = exchangeRateService.GetRate(targetCurrency);
                                // calculate converted amount
                                decimal convertedAmount = amount * rate;
                                Console.WriteLine($"{amount} {exchangeRateService.BaseCurrency} = {convertedAmount} {targetCurrency}");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid amount entered. Please enter a valid decimal number.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " +ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Input cannot be null.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("Exiting program...");
                        return;

                    default:
                        // handle invalid menu options
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
