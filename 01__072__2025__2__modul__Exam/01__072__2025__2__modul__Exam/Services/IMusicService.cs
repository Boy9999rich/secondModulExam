using _01__072__2025__2__modul__Exam.DataAccess.Entity;

namespace _01__072__2025__2__modul__Exam.Services
{
    public interface IMusicService
    {
        List<Music> GetAllMusicByAuthorName(string name);
        List<Music> GetMostLikedMusic(int music);
        List<Music> GetMusicByName(string name);
        List<Music> GetAllMusicAboveSize(double minSize);
        List<Music> GetTopMostLikedMusic(int count);
        List<Music> GetMusicByDescriptionKeyword(string keyword);
        List<Music> GetMusicWithLikesInRange(int minLikes, int maxLikes);
        List<Music> GetAllUniqueAuthors();
    }
}