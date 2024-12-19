namespace Plugin.Maui.InfiniteScrolling;

/// <summary>
/// TODO: Provide relevant comments for your APIs
/// </summary>
public interface IInfiniteScrolling
{
	// TODO Define your plugin interface
}


/// <summary>
/// 
/// </summary>
public class LoadingMoreEventArgs(bool isLoadingMore) : EventArgs
{
	public bool IsLoadingMore { get; private set; } = isLoadingMore;
}
