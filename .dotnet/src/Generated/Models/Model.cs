// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.Collections.Generic;

namespace OpenAI.Models
{
    /// <summary> Describes an OpenAI model offering that can be used with the API. </summary>
    public partial class Model
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Model"/>. </summary>
        /// <param name="id"> The model identifier, which can be referenced in the API endpoints. </param>
        /// <param name="created"> The Unix timestamp (in seconds) when the model was created. </param>
        /// <param name="ownedBy"> The organization that owns the model. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="ownedBy"/> is null. </exception>
        internal Model(string id, DateTimeOffset created, string ownedBy)
        {
            if (id is null) throw new ArgumentNullException(nameof(id));
            if (ownedBy is null) throw new ArgumentNullException(nameof(ownedBy));

            Id = id;
            Created = created;
            OwnedBy = ownedBy;
        }

        /// <summary> Initializes a new instance of <see cref="Model"/>. </summary>
        /// <param name="id"> The model identifier, which can be referenced in the API endpoints. </param>
        /// <param name="created"> The Unix timestamp (in seconds) when the model was created. </param>
        /// <param name="object"> The object type, which is always "model". </param>
        /// <param name="ownedBy"> The organization that owns the model. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Model(string id, DateTimeOffset created, ModelObject @object, string ownedBy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Created = created;
            Object = @object;
            OwnedBy = ownedBy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="Model"/> for deserialization. </summary>
        internal Model()
        {
        }

        /// <summary> The model identifier, which can be referenced in the API endpoints. </summary>
        public string Id { get; }
        /// <summary> The Unix timestamp (in seconds) when the model was created. </summary>
        public DateTimeOffset Created { get; }
        /// <summary> The object type, which is always "model". </summary>
        public ModelObject Object { get; } = ModelObject.Model;

        /// <summary> The organization that owns the model. </summary>
        public string OwnedBy { get; }
    }
}

