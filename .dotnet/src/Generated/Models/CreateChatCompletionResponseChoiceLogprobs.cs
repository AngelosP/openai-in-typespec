// <auto-generated/>

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Models
{
    /// <summary> The CreateChatCompletionResponseChoiceLogprobs. </summary>
    public partial class CreateChatCompletionResponseChoiceLogprobs
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

        /// <summary> Initializes a new instance of <see cref="CreateChatCompletionResponseChoiceLogprobs"/>. </summary>
        /// <param name="content"></param>
        internal CreateChatCompletionResponseChoiceLogprobs(IEnumerable<ChatCompletionTokenLogprob> content)
        {
            Content = content?.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="CreateChatCompletionResponseChoiceLogprobs"/>. </summary>
        /// <param name="content"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateChatCompletionResponseChoiceLogprobs(IReadOnlyList<ChatCompletionTokenLogprob> content, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateChatCompletionResponseChoiceLogprobs"/> for deserialization. </summary>
        internal CreateChatCompletionResponseChoiceLogprobs()
        {
        }

        /// <summary> Gets the content. </summary>
        public IReadOnlyList<ChatCompletionTokenLogprob> Content { get; }
    }
}

