// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    public partial class Plan : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Publisher != null)
            {
                writer.WritePropertyName("publisher");
                writer.WriteStringValue(Publisher);
            }
            if (Product != null)
            {
                writer.WritePropertyName("product");
                writer.WriteStringValue(Product);
            }
            if (PromotionCode != null)
            {
                writer.WritePropertyName("promotionCode");
                writer.WriteStringValue(PromotionCode);
            }
            if (Version != null)
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version);
            }
            writer.WriteEndObject();
        }

        internal static Plan DeserializePlan(JsonElement element)
        {
            string name = default;
            string publisher = default;
            string product = default;
            string promotionCode = default;
            string version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisher"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publisher = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("product"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    product = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("promotionCode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    promotionCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    version = property.Value.GetString();
                    continue;
                }
            }
            return new Plan(name, publisher, product, promotionCode, version);
        }
    }
}