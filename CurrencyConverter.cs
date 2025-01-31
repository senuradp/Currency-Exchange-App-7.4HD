using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace _7_4HD
{
    public class CurrencyConverter
    {
        
        // store reference to exchange rate service
        private readonly ExchangeRateService _rateService;

        // initialize exhcnage rate service in consructor
        public CurrencyConverter(ExchangeRateService rateService){
            _rateService = rateService;
        }

        // to get the exchange rate for the target currency and multiply the amount by the exchange rate to get the converted value.
        public decimal Convert(decimal amount, string targetCurrency){
            decimal rate = _rateService.GetRate(targetCurrency);
            return amount * rate;
        }

    }

}