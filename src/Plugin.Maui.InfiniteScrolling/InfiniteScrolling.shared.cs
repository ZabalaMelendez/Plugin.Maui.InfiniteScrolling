namespace Plugin.Maui.InfiniteScrolling;

public static class InfiniteScrolling
{
  private static IInfiniteScrolling? _defaultImplementation;

	/// <summary>
	/// Provides the default implementation for static usage of this API.
	/// </summary>
	public static IInfiniteScrolling Default =>
		_defaultImplementation ??= new InfiniteScrollingImplementation();

	internal static void SetDefault(IInfiniteScrolling? implementation) =>
		_defaultImplementation = implementation;
}
