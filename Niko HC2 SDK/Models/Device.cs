﻿using System.Collections.Generic;
using System.Text.Json.Serialization;
using HC2.Arcanastudio.Net.Models.Interfaces;

namespace HC2.Arcanastudio.Net.Models
{
    internal class Device : IDevice
    {
        #region Implementation of IDevice

        public string Name { get; set; }

        [JsonIgnore]
        public List<IProperty> Properties { get; set; }
        public string Technology { get; set; }
        [JsonPropertyName("Uuid")]
        public string Id { get; set; }
        public string Identifier { get; set; }
        public bool Online { get; }
        public string Model { get; set; }
        [JsonIgnore]
        public List<ITrait> Traits { get; }
        public string Type { get; set; }
        [JsonIgnore]
        public List<IParameter> Parameters { get; }

        #endregion

        public Device()
        {
            Parameters = new List<IParameter>();
            Properties = new List<IProperty>();
            Traits = new List<ITrait>();
        }
    }
}
