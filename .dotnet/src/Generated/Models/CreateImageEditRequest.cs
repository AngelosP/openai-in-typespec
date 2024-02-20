// <auto-generated/>

using System;
using OpenAI.ClientShared.Internal;
using System.Collections.Generic;

namespace OpenAI.Models
{
    /// <summary> The CreateImageEditRequest. </summary>
    public partial class CreateImageEditRequest
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

        /// <summary> Initializes a new instance of <see cref="CreateImageEditRequest"/>. </summary>
        /// <param name="image">
        /// The image to edit. Must be a valid PNG file, less than 4MB, and square. If mask is not
        /// provided, image must have transparency, which will be used as the mask.
        /// </param>
        /// <param name="prompt"> A text description of the desired image(s). The maximum length is 1000 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="image"/> or <paramref name="prompt"/> is null. </exception>
        public CreateImageEditRequest(BinaryData image, string prompt)
        {
            if (image is null) throw new ArgumentNullException(nameof(image));
            if (prompt is null) throw new ArgumentNullException(nameof(prompt));

            Image = image;
            Prompt = prompt;
        }

        /// <summary> Initializes a new instance of <see cref="CreateImageEditRequest"/>. </summary>
        /// <param name="image">
        /// The image to edit. Must be a valid PNG file, less than 4MB, and square. If mask is not
        /// provided, image must have transparency, which will be used as the mask.
        /// </param>
        /// <param name="prompt"> A text description of the desired image(s). The maximum length is 1000 characters. </param>
        /// <param name="mask">
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where
        /// `image` should be edited. Must be a valid PNG file, less than 4MB, and have the same dimensions
        /// as `image`.
        /// </param>
        /// <param name="model"> The model to use for image generation. Only `dall-e-2` is supported at this time. </param>
        /// <param name="n"> The number of images to generate. Must be between 1 and 10. </param>
        /// <param name="size"> The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`. </param>
        /// <param name="responseFormat"> The format in which the generated images are returned. Must be one of `url` or `b64_json`. </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect
        /// abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CreateImageEditRequest(BinaryData image, string prompt, BinaryData mask, CreateImageEditRequestModel? model, long? n, CreateImageEditRequestSize? size, CreateImageEditRequestResponseFormat? responseFormat, string user, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Image = image;
            Prompt = prompt;
            Mask = mask;
            Model = model;
            N = n;
            Size = size;
            ResponseFormat = responseFormat;
            User = user;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="CreateImageEditRequest"/> for deserialization. </summary>
        internal CreateImageEditRequest()
        {
        }

        /// <summary>
        /// The image to edit. Must be a valid PNG file, less than 4MB, and square. If mask is not
        /// provided, image must have transparency, which will be used as the mask.
        /// <para>
        /// To assign a byte[] to this property use <see cref="BinaryData.FromBytes(byte[])"/>.
        /// The byte[] will be serialized to a Base64 encoded string.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromBytes(new byte[] { 1, 2, 3 })</term>
        /// <description>Creates a payload of "AQID".</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Image { get; }
        /// <summary> A text description of the desired image(s). The maximum length is 1000 characters. </summary>
        public string Prompt { get; }
        /// <summary>
        /// An additional image whose fully transparent areas (e.g. where alpha is zero) indicate where
        /// `image` should be edited. Must be a valid PNG file, less than 4MB, and have the same dimensions
        /// as `image`.
        /// <para>
        /// To assign a byte[] to this property use <see cref="BinaryData.FromBytes(byte[])"/>.
        /// The byte[] will be serialized to a Base64 encoded string.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromBytes(new byte[] { 1, 2, 3 })</term>
        /// <description>Creates a payload of "AQID".</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData Mask { get; set; }
        /// <summary> The model to use for image generation. Only `dall-e-2` is supported at this time. </summary>
        public CreateImageEditRequestModel? Model { get; set; }
        /// <summary> The number of images to generate. Must be between 1 and 10. </summary>
        public long? N { get; set; }
        /// <summary> The size of the generated images. Must be one of `256x256`, `512x512`, or `1024x1024`. </summary>
        public CreateImageEditRequestSize? Size { get; set; }
        /// <summary> The format in which the generated images are returned. Must be one of `url` or `b64_json`. </summary>
        public CreateImageEditRequestResponseFormat? ResponseFormat { get; set; }
        /// <summary>
        /// A unique identifier representing your end-user, which can help OpenAI to monitor and detect
        /// abuse. [Learn more](/docs/guides/safety-best-practices/end-user-ids).
        /// </summary>
        public string User { get; set; }
    }
}

