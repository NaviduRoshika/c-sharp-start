namespace WorldNameSpace
{
    abstract class World
    {
        private string planetName;
        private Continents continents;
        
        public string PlanetName { get { return planetName; } set { planetName = value; } }
        public Continents Continents { get { return continents; } set { continents = value; } }


    }
    
    enum Continents
    {
        Asia,
        Africa,
        North_America,
        South_America,
        Antarctica,
        Europe,
        Australia

    }
    
    enum Currencies
    {
        U_S_dollar_USD, Canadian_dollar_CAD, Euro_EUR, British_pound_GBP, Swiss_franc_CHF, New_Zealand_dollar_NZD, Australian_dollar_AUD, Japanese_yen_JPY
    }
    
    enum Languages
    {
        CHINESE, SPANISH, ENGLISH, HINDI, ARABIC, PORTUGUESE, BENGALI, RUSSIAN
    }
    
    struct CountryLanguages
    {
        private string firstLanguage;
        private string secondLanguage;

        public string FirstLanguage
        {
            get { return firstLanguage; }
            set { firstLanguage = value; }
        }
        public string SecondLanguage
        {
            get { return secondLanguage; }
            set { secondLanguage = value; }
        }
    }

    class Country : World
    {
        private string countryName;
        private string capital;
        private CountryLanguages countryLanguages;
        private Currencies currency;

        public Country()
        {
            countryName = "Country X";
            capital = "Capital X";
        }

        
        #region - Country props
        public string CountryName
        {
            get { return countryName; }
            set { countryName = value; }

        }
        
        public string Capital
        {
            get { return capital; }
            set { capital = value; }

        }

        public CountryLanguages CountryLanguages
        {
            get { return countryLanguages; }
            set { countryLanguages = value; }
        }

        public Currencies Currency
        {
            get { return currency; }
            set { currency = value; }
        }
        #endregion
        public void SayHi()
        {
            System.Console.WriteLine("Hello There From Nowhere");
        }
        public void SayHi(string country)
        {
            System.Console.WriteLine("Hello There From {0}", country);
        }



    }
}