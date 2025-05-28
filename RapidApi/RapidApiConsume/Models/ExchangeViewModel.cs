namespace RapidApiConsume.Models
{
    public class ExchangeViewModel
    {

        public bool status { get; set; }
        public string message { get; set; }
        public long timestamp { get; set; }
        public Datum[] data { get; set; }


        public class Datum
        {
            public string name { get; set; }
            public string code { get; set; }
            public string encodedSymbol { get; set; }
            public string symbol { get; set; }
        }


    }
}
