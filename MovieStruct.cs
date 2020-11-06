using System;

namespace my_csharp
{
    public enum Genres
    {
        Crime,
        Thriller,
        Fantasy,
        Animation,
        Horror,
        SciFi,
        Action
    }

    public enum Languages
    {
        English,
        French,
        Sinhala,
        Tamil
    }

    public enum Countries
    {
        America,
        India,
        Korea,
        China
    }
    /// <summary>
    /// MovieStruct Struct is a base for movie data
    /// </summary>
    public struct MovieStruct
    {
        private string movieName;
        private double movieRate;
        private DateTime releaseDate;
        private Genres[] genres;
        private Languages[] languages;
        private Countries[] countries;

        public string MovieName
        {
            get { return movieName;}
            set { movieName = value; }
        }

        public double MovieRate
        {
            get { return movieRate; }
            set { movieRate = value; }
        }
        
        public DateTime ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }
        
        public Genres[] Genres
        {
            get { return genres; }
            set { genres = value; }
        }
        
        public Languages[] Languages 
        {
            get { return languages; }
            set { languages = value; }
        }
        
        public Countries[] Countries
        {
            get { return countries; }
            set { countries = value; }
        }

        public void DispalyMovieData()
        {
            Console.WriteLine("Movie :" + movieName );
            Console.WriteLine("Rate  :" + movieRate );
            Console.WriteLine("Releaed Date :" + releaseDate.ToString("yyyy MM dd") );
            Console.WriteLine("Languages    :" + String.Join(",", languages ));
            Console.WriteLine("Countries    :" + String.Join(",", countries));
            string str = String.Join(",",genres);
            Console.WriteLine("Gnres        :" + str);
        }
    }
}