// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace OpenAI.Internal
{
    [PersistableModelProxy(typeof(InternalUnknownOmniTypedResponseFormat))]
    internal partial class InternalOmniTypedResponseFormat : IJsonModel<InternalOmniTypedResponseFormat>
    {
        void IJsonModel<InternalOmniTypedResponseFormat>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalOmniTypedResponseFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalOmniTypedResponseFormat)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        InternalOmniTypedResponseFormat IJsonModel<InternalOmniTypedResponseFormat>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalOmniTypedResponseFormat>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalOmniTypedResponseFormat)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalOmniTypedResponseFormat(document.RootElement, options);
        }

        internal static InternalOmniTypedResponseFormat DeserializeInternalOmniTypedResponseFormat(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "json_object": return InternalResponseFormatJsonObject.DeserializeInternalResponseFormatJsonObject(element, options);
                    case "json_schema": return InternalResponseFormatJsonSchema.DeserializeInternalResponseFormatJsonSchema(element, options);
                    case "text": return InternalResponseFormatText.DeserializeInternalResponseFormatText(element, options);
                }
            }
            return InternalUnknownOmniTypedResponseFormat.DeserializeInternalUnknownOmniTypedResponseFormat(element, options);
        }

        BinaryData IPersistableModel<InternalOmniTypedResponseFormat>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalOmniTypedResponseFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InternalOmniTypedResponseFormat)} does not support writing '{options.Format}' format.");
            }
        }

        InternalOmniTypedResponseFormat IPersistableModel<InternalOmniTypedResponseFormat>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InternalOmniTypedResponseFormat>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInternalOmniTypedResponseFormat(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalOmniTypedResponseFormat)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalOmniTypedResponseFormat>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        internal static InternalOmniTypedResponseFormat FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeInternalOmniTypedResponseFormat(document.RootElement);
        }

        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
