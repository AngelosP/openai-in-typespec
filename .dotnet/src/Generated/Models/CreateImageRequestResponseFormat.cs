// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Models
{
    /// <summary> Enum for response_format in CreateImageRequest. </summary>
    public readonly partial struct CreateImageRequestResponseFormat : IEquatable<CreateImageRequestResponseFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreateImageRequestResponseFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateImageRequestResponseFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UrlValue = "url";
        private const string B64JsonValue = "b64_json";

        /// <summary> url. </summary>
        public static CreateImageRequestResponseFormat Url { get; } = new CreateImageRequestResponseFormat(UrlValue);
        /// <summary> b64_json. </summary>
        public static CreateImageRequestResponseFormat B64Json { get; } = new CreateImageRequestResponseFormat(B64JsonValue);
        /// <summary> Determines if two <see cref="CreateImageRequestResponseFormat"/> values are the same. </summary>
        public static bool operator ==(CreateImageRequestResponseFormat left, CreateImageRequestResponseFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateImageRequestResponseFormat"/> values are not the same. </summary>
        public static bool operator !=(CreateImageRequestResponseFormat left, CreateImageRequestResponseFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreateImageRequestResponseFormat"/>. </summary>
        public static implicit operator CreateImageRequestResponseFormat(string value) => new CreateImageRequestResponseFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateImageRequestResponseFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateImageRequestResponseFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

