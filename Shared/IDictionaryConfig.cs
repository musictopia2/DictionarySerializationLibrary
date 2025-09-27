namespace DictionarySerializationLibrary.Shared;
public interface IDictionaryConfig
{
    IDictionaryConfig Make<TKey, TValue>()
        where TKey : notnull;
}