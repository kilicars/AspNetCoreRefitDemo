using AspNetCoreRefitDemo.Models;
using Refit;

namespace AspNetCoreRefitDemo.Services
{
    [Headers("accept: application/json",
             "Authorization: Bearer")]
    public interface ITmdbApi
    {
        [Get("/search/person?query={name}")]
        Task<ActorList> GetActors(string name);

        //[Get("/search/person?query={name}")]
        //Task<ActorList> GetActors([AliasAs("name")] string actorName);

        [Get("/person/{actorId}/movie_credits?language=en-US")]
        Task<MovieList> GetMovies(int actorId);

        [Headers("Content-Type: application/json;charset=utf-8")]
        [Post("/movie/{movieId}/rating")]
        Task<ResponseBody> AddRating(int movieId, [Body] Rating rating);

        [Delete("/movie/{movieId}/rating")]
        Task<ResponseBody> DeleteRating(int movieId);

        //[Get("/search/person?query={name}")]
        //Task<ApiResponse<ActorList>> GetActors(string name);
    }
}
