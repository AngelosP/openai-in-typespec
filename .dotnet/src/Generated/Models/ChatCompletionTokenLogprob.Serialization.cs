// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace OpenAI.Models
{
    public partial class ChatCompletionTokenLogprob : IJsonModel<ChatCompletionTokenLogprob>
    {
        void IJsonModel<ChatCompletionTokenLogprob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionTokenLogprob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionTokenLogprob)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("token"u8);
            writer.WriteStringValue(Token);
            writer.WritePropertyName("logprob"u8);
            writer.WriteNumberValue(Logprob);
            if (Bytes != null && OptionalProperty.IsCollectionDefined(Bytes))
            {
                writer.WritePropertyName("bytes"u8);
                writer.WriteStartArray();
                foreach (var item in Bytes)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            else
            {
                writer.WriteNull("bytes");
            }
            writer.WritePropertyName("top_logprobs"u8);
            writer.WriteStartArray();
            foreach (var item in TopLogprobs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
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

        ChatCompletionTokenLogprob IJsonModel<ChatCompletionTokenLogprob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionTokenLogprob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChatCompletionTokenLogprob)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChatCompletionTokenLogprob(document.RootElement, options);
        }

        internal static ChatCompletionTokenLogprob DeserializeChatCompletionTokenLogprob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string token = default;
            double logprob = default;
            IReadOnlyList<long> bytes = default;
            IReadOnlyList<ChatCompletionTokenLogprobTopLogprob> topLogprobs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("token"u8))
                {
                    token = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("logprob"u8))
                {
                    logprob = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("bytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        bytes = new OptionalList<long>();
                        continue;
                    }
                    List<long> array = new List<long>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetInt64());
                    }
                    bytes = array;
                    continue;
                }
                if (property.NameEquals("top_logprobs"u8))
                {
                    List<ChatCompletionTokenLogprobTopLogprob> array = new List<ChatCompletionTokenLogprobTopLogprob>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChatCompletionTokenLogprobTopLogprob.DeserializeChatCompletionTokenLogprobTopLogprob(item));
                    }
                    topLogprobs = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ChatCompletionTokenLogprob(token, logprob, bytes, topLogprobs, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChatCompletionTokenLogprob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionTokenLogprob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionTokenLogprob)} does not support '{options.Format}' format.");
            }
        }

        ChatCompletionTokenLogprob IPersistableModel<ChatCompletionTokenLogprob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChatCompletionTokenLogprob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChatCompletionTokenLogprob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChatCompletionTokenLogprob)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChatCompletionTokenLogprob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ChatCompletionTokenLogprob FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChatCompletionTokenLogprob(document.RootElement);
        }
    }
}

