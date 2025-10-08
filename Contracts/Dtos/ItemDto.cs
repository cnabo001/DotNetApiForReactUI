namespace Contracts.Dtos;

public record ItemDto(int Id, string Title, int Price, bool IsActive, DateTime CreateDate, DateTime UpdateDate, string DeletedBy, DateTime DeletedDate);
