using System.Collections.ObjectModel;

namespace Plugin.Maui.InfiniteScrolling.ObjectModel;

/// <summary>
/// 
/// </summary>
/// <typeparam name="T"></typeparam>
public class InfiniteScrollCollection<T> : ObservableCollection<T>
{
    public InfiniteScrollCollection() : base()
    {
        
    }
    
    public InfiniteScrollCollection(IEnumerable<T> collection) : base(collection)
    {
        
    }
    
    public InfiniteScrollCollection(List<T> collection) : base(collection)
    {
        
    }
    
    
}