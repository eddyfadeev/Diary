using DiaryApp.Enums;

namespace DiaryApp.Models;

public record PagingButton
{
    public string Name { get; init; }
    public SortingOrder SortingOrder { get; init; }
    public int PageIndex { get; init; }
    public string AppliedFilter { get; init; }
    public bool IsActive { get; init; }
}