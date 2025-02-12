namespace moment3dotnet.Models; 

public class BookModel {
    public int Id { get; set; }
    public string? Title { get; set; }

    public string? Author { get; set; }

    public bool Read { get; set; }

    //koppling till genre
    public int GenreModelId { get; set; }
    public GenreModel? Genre { get; set; }
}