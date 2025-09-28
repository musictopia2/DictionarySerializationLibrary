namespace DictionarySerializationLibrary.SimpleDataHelpers;
internal class CommonDictionarySettingsContext : BasicSimpleDictionarySettingsContext
{
    //supported types for simple:
    //string, int, bool, decimal, double, float, datetime, dateonly, char, timeonly, timespan, datetimeoffset, byte
    protected override void Configure(IDictionaryConfig config)
    {
        // string key
        config
            // string key
            .Make<string, string>().Make<string, string?>().Make<string, int>().Make<string, int?>().Make<string, bool>().Make<string, bool?>()
            .Make<string, decimal>().Make<string, decimal?>().Make<string, double>().Make<string, double?>()
            .Make<string, float>().Make<string, float?>().Make<string, DateTime>().Make<string, DateTime?>()
            .Make<string, DateOnly>().Make<string, DateOnly?>().Make<string, TimeOnly>().Make<string, TimeOnly?>()
            .Make<string, TimeSpan>().Make<string, TimeSpan?>().Make<string, DateTimeOffset>().Make<string, DateTimeOffset?>()
            .Make<string, char>().Make<string, char?>().Make<string, byte>().Make<string, byte?>()

            // int key
            .Make<int, string>().Make<int, string?>().Make<int, int>().Make<int, int?>().Make<int, bool>().Make<int, bool?>()
            .Make<int, decimal>().Make<int, decimal?>().Make<int, double>().Make<int, double?>()
            .Make<int, float>().Make<int, float?>().Make<int, DateTime>().Make<int, DateTime?>()
            .Make<int, DateOnly>().Make<int, DateOnly?>().Make<int, TimeOnly>().Make<int, TimeOnly?>()
            .Make<int, TimeSpan>().Make<int, TimeSpan?>().Make<int, DateTimeOffset>().Make<int, DateTimeOffset?>()
            .Make<int, char>().Make<int, char?>().Make<int, byte>().Make<int, byte?>()

            // decimal key
            .Make<decimal, string>().Make<decimal, string?>().Make<decimal, int>().Make<decimal, int?>().Make<decimal, bool>().Make<decimal, bool?>()
            .Make<decimal, decimal>().Make<decimal, decimal?>().Make<decimal, double>().Make<decimal, double?>()
            .Make<decimal, float>().Make<decimal, float?>().Make<decimal, DateTime>().Make<decimal, DateTime?>()
            .Make<decimal, DateOnly>().Make<decimal, DateOnly?>().Make<decimal, TimeOnly>().Make<decimal, TimeOnly?>()
            .Make<decimal, TimeSpan>().Make<decimal, TimeSpan?>().Make<decimal, DateTimeOffset>().Make<decimal, DateTimeOffset?>()
            .Make<decimal, char>().Make<decimal, char?>().Make<decimal, byte>().Make<decimal, byte?>()

            // double key
            .Make<double, string>().Make<double, string?>().Make<double, int>().Make<double, int?>().Make<double, bool>().Make<double, bool?>()
            .Make<double, decimal>().Make<double, decimal?>().Make<double, double>().Make<double, double?>()
            .Make<double, float>().Make<double, float?>().Make<double, DateTime>().Make<double, DateTime?>()
            .Make<double, DateOnly>().Make<double, DateOnly?>().Make<double, TimeOnly>().Make<double, TimeOnly?>()
            .Make<double, TimeSpan>().Make<double, TimeSpan?>().Make<double, DateTimeOffset>().Make<double, DateTimeOffset?>()
            .Make<double, char>().Make<double, char?>().Make<double, byte>().Make<double, byte?>()

            // DateTime key
            .Make<DateTime, string>().Make<DateTime, string?>().Make<DateTime, int>().Make<DateTime, int?>().Make<DateTime, bool>().Make<DateTime, bool?>()
            .Make<DateTime, decimal>().Make<DateTime, decimal?>().Make<DateTime, double>().Make<DateTime, double?>()
            .Make<DateTime, float>().Make<DateTime, float?>().Make<DateTime, DateTime>().Make<DateTime, DateTime?>()
            .Make<DateTime, DateOnly>().Make<DateTime, DateOnly?>().Make<DateTime, TimeOnly>().Make<DateTime, TimeOnly?>()
            .Make<DateTime, TimeSpan>().Make<DateTime, TimeSpan?>().Make<DateTime, DateTimeOffset>().Make<DateTime, DateTimeOffset?>()
            .Make<DateTime, char>().Make<DateTime, char?>().Make<DateTime, byte>().Make<DateTime, byte?>()

            // DateOnly key
            .Make<DateOnly, string>().Make<DateOnly, string?>().Make<DateOnly, int>().Make<DateOnly, int?>().Make<DateOnly, bool>().Make<DateOnly, bool?>()
            .Make<DateOnly, decimal>().Make<DateOnly, decimal?>().Make<DateOnly, double>().Make<DateOnly, double?>()
            .Make<DateOnly, float>().Make<DateOnly, float?>().Make<DateOnly, DateTime>().Make<DateOnly, DateTime?>()
            .Make<DateOnly, DateOnly>().Make<DateOnly, DateOnly?>().Make<DateOnly, TimeOnly>().Make<DateOnly, TimeOnly?>()
            .Make<DateOnly, TimeSpan>().Make<DateOnly, TimeSpan?>().Make<DateOnly, DateTimeOffset>().Make<DateOnly, DateTimeOffset?>()
            .Make<DateOnly, char>().Make<DateOnly, char?>().Make<DateOnly, byte>().Make<DateOnly, byte?>()

            // TimeOnly key
            .Make<TimeOnly, string>().Make<TimeOnly, string?>().Make<TimeOnly, int>().Make<TimeOnly, int?>().Make<TimeOnly, bool>().Make<TimeOnly, bool?>()
            .Make<TimeOnly, decimal>().Make<TimeOnly, decimal?>().Make<TimeOnly, double>().Make<TimeOnly, double?>()
            .Make<TimeOnly, float>().Make<TimeOnly, float?>().Make<TimeOnly, DateTime>().Make<TimeOnly, DateTime?>()
            .Make<TimeOnly, DateOnly>().Make<TimeOnly, DateOnly?>().Make<TimeOnly, TimeOnly>().Make<TimeOnly, TimeOnly?>()
            .Make<TimeOnly, TimeSpan>().Make<TimeOnly, TimeSpan?>().Make<TimeOnly, DateTimeOffset>().Make<TimeOnly, DateTimeOffset?>()
            .Make<TimeOnly, char>().Make<TimeOnly, char?>().Make<TimeOnly, byte>().Make<TimeOnly, byte?>()

            // char key
            .Make<char, string>().Make<char, string?>().Make<char, int>().Make<char, int?>().Make<char, bool>().Make<char, bool?>()
            .Make<char, decimal>().Make<char, decimal?>().Make<char, double>().Make<char, double?>()
            .Make<char, float>().Make<char, float?>().Make<char, DateTime>().Make<char, DateTime?>()
            .Make<char, DateOnly>().Make<char, DateOnly?>().Make<char, TimeOnly>().Make<char, TimeOnly?>()
            .Make<char, TimeSpan>().Make<char, TimeSpan?>().Make<char, DateTimeOffset>().Make<char, DateTimeOffset?>()
            .Make<char, char>().Make<char, char?>().Make<char, byte>().Make<char, byte?>();
    }
}