namespace GameStore.Api.Dtos;

public record class UpdateGameDot(
    string Name,
    string Genre,
    decimal Price,
    DateOnly ReleaseDate

);
