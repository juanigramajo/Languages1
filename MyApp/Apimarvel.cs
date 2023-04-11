// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

using System.Text.Json.Serialization;

    public class Comics
    {
        [JsonPropertyName("available")]
        public int Available { get; set; }

        [JsonPropertyName("collectionURI")]
        public string CollectionURI { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }

        [JsonPropertyName("returned")]
        public int Returned { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("offset")]
        public int Offset { get; set; }

        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("results")]
        public List<Result> Results { get; set; }
    }

    public class Events
    {
        [JsonPropertyName("available")]
        public int Available { get; set; }

        [JsonPropertyName("collectionURI")]
        public string CollectionURI { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }

        [JsonPropertyName("returned")]
        public int Returned { get; set; }
    }

    public class Item
    {
        [JsonPropertyName("resourceURI")]
        public string ResourceURI { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("modified")]
        public string Modified { get; set; }

        [JsonPropertyName("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonPropertyName("resourceURI")]
        public string ResourceURI { get; set; }

        [JsonPropertyName("comics")]
        public Comics Comics { get; set; }

        [JsonPropertyName("series")]
        public Series Series { get; set; }

        [JsonPropertyName("stories")]
        public Stories Stories { get; set; }

        [JsonPropertyName("events")]
        public Events Events { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }

        [JsonPropertyName("attributionText")]
        public string AttributionText { get; set; }

        [JsonPropertyName("attributionHTML")]
        public string AttributionHTML { get; set; }

        [JsonPropertyName("etag")]
        public string Etag { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class Series
    {
        [JsonPropertyName("available")]
        public int Available { get; set; }

        [JsonPropertyName("collectionURI")]
        public string CollectionURI { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }

        [JsonPropertyName("returned")]
        public int Returned { get; set; }
    }

    public class Stories
    {
        [JsonPropertyName("available")]
        public int Available { get; set; }

        [JsonPropertyName("collectionURI")]
        public string CollectionURI { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }

        [JsonPropertyName("returned")]
        public int Returned { get; set; }
    }

    public class Thumbnail
    {
        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("extension")]
        public string Extension { get; set; }
    }

