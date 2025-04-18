// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.AI.OpenAI;

namespace Azure.AI.OpenAI.Chat
{
    /// <summary></summary>
    [PersistableModelProxy(typeof(InternalUnknownAzureChatDataSourceVectorizationSource))]
    public abstract partial class DataSourceVectorizer : IJsonModel<DataSourceVectorizer>
    {
        internal DataSourceVectorizer()
        {
        }

        void IJsonModel<DataSourceVectorizer>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<DataSourceVectorizer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataSourceVectorizer)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Type);
            }
            if (options.Format != "W" && _additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
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
        }

        DataSourceVectorizer IJsonModel<DataSourceVectorizer>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        /// <param name="reader"> The JSON reader. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual DataSourceVectorizer JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<DataSourceVectorizer>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataSourceVectorizer)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataSourceVectorizer(document.RootElement, options);
        }

        internal static DataSourceVectorizer DeserializeDataSourceVectorizer(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type"u8, out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "endpoint":
                        return InternalAzureChatDataSourceEndpointVectorizationSource.DeserializeInternalAzureChatDataSourceEndpointVectorizationSource(element, options);
                    case "deployment_name":
                        return InternalAzureChatDataSourceDeploymentNameVectorizationSource.DeserializeInternalAzureChatDataSourceDeploymentNameVectorizationSource(element, options);
                    case "model_id":
                        return InternalAzureChatDataSourceModelIdVectorizationSource.DeserializeInternalAzureChatDataSourceModelIdVectorizationSource(element, options);
                    case "integrated":
                        return InternalAzureChatDataSourceIntegratedVectorizationSource.DeserializeInternalAzureChatDataSourceIntegratedVectorizationSource(element, options);
                }
            }
            return InternalUnknownAzureChatDataSourceVectorizationSource.DeserializeInternalUnknownAzureChatDataSourceVectorizationSource(element, options);
        }

        BinaryData IPersistableModel<DataSourceVectorizer>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<DataSourceVectorizer>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataSourceVectorizer)} does not support writing '{options.Format}' format.");
            }
        }

        DataSourceVectorizer IPersistableModel<DataSourceVectorizer>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        /// <param name="data"> The data to parse. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual DataSourceVectorizer PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<DataSourceVectorizer>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeDataSourceVectorizer(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataSourceVectorizer)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataSourceVectorizer>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <param name="dataSourceVectorizer"> The <see cref="DataSourceVectorizer"/> to serialize into <see cref="BinaryContent"/>. </param>
        public static implicit operator BinaryContent(DataSourceVectorizer dataSourceVectorizer)
        {
            if (dataSourceVectorizer == null)
            {
                return null;
            }
            return BinaryContent.Create(dataSourceVectorizer, ModelSerializationExtensions.WireOptions);
        }

        /// <param name="result"> The <see cref="ClientResult"/> to deserialize the <see cref="DataSourceVectorizer"/> from. </param>
        public static explicit operator DataSourceVectorizer(ClientResult result)
        {
            using PipelineResponse response = result.GetRawResponse();
            using JsonDocument document = JsonDocument.Parse(response.Content);
            return DeserializeDataSourceVectorizer(document.RootElement, ModelSerializationExtensions.WireOptions);
        }
    }
}
