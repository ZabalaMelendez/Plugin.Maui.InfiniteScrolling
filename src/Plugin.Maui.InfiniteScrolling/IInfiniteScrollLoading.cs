namespace Plugin.Maui.InfiniteScrolling;

/// <summary>
/// 
/// </summary>
public interface IInfiniteScrollLoading
{
    /// <summary>
    /// 
    /// </summary>
    bool IsLoadingMore { get; }

    /// <summary>
    /// 
    /// </summary>
    event EventHandler<LoadingMoreEventArgs> LoadingMore;
}