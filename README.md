# Task 7.4 HD | SIT771 | CurrencyExchangeApp Tutorial | S224750485 - Senura Perera

This tutorial will guide you through creating a **Currency Exchange Application** using .NET, SplashKit, and C#. The steps are detailed to ensure even absolute beginners can follow along.

---

## Step 1: Install .NET SDK

### Why?
You need the `.NET SDK` to develop, build, and run C# applications.

### Instructions:
1. **Download the .NET SDK:**
   - Visit [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download).
   - Download the latest version for your operating system (Windows, macOS, or Linux).

2. **Install the .NET SDK:**
   - Run the downloaded installer and follow the on-screen instructions.

3. **Verify the Installation:**
   - Open your terminal or command prompt.
   - Run the command:
     ```
     dotnet --version
     ```
   - You should see the installed version, such as `7.0.x`.

---

## Step 2: Install SplashKit Manager (SKM)

### Why?
`skm` simplifies creating and managing projects that use SplashKit.

### Instructions:
   - Visit [https://splashkit.io/installation/macos/step-2/](https://splashkit.io/installation/macos/step-2/).
   - Follow the installation steps for your operating system (Windows, macOS, or Linux).


### Run the SplashKit Installer

Open your Terminal and paste the following command to download and install SplashKit:

```bash
bash <(curl -s https://raw.githubusercontent.com/splashkit/skm/master/install-scripts/skm-install.sh)
```

This command downloads the installer directly from the SplashKit homepage.

---

### Verify the Installation

Restart your Terminal to ensure the new installation path is recognized. Then, enter the following command to check if SplashKit Manager (skm) is installed:

```bash
skm
```

You should see a message confirming the installation:

```plaintext
SplashKit is installed successfully!
Missing skm command. For help, use 'skm help'
```

**Tip:** Use `skm help` to explore additional commands for managing SplashKit.

---

###Install Dependencies and Compile SplashKit

To install any necessary dependencies and compile SplashKit, use:

```bash
skm macos install
```

---

### Install SplashKit Globally

For easier access, install SplashKit globally by running:

```bash
skm global install
```

---

## Step 3: Create a New SplashKit Console Project

### Why?
Use `skm dotnet` commands to create a new project preconfigured for SplashKit.

### Instructions:
1. **Create the Project:**
   - Run this command:
     ```
     skm dotnet new console CurrencyExchangeApp
     ```
   - **What This Does:**
     - Creates a new project folder named `CurrencyExchangeApp`.
     - Preconfigures the project to use SplashKit.

2. **Navigate to Your Project:**
   - Move into the newly created project folder:
     ```
     cd CurrencyExchangeApp
     ```

---

## Step 4: Restore SplashKit Dependencies

### Why?
Restoring ensures all necessary SplashKit files and libraries are downloaded and ready to use.

### Instructions:
1. **Restore Dependencies:**
   - Run the following command:
     ```
     skm dotnet restore
     ```

2. **What This Does:**
   - Downloads any missing dependencies.
   - Ensures the project is ready for building and running.

---

## Step 5: Start with the Basics

### Concept:
Every C# program requires a **Main method**, which is the entry point for execution. This is where the program begins running. We’ll use this method to create the program’s foundational structure.

### Sub-Step 5.1: Open the Project
1. Navigate to the project folder:
   ```
   cd CurrencyExchangeApp
   ```
2. Open the `Program.cs` file in your favorite code editor (e.g., Visual Studio, Visual Studio Code).

### Sub-Step 5.2: Include System Namespace
- **Why?** The **System namespace** gives access to essential C# tools like `Console` for input and output.
- **How to Add:** At the top of `Program.cs`, ensure the line:
  ```csharp
  using System;
  ```
  is present.

### Sub-Step 5.3: Define a Namespace
- **Why?** Namespaces organize your code and prevent naming conflicts between classes.
- **How to Add:** Wrap your program logic in a `namespace`, such as `CurrencyExchangeApp`:
  ```csharp
  namespace CurrencyExchangeApp
  {
  }
  ```

### Sub-Step 5.4: Add the Main Method
1. Inside your namespace, define a `Program` class:
   ```csharp
   class Program
   {
   }
   ```
2. Inside the class, add the `Main` method:
   ```csharp
   static void Main(string[] args)
   {
   }
   ```
   - **Why `static`?** The Main method must be static because it runs without creating an object of the `Program` class.
   - **Why `void`?** It means this method does not return any value.

### Sub-Step 5.5: Print a Welcome Message
1. Inside the `Main` method, use the `Console.WriteLine` method to display a message:
   ```csharp
   Console.WriteLine("Welcome to the Currency Exchange Program!");
   ```
2. Save and run the program:
   ```
   skm dotnet run
   ```
   **Output:**
   ```
   Welcome to the Currency Exchange Program!
   ```

### Key Takeaways from Step 5:
1. The **Main method** is the starting point for all C# programs.
2. The **Console.WriteLine** method allows you to display messages to the user.
3. **Namespaces** organize your code, making it reusable and avoiding conflicts.

---

## Step 6: Adding a Menu to Your Currency Converter Program

### Purpose:
Menus make programs interactive and user-friendly. In this step, we’ll build a menu system that runs continuously until the user decides to exit. Each menu option will perform a specific task.

### Sub-Step 6.1: Create the Menu Structure
1. **Set up the loop**:
   Use a `while (true)` loop to keep the menu running until the user decides to exit.
   ```csharp
   while (true)
   {
   }
   ```
2. **Display menu options**:
   Add three menu options inside the loop using `Console.WriteLine`.
   ```csharp
   Console.WriteLine("\n--- Currency Exchange Menu ---");
   Console.WriteLine("1. View Exchange Rates");
   Console.WriteLine("2. Convert Currency");
   Console.WriteLine("3. Exit");
   ```
3. **Prompt for user input**:
   Capture the user’s choice using `Console.ReadLine`.
   ```csharp
   Console.Write("Enter your choice: ");
   string choice = Console.ReadLine();
   ```

### Sub-Step 6.2: Handle Choices with a Switch Statement
1. **Use a switch statement**:
   Add a switch statement to process the user’s input.
   ```csharp
   switch (choice)
   {
       case "1":
           Console.WriteLine("Viewing exchange rates...");
           break;
       case "2":
           Console.WriteLine("Converting currency...");
           break;
       case "3":
           Console.WriteLine("Exiting the program...");
           return;
       default:
           Console.WriteLine("Invalid choice. Please try again.");
           break;
   }
   ```

### Sub-Step 6.3: Test the Program
1. Save your file and run the program:
   ```
   skm dotnet run
   ```
2. Test with different inputs:
   - **Input 1**: Should display "Viewing exchange rates...".
   - **Input 2**: Should display "Converting currency...".
   - **Input 3**: Should display "Exiting the program..." and end the program.
   - **Any other input**: Should display "Invalid choice. Please try again.".

### Key Takeaways from Step 6:
1. The **while loop** ensures the program keeps running until the user chooses to exit.
2. The **switch statement** efficiently handles different choices based on user input.
3. Input validation ensures invalid inputs are handled properly.

---

## Quick Fact :  Understanding APIs & API Keys before moving on to the next step

## What is an API?
An **API (Application Programming Interface)** allows two software applications to communicate.

It enables us to fetch real-time data, like exchange rates, weather, or stock prices, from a remote server.

In this **Currency Exchange App**, we use an **Exchange Rate API** to retrieve currency exchange rates.

---

## How Does an API Work?

APIs work using **HTTP requests** to communicate with servers. A request is sent to a **specific URL (endpoint)**, and the server responds with data in **JSON format**.

### Example API Request:

When our app calls:

```bash
GET https://open.er-api.com/v6/latest/AUD
```

The API responds with JSON than ooks like this:

```json
{
    "base_code": "AUD",
    "rates": {
        "USD": 0.66,
        "EUR": 0.62,
        "LKR": 190.45
    },
    "time_last_update_utc": "Fri, 31 Jan 2025 10:00:00 UTC"
}
```

---

## What is an API Key? Why is it Important?

- Some APIs require **authentication** using an **API key**.
- An **API key is a unique identifier** that ensures only authorized users can access the API.
- Free APIs may have **limits on the number of requests per day**.

### Example API Request with a Key:

```bash
GET https://open.er-api.com/v6/latest/AUD?apikey=YOUR_API_KEY
```

---

## How to Secure API Keys?
**Never hardcode API keys in your source code!**

### Bad Practice: (DO NOT do this!)

```csharp
string apiKey = "my-secret-key"; 
string url = $"https://open.er-api.com/v6/latest/AUD?apikey={apiKey}";
```

**Why?** Because if you commit this to version control platform (Github, GitLab, BitBucket), anyone can steal your API key!

### Best Practices:

#### 1. Use **Environment Variables** (`.env` file)
- Store the key securely and load it dynamically.

#### 2. Use `appsettings.json` as per standard practice in .NET C#
Create a configuration file:

```json
{
    "ExchangeRateAPI": {
        "BaseUrl": "https://open.er-api.com/v6/latest/",
        "ApiKey": "YOUR_SECRET_KEY"
    }
}
```

Then, **load it in**:

```csharp
var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

string apiKey = config["ExchangeRateAPI:ApiKey"];
```

This ensures **security and flexibility** when managing API keys.

---

**By following these best practices, you can ensure that your application is secure, scalable, and ready for real-world deployment!**

---

## Step 7: Add a Response Class to Handle the API Response


## `ExchangeRateResponse` Class

The `ExchangeRateResponse` class is used to map the JSON response from the external API to C# properties. The properties of this class correspond to the JSON fields returned by the API. The class uses the `System.Text.Json.Serialization.JsonPropertyName` attribute to map the JSON property names to C# property names.

The api "https://open.er-api.com/v6/latest/" we will be using is the free api provided by [![Exchange Rate API](https://www.exchangerate-api.com/img/hr-logo-2022-ldpi-rc.png "Exchange Rate API")](https://www.exchangerate-api.com/ "ExchangeRate-API")  

> Fun fact : If you paste this link in you browser you will be able to see the sample output of the api.

### Properties

1. **Base**:
   - **JSON Field**: `base_code`
   - **Description**: Represents the base currency code used for fetching exchange rates.
   - **Type**: `string?`
   ```csharp
   [JsonPropertyName("base_code")]
   public string? Base { get; set; }
   ```

2. **Rates**:
   - **JSON Field**: `rates`
   - **Description**: A dictionary containing currency codes as keys and their corresponding exchange rates as values.
   - **Type**: `Dictionary<string, decimal>?`
   ```csharp
   [JsonPropertyName("rates")]
   public Dictionary<string, decimal>? Rates { get; set; }
   ```

3. **Result**:
   - **JSON Field**: `result`
   - **Description**: The result status of the API request.
   - **Type**: `string?`
   ```csharp
   [JsonPropertyName("result")]
   public string? Result { get; set; }
   ```

4. **LastUpdateUtc**:
   - **JSON Field**: `time_last_update_utc`
   - **Description**: The timestamp for the last update of the exchange rates (UTC).
   - **Type**: `string?`
   ```csharp
   [JsonPropertyName("time_last_update_utc")]
   public string? LastUpdateUtc { get; set; }
   ```

5. **NextUpdateUtc**:
   - **JSON Field**: `time_next_update_utc`
   - **Description**: The timestamp for when the next update of the exchange rates will occur (UTC).
   - **Type**: `string?`
   ```csharp
   [JsonPropertyName("time_next_update_utc")]
   public string? NextUpdateUtc { get; set; }
   ```

The `ExchangeRateResponse` class ensures that the API response can be properly parsed and the relevant data can be extracted into usable C# properties.

This section explains the purpose of each property in the `ExchangeRateResponse` class and shows how to use it in the context of your service.

---

## Step 8: Add a Service to Handle Exchange Rates

The exchange rate service class includes , fetching rates asynchronously, retrieving a specific rate, and displaying all available exchange rates.

## Overview

The main components of this service include:
1. **Constructor (ExchangeRateService)**
2. **FetchRatesAsync Method**
3. **GetRate Method**
4. **DisplayRates Method**

### Constructor (ExchangeRateService)

#### Purpose:
Initialize the object with the base currency and construct the API URL.

#### Steps:
1. **Accept Base Currency**:
   The constructor takes a `baseCurrency` argument (e.g., USD or EUR).
   Example: 
   ```csharp
   BaseCurrency = baseCurrency;
   ```
   If the `baseCurrency` is `null`, throw an exception to prevent further issues:
   ```csharp
   BaseCurrency = baseCurrency ?? throw new ArgumentNullException(nameof(baseCurrency));
   ```

2. **Construct the API URL**:
   Construct the URL for fetching exchange rates from the API using the base currency:
   ```csharp
   apiUrl = $"https://open.er-api.com/v6/latest/{BaseCurrency}";
   ```

3. **Initialize Rates**:
   Set the `Rates` to `null` to indicate that exchange rates haven't been fetched yet:
   ```csharp
   Rates = null;
   ```

### `FetchRatesAsync` Method

#### Purpose:
Fetch exchange rates from the external API asynchronously and store the results in the `Rates` dictionary.

#### Steps:
1. **Initialize HttpClient**:
   Create a new instance of `HttpClient` inside a `using` block to ensure proper disposal after the method finishes:
   ```csharp
   using (HttpClient client = new HttpClient())
   ```

2. **Set Headers**:
   Add necessary HTTP headers like `User-Agent` to comply with the API request policies:
   ```csharp
   client.DefaultRequestHeaders.Add("User-Agent", "CurrencyExchangeApp/1.0");
   ```

3. **Make API Request**:
   Use the `GetAsync` method to send a `GET` request to the API URL:
   ```csharp
   HttpResponseMessage response = await client.GetAsync(apiUrl);
   ```

4. **Check for Success**:
   Check if the response was successful by examining the `IsSuccessStatusCode` property. If not, log the error:
   ```csharp
   if (!response.IsSuccessStatusCode)
   {
       Console.WriteLine($"Error fetching rates: {response.StatusCode}");
       return;
   }
   ```

5. **Read Response Content**:
   Read the response body asynchronously using `ReadAsStringAsync`:
   ```csharp
   string responseBody = await response.Content.ReadAsStringAsync();
   ```

6. **Deserialize JSON Response**:
   Deserialize the JSON response into an `ExchangeRateResponse` object using `JsonSerializer.Deserialize`:
   ```csharp
   var rateData = JsonSerializer.Deserialize<ExchangeRateResponse>(responseBody);
   ```

7. **Store Rates**:
   If the `Rates` property is not null, store the exchange rates in the `Rates` dictionary. If rates are missing or deserialization fails, throw an exception:
   ```csharp
   if (rateData?.Rates != null)
   {
       Rates = rateData.Rates;
   }
   else
   {
       throw new Exception("Failed to deserialize exchange rates.");
   }
   ```

8. **Error Handling**:
   Catch and log any unexpected errors that occur during the API request or deserialization process:
   ```csharp
   catch (Exception ex)
   {
       Console.WriteLine($"Unexpected error: {ex.Message}");
   }
   ```

### `GetRate` Method

#### Purpose:
Retrieve the exchange rate for a specific target currency from the stored rates.

#### Steps:
1. **Check if Rates are Loaded**:
   If `Rates` is `null`, it means exchange rates have not been fetched. Throw an exception:
   ```csharp
   if (Rates == null)
   {
       throw new Exception("Exchange rates not loaded. Call FetchRatesAsync() first.");
   }
   ```

2. **Check if Target Currency Exists**:
   Verify if the target currency exists in the `Rates` dictionary. If it does, return the rate:
   ```csharp
   if (Rates.ContainsKey(targetCurrency))
   {
       return Rates[targetCurrency];
   }
   ```

3. **Handle Missing Currency**:
   If the target currency is not available in the `Rates` dictionary, throw an exception:
   ```csharp
   else
   {
       throw new Exception($"Rate for {targetCurrency} is not available.");
   }
   ```

### `DisplayRates` Method

#### Purpose:
Display all available exchange rates and the base currency.

#### Steps:
1. **Check if Rates are Loaded**:
   If `Rates` is `null`, print a message indicating that the exchange rates haven't been fetched:
   ```csharp
   if (Rates == null)
   {
       Console.WriteLine("Exchange rates have not been loaded. Please fetch rates first.");
       return;
   }
   ```

2. **Display Base Currency**:
   Print the base currency used for fetching the exchange rates:
   ```csharp
   Console.WriteLine($"Base Currency: {BaseCurrency}");
   ```

3. **Display Rates**:
   Loop through the `Rates` dictionary and print each currency and its corresponding exchange rate:
   ```csharp
   foreach (var rate in Rates)
   {
       Console.WriteLine($"{rate.Key}: {rate.Value}");
   }
   ```

## How to Use

1. **Create an instance of `ExchangeRateService`** with the desired base currency:
   ```
   var exchangeService = new ExchangeRateService("AUD");
   ```

2. **Fetch exchange rates**:
   ```
   await exchangeService.FetchRatesAsync();
   ```

3. **Get the exchange rate for a specific currency**:
   ```
   decimal rate = exchangeService.GetRate("LKR");
   Console.WriteLine($"Exchange rate for EUR: {rate}");
   ```

4. **Display all rates**:
   ```
   exchangeService.DisplayRates();
   ```


## Step 9: Add a Currency Converter Class

## `CurrencyConverter` Class

The `CurrencyConverter` class is responsible for converting a specified amount of money from the base currency to a target currency using the exchange rates fetched from the `ExchangeRateService`. The class relies on the `ExchangeRateService` to retrieve the current exchange rates for a given target currency.

### Constructor

#### Purpose:
Initialize the `CurrencyConverter` class with an instance of `ExchangeRateService`.

#### Code:
```csharp
public CurrencyConverter(ExchangeRateService rateService)
{
    _rateService = rateService;
}
```
- **rateService**: An instance of the `ExchangeRateService` class, which is used to fetch the exchange rates for converting currencies.

### Methods

#### `Convert` Method

#### Purpose:
Convert a given amount of money from the base currency to a target currency using the exchange rate fetched from the `ExchangeRateService`.

#### Parameters:
- `amount` (decimal): The amount to be converted.
- `targetCurrency` (string): The currency code of the target currency (e.g., "LKR", "EUR").

#### Return:
- `decimal`: The converted value after multiplying the provided amount by the exchange rate.

#### Code:
```csharp
public decimal Convert(decimal amount, string targetCurrency)
{
    decimal rate = _rateService.GetRate(targetCurrency);
    return amount * rate;
}
```

- The method retrieves the exchange rate for the target currency using the `GetRate` method of the `ExchangeRateService`.
- It then multiplies the provided amount by the exchange rate to return the converted value.

This class provides a simple and efficient way to convert between currencies based on real-time exchange rates.

This section outlines the functionality of the **CurrencyConverter** class, explaining its constructor and methods with code examples and usage instructions. Let me know if you need any further adjustments!

---

# Your Final code will look like this !

## Program.cs
```csharp
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
                        break;

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

                                // Get exchange rate
                                decimal rate = exchangeRateService.GetRate(targetCurrency);

                                // Calculate converted amount
                                decimal convertedAmount = amount * rate;
                                Console.WriteLine($"{amount} {exchangeRateService.BaseCurrency} = {convertedAmount} {targetCurrency}");
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid amount entered. Please enter a valid decimal number.");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
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
                        // Handle invalid menu options
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
```

---
## ExchangeRateResponse.cs
```csharp
using System.Collections.Generic;
using System.Text.Json.Serialization;

public class ExchangeRateResponse
{
    // Map JSON properties of the API response to C# properties using attributes.

    // Maps to base_code
    [JsonPropertyName("base_code")]
    public string? Base { get; set; }

    // Maps to rates
    [JsonPropertyName("rates")]
    public Dictionary<string, decimal>? Rates { get; set; }

    // Maps to result
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    // Maps to time_last_update_utc
    [JsonPropertyName("time_last_update_utc")]
    public string? LastUpdateUtc { get; set; }

    // Maps to time_next_update_utc
    [JsonPropertyName("time_next_update_utc")]
    public string? NextUpdateUtc { get; set; }
}

```


---
## CurrencyConverter.cs

``` csharp
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace _7_4HD
{
    public class CurrencyConverter
    {
        // Store reference to exchange rate service
        private readonly ExchangeRateService _rateService;

        // Initialize exchange rate service in constructor
        public CurrencyConverter(ExchangeRateService rateService)
        {
            _rateService = rateService;
        }

        // Get the exchange rate for the target currency and multiply the amount by the exchange rate to get the converted value.
        public decimal Convert(decimal amount, string targetCurrency)
        {
            decimal rate = _rateService.GetRate(targetCurrency);
            return amount * rate;
        }
    }
}

```