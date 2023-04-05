using System;
using System.Collections;
using System.Collections.Generic;

public enum Genre
{
    Camedy,
    Horror,
    Adventure,
    Fantasy,
    Action,
    Romance,
}

public class Movie : ICloneable, IComparable<Movie>
{
    public string Title { get; set; }
    public Director Director { get; set; }
    public string Country { get; set; }
    public Genre Genre { get; set; }
    public int Year { get; set; }
    public short Rating { get; set; }

    public Movie(string Title, Director Director, string Country, Genre Genre, int Year, short Rating)
    {
        this.Title = Title;
        this.Director = Director;
        this.Country = Country;
        this.Genre = Genre;
        this.Year = Year;
        this.Rating = Rating;
    }

    public override string ToString()
    {
        return $"{Title} {Director} {Country} {Year} {Rating}";
    }

    public object Clone()
    {
        return new Movie(Title, (Director)Director.Clone(), Country, Genre, Year, Rating);
    }

    public int CompareTo(Movie other_movie)
    {
        if (other_movie == null) { return 1; }
        return Year.CompareTo(other_movie.Year);
    }
}

public class MovieRatingComparer : IComparer<Movie>
{
    public int Compare(Movie x, Movie y)
    {
        if (x == null || y == null) { return 0; }
        else return x.Rating.CompareTo(y.Rating);
    }
}

public class Director : ICloneable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Director(string FirstName, string LastName)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }

    public object Clone()
    {
        return new Director(FirstName, LastName);
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}

public class Cinema : IEnumerable<Movie>
{
    private List<Movie> movies = new List<Movie>();
    public string Address { get; set; }

    public void AddMovie(Movie movie) { movies.Add(movie); }
    public void Sort() { movies.Sort(); }
    public void Sort(IComparer<Movie> comparer) { movies.Sort(comparer); }
    public IEnumerator<Movie> GetEnumerator() { return movies.GetEnumerator(); }
    IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
}

class lesson_11
{
    static void Main(string[] args)
    {
        Director director0 = new Director("Salo", "Vitaly");
        Director director1 = new Director("Peter ", "Jackson");
        Director director2 = new Director("Alex", "Zumberg");

        Movie movie0 = new Movie("The Lord of the Rings: The Return of the King", director0, "USA", Genre.Fantasy, 2003, 10);

        Movie copyMovie0 = (Movie)movie0.Clone();
        Director copyDirector0 = (Director)director0.Clone();

        Console.WriteLine("Original movie: ");
        Console.WriteLine(movie0);

        Console.WriteLine("\nCopy movie: ");
        Console.WriteLine(copyMovie0);

        Console.WriteLine("\noriginal director: ");
        Console.WriteLine(director0);

        Console.WriteLine("\ncopy of director: ");
        Console.WriteLine(copyDirector0);

        Cinema cinema = new Cinema();
        cinema.AddMovie(new Movie("Smile", new Director("Parker ", "Finn"), "USA", Genre.Horror, 2022, 8));
        cinema.AddMovie(new Movie("The Lord of the Rings: The Fellowship of the Ring", director1, "USA", Genre.Fantasy, 2002, 10));
        cinema.AddMovie(new Movie("The lost city", new Director("Aaron No", "Adam No"), "USA", Genre.Romance, 2022, 6));
        cinema.AddMovie(new Movie("Night games ", new Director("John Francis Daley", "Jonathan M.Goldstein"), "USA", Genre.Camedy, 2018, 7));
        cinema.AddMovie(new Movie("The Lord of the Rings: Two Fortresses", director1, "USA", Genre.Fantasy, 2001, 10));

        foreach (Movie movie in cinema)
        {
            Console.WriteLine(movie.ToString());
        }
    }
}