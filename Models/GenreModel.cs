namespace moment3dotnet.Models; 

public class GenreModel {
    public int Id { get; set; }
    public string? GenreName { get; set; }

    public List<BookModel>? Books { get; set; } //Flera böcker kan ha samma genre
}