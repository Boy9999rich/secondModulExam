using _01__072__2025__2__modul__Exam.DataAccess.Entity;
using System.Text.Json;

namespace _01__072__2025__2__modul__Exam.repositories;

public class MusicRepository : IMusicRepository
{
    private string _path;
    private List<Music> _musics;

    public MusicRepository()
    {
        _path = "../../../DataAccess/Data/music.json";
        _musics = new List<Music>();

        if (!File.Exists(_path))
        {
            File.WriteAllText(_path, "[]");
        }
        _musics = ReadAllMusic();
    }
    private void SaveData()
    {
        var jsonData = JsonSerializer.Serialize(_musics);
        File.WriteAllText(_path, jsonData);
    }
    public List<Music> ReadAllMusic()
    {
        var musicJson = File.ReadAllText(_path);
        var result = JsonSerializer.Deserialize<List<Music>>(musicJson);
        return result;       
    }

    public Music ReadMusicById(Guid Id)
    {
        foreach (var music in _musics)
        {
            if (music.Id == Id)
            {
                return music;
            }
        }
        return null;
    }

    public bool RemoveMusic(Guid Id)
    {
        var removingMusic = ReadMusicById(Id);
        if (removingMusic is null)
        {
            return false;
        }
        _musics.Remove(removingMusic);
        SaveData();
        return true;
    }

    public bool UpdateMusic(Music music)
    {
        var musics = ReadMusicById(music.Id);
        if (musics is null)
        {
            return false;
        }
        else
        {
            var index = _musics.IndexOf(music);
            _musics[index] = music;
            SaveData();
            return true;
        }
    }

    public Music WriteMusic(Music music)
    {
        _musics.Add(music);
        SaveData();
        return music;
    }
}
