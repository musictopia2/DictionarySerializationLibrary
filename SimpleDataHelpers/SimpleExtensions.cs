namespace DictionarySerializationLibrary.SimpleDataHelpers;
public static class SimpleExtensions
{
    public static async Task<Dictionary<TKey, TValue>> LoadTextDictionaryAsync<TKey, TValue>(this string path, string delimiter = ",")
        where TKey : notnull
    {
        IFlatSimpleDictionaryProvider<TKey, TValue> provider = CustomDictionarySimpleHelpers<TKey, TValue>.MasterContext ?? throw new InvalidOperationException("MasterContext is not set. Please register a provider first.");
        if (ff1.FileExists(path) == false)
        {
            throw new FileNotFoundException("The specified file was not found.", path);
        }
        var lines = await ff1.ReadAllLinesAsync(path);
        var result = new Dictionary<TKey, TValue>();
        foreach (var line in lines)
        {
            var parts = line.Split(delimiter).ToBasicList();
            if (parts.Count != 2)
            {
                throw new FormatException($"Invalid line format: {line}");
            }
            string keyPart = parts[0];
            string valuePart = parts[1];
            if (provider.TryAddItem(result, keyPart, valuePart, out string? errorMessage) == false)
            {
                throw new FormatException($"Error adding item: {errorMessage}");
            }
        }
        return result;
    }
    public static async Task SaveTextAsync<TKey, TValue>(this Dictionary<TKey, TValue> dictionary, string path, string delimiter = ",")
        where TKey : notnull
    {
        IFlatSimpleDictionaryProvider<TKey, TValue> provider = CustomDictionarySimpleHelpers<TKey, TValue>.MasterContext ?? throw new InvalidOperationException("MasterContext is not set. Please register a provider first.");
        BasicList<string> lines = [];
        foreach (var kvp in dictionary)
        {
            string key = provider.SerializeKey(kvp.Key);
            string value = provider.SerializeValue(kvp.Value);
            lines.Add($"{key}{delimiter}{value}");
        }
        await ff1.WriteAllLinesAsync(path, lines);
    }
}