namespace Plugin.Maui.InfiniteScrolling;

/// <summary>
/// 
/// </summary>
public interface IInfiniteScrollLoader
{
    bool CanLoadMore { get; }

    Task LoadMoreAsync();
}