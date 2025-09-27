namespace DictionarySerializationLibrary.SimpleDataHelpers;
public class CustomDictionarySimpleHelpers<TKey, TValue>
     where TKey : notnull
{
    public static IFlatSimpleDictionaryProvider<TKey, TValue>? MasterContext { get; set; }
}