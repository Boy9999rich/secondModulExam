using _01__072__2025__2__modul__Exam.DataAccess.Entity;

namespace _01__072__2025__2__modul__Exam.repositories;

public interface IMusicRepository
{
    









    Music WriteMusic(Music music);
    bool RemoveMusic(Guid Id);
    bool UpdateMusic(Music music);
    Music ReadMusicById(Guid Id);
    List<Music> ReadAllMusic();
}