namespace DictionarySerializationLibrary.SimpleDataHelpers;
public interface IFlatSimpleDictionaryProvider<TKey, TValue>
    where TKey : notnull
{
    string SerializeKey(TKey key);
    string SerializeValue(TValue value);
    bool TryAddItem(Dictionary<TKey, TValue> dictionary, string key, string value, out string? errorMessage);
}