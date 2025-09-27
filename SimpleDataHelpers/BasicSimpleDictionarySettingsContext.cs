namespace DictionarySerializationLibrary.SimpleDataHelpers;
public abstract class BasicSimpleDictionarySettingsContext
{
    public const string ConfigureName = nameof(Configure);
    protected abstract void Configure(IDictionaryConfig config);
}