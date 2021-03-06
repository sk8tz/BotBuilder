// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Place
    /// https://schema.org/Place
    /// </summary>
    public partial class Place
    {
        /// <summary>
        /// Initializes a new instance of the Place class.
        /// </summary>
        public Place()
        {
            Type = "Place";
        }

        /// <summary>
        /// Initializes a new instance of the Place class.
        /// </summary>
        public Place(object address = default(object), object geo = default(object), object hasMap = default(object), string type = default(string), string name = default(string))
        {
            Address = address;
            Geo = geo;
            HasMap = hasMap;
            Type = "Place";
            Name = name;
        }

        /// <summary>
        /// Address of the place
        /// Can be `string` or JToken of `PostalAddress` (future)
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public dynamic Address { get; set; }

        /// <summary>
        /// Geo coordinates of the place
        /// Can be JToken of `GeoCoordinates` or `GeoShape` (future)
        /// </summary>
        [JsonProperty(PropertyName = "geo")]
        public dynamic Geo { get; set; }

        /// <summary>
        /// Map to the place
        /// Can be `string` (a URL) or JToken of `Map` (future)
        /// </summary>
        [JsonProperty(PropertyName = "hasMap")]
        public dynamic HasMap { get; set; }

        /// <summary>
        /// The type of the thing
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The name of the thing
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
