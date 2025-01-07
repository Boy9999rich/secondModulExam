using _01__072__2025__2__modul__Exam.DataAccess.Entity;
using _01__072__2025__2__modul__Exam.repositories;
using _01__072__2025__2__modul__Exam.Services.Dto;

namespace _01__072__2025__2__modul__Exam.Services;

public class MusicService : IMusicService
{
    private  IMusicRepository _musicRepository;

    public MusicService()
    {
        _musicRepository = new MusicRepository();
    }
    public List<Music> GetAllMusicAboveSize(double minSize)
    {
        var musics = new List<Music>();
        return musics.Count();
    }

    public List<Music> GetAllMusicByAuthorName(string name)
    {
        var getName = new List<Music>();
        foreach (var names in getName)
        {
            if (names.AuthorName == name)
            {
                getName.Add(names);
            }
        }
        return null;
    }

    public List<Music> GetAllUniqueAuthors()
    {
        var authorName = new  List<Music>();
        foreach (var author in authorName)
        {
            authorName.Add(author);
        }
        return null;
    }

    public List<Music> GetMostLikedMusic(int music)
    {
        var musics = new List<Music>();
        for (var i = 0; i < musics.Count; i++)
        {
            if (musics[i] > music)
            {
                music = musics[i];
            }
        }
        return musics;

    }

    public List<Music> GetMusicByDescriptionKeyword(string keyword)
    {
        var desc = new List<Music>();
        foreach (var descrip in desc)
        {
            if (descrip.Description == keyword)
            {
                desc.Add(descrip);
            }
        }
        return null;
    }

    public List<Music> GetMusicByName(string name)
    {
        var namesss = new List<Music>();
        foreach (var names in namesss)
        {
            if (names.Name == name)
            {
                namesss.Add(names);
            }
        }
        return null;
    }

    public List<Music> GetMusicWithLikesInRange(int minLikes, int maxLikes)
    {
        var likes = new List<Music>();
        foreach (var like in likes)
        {
            if (minLikes < maxLikes)
            {
                likes.Add(like);
                return likes;
            }
        }
        return null;
    }

    public List<Music> GetTopMostLikedMusic(int count)
    {
        var likes = new List<Music>();
        foreach (var like in likes)
        {
            if (likes.Count == count)
            {
                likes.Add(like);
                return likes;
            }
        }
        return null;
    }

    

    public Music ConvertToMusic(MusicCreateDto dto)
    {
        var music = new Music()
        {
            Id = Guid.NewGuid(),
            Name = dto.Name,
            MB = dto.MB,
            AuthorName = dto.AuthorName,
            Description = dto.Description,
            QuantityLikes = dto.QuantityLikes,
        };
        return music;
    }

    public MusicGetDto ConvertToDto(Music music)
    {
        var dto = new MusicGetDto()
        {
            Id = music.Id,
            Name = music.Name,
            MB = music.MB,
            AuthorName = music.AuthorName,
            Description = music.Description,
            QuantityLikes = music.QuantityLikes,
        };
        return dto;
    }


}
