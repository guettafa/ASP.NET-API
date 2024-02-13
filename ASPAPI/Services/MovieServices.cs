using ASPAPI.Models;

namespace ASPAPI.Services
{
    public static class MovieServices
    {
        static List<Movie> Movies { get; }
        
        static MovieServices()
        {
            Movies = new List<Movie>
            {
                new Movie { Id = 1, Title = "Mov1", Description = "top movie", Stars = 2, Type = "Action"},
                new Movie { Id = 2, Title = "Mov2", Description = "cool movie", Stars = 5, Type = "3d movie" },
            };
        }

        public static List<Movie> GetAll()  => Movies;
                    
        // the ? to tell that it can be nulleable
        public static Movie? Get(int id)    => Movies.Find(movie => movie.Id == id);

        public static void Add(Movie movie)     => Movies.Add(movie);
        public static void Delete(int id)       => Movies.Remove(Get(id));
        public static void Update(Movie movie)  => Movies[Movies.FindIndex(m => m.Id == movie.Id)] = movie;
    }
}
