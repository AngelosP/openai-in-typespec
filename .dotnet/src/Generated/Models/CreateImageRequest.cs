// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.Collections.Generic;

namespace OpenAI.Models
{
    /// <summary> The CreateImageRequest. </summary>
    public partial class CreateImageRequest
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

        /// <summary> Initializes a new instance of <see cref="CreateImageRequest"/>. </summary>
        /// <param name="prompt">
        /// A text description of the desired image(s). The maximum length is 1000 characters for
        /// `dall-e-2` and 4000 characters for `dall-e-3`.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="prompt"/> is null. </exception>
        public CreateImageRequest(string prompt)
        {
            if (prompt is null) throw new ArgumentNullException(nameof(prompt));

            Prompt = prompt;
        }

        /// <summary> Initializes a new instance of <see cref="CreateImageRequest"/>. </summary>
        /// <param name="prompt">
        /// A text description of the desired image(s). The maximum length is 1000 characters for
        /// `dall-e-2` and 4000 characters for `dall-e-3`.
        /// </param>
        /// <param name="model"> The model to use for image generation. </param>
        /// <param name="n">
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is
        /// supported.
        /// </param>
        /// <param name="quality">
        /// The quality of the image that will be generated. `hd` creates images with finer details and
        /// greater consistency across the image. This param is only supported for `dall-e-3`.
        /// </param>
        /// <param name="responseFormat"> The format in which the generated images are returned. Must be one of `url` or `b64_json`. </param>
        /// <param name="size">
        /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024` for
        /// `dall-e-2`. Must be one of `1024x1024`, `1792x1024`, or `1024x1792` for `dall-e-3` models.
        /// </param>
        /// <param name="style">
        /// The style of the generated images. Must be one of `vivid` or `natural`. Vivid causes the model
        /// to lean towards generating hyper-real and dramatic images. Natural causes the model to produce
        /// more natural, less hyper-real looking images. This param is only supported for `dall-e-3`.
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect
        /// abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateImageRequest(string prompt, CreateImageRequestModel? model, long? n, CreateImageRequestQuality? quality, CreateImageRequestResponseFormat? responseFormat, CreateImageRequestSize? size, CreateImageRequestStyle? style, string user, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Prompt = prompt;
            Model = model;
            N = n;
            Quality = quality;
            ResponseFormat = responseFormat;
            Size = size;
            Style = style;
            User = user;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateImageRequest"/> for deserialization. </summary>
        internal CreateImageRequest()
        {
        }

        /// <summary>
        /// A text description of the desired image(s). The maximum length is 1000 characters for
        /// `dall-e-2` and 4000 characters for `dall-e-3`.
        /// </summary>
        public string Prompt { get; }
        /// <summary> The model to use for image generation. </summary>
        public CreateImageRequestModel? Model { get; set; }
        /// <summary>
        /// The number of images to generate. Must be between 1 and 10. For `dall-e-3`, only `n=1` is
        /// supported.
        /// </summary>
        public long? N { get; set; }
        /// <summary>
        /// The quality of the image that will be generated. `hd` creates images with finer details and
        /// greater consistency across the image. This param is only supported for `dall-e-3`.
        /// </summary>
        public CreateImageRequestQuality? Quality { get; set; }
        /// <summary> The format in which the generated images are returned. Must be one of `url` or `b64_json`. </summary>
        public CreateImageRequestResponseFormat? ResponseFormat { get; set; }
        /// <summary>
        /// The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024` for
        /// `dall-e-2`. Must be one of `1024x1024`, `1792x1024`, or `1024x1792` for `dall-e-3` models.
        /// </summary>
        public CreateImageRequestSize? Size { get; set; }
        /// <summary>
        /// The style of the generated images. Must be one of `vivid` or `natural`. Vivid causes the model
        /// to lean towards generating hyper-real and dramatic images. Natural causes the model to produce
        /// more natural, less hyper-real looking images. This param is only supported for `dall-e-3`.
        /// </summary>
        public CreateImageRequestStyle? Style { get; set; }
        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect
        /// abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// </summary>
        public string User { get; set; }
    }
}

