using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_Coursework
{
    /* CODE SOURCED FROM QUICKTYPE */

    //Declaring class for API result to be deserialized into
    public partial class DataClass
    {
        [JsonProperty("success")]
        public bool Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("results")]
        public long Results { get; set; }

        [JsonProperty("data")]
        public List<Data> Data { get; set; }
    }

    //List class for team data
    public partial class Data
    {
        [JsonProperty("team_name")]
        public string TeamName { get; set; }

        [JsonProperty("team_abbreviation")]
        public string TeamAbbreviation { get; set; }

        [JsonProperty("arena")]
        public string Arena { get; set; }

        [JsonProperty("attendance")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Attendance { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("games")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Games { get; set; }

        [JsonProperty("won")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Won { get; set; }

        [JsonProperty("lost")]
        [JsonConverter(typeof(ParseStringConverter))]
        public long Lost { get; set; }

        [JsonProperty("pace")]
        public string Pace { get; set; }

        [JsonProperty("points")]
        public string Points { get; set; }

        [JsonProperty("assists")]
        public string Assists { get; set; }

        [JsonProperty("rebounds")]
        public string Rebounds { get; set; }

        [JsonProperty("steals")]
        public string Steals { get; set; }

        [JsonProperty("blocks")]
        public string Blocks { get; set; }

        [JsonProperty("turnovers")]
        public string Turnovers { get; set; }

        [JsonProperty("fouls")]
        public string Fouls { get; set; }

        [JsonProperty("offensive_rebounds")]
        public string OffensiveRebounds { get; set; }

        [JsonProperty("defensive_rebounds")]
        public string DefensiveRebounds { get; set; }

        [JsonProperty("offensive_rebound_percentage")]
        public string OffensiveReboundPercentage { get; set; }

        [JsonProperty("defensive_rebound_percentage")]
        public string DefensiveReboundPercentage { get; set; }

        [JsonProperty("fg_attempted")]
        public string FgAttempted { get; set; }

        [JsonProperty("fg_made")]
        public string FgMade { get; set; }

        [JsonProperty("fg_percentage")]
        public string FgPercentage { get; set; }

        [JsonProperty("tpfg_attempted")]
        public string TpfgAttempted { get; set; }

        [JsonProperty("tpfg_made")]
        public string TpfgMade { get; set; }

        [JsonProperty("tpfg_percentage")]
        public string TpfgPercentage { get; set; }

        [JsonProperty("ft_attempted")]
        public string FtAttempted { get; set; }

        [JsonProperty("ft_made")]
        public string FtMade { get; set; }

        [JsonProperty("ft_percentage")]
        public string FtPercentage { get; set; }

        [JsonProperty("true_shooting_percentage")]
        public string TrueShootingPercentage { get; set; }

        [JsonProperty("effective_field_goal_percentage")]
        public string EffectiveFieldGoalPercentage { get; set; }

        [JsonProperty("offensive_rating")]
        public string OffensiveRating { get; set; }

        [JsonProperty("defensive_rating")]
        public string DefensiveRating { get; set; }

        [JsonProperty("season")]
        public string Season { get; set; }

        [JsonProperty("season_type")]
        public string SeasonType { get; set; }
    }

    public partial class DataClass
    {
        public static DataClass FromJson(string json) => JsonConvert.DeserializeObject<DataClass>(json, AI_Coursework.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this DataClass self) => JsonConvert.SerializeObject(self, AI_Coursework.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
