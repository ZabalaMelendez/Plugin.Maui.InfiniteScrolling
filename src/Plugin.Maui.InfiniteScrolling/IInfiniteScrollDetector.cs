namespace Plugin.Maui.InfiniteScrolling;

/// <summary>
/// 
/// </summary>
public interface IInfiniteScrollDetector
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="currentItem"></param>
    /// <returns></returns>
    bool ShouldLoadMore(object currentItem);

}