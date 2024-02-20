// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Models
{
    /// <summary> Enum for model in CreateImageRequest. </summary>
    public readonly partial struct CreateImageRequestModel : IEquatable<CreateImageRequestModel>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreateImageRequestModel"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateImageRequestModel(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DallE2Value = "dall-e-2";
        private const string DallE3Value = "dall-e-3";

        /// <summary> dall-e-2. </summary>
        public static CreateImageRequestModel DallE2 { get; } = new CreateImageRequestModel(DallE2Value);
        /// <summary> dall-e-3. </summary>
        public static CreateImageRequestModel DallE3 { get; } = new CreateImageRequestModel(DallE3Value);
        /// <summary> Determines if two <see cref="CreateImageRequestModel"/> values are the same. </summary>
        public static bool operator ==(CreateImageRequestModel left, CreateImageRequestModel right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateImageRequestModel"/> values are not the same. </summary>
        public static bool operator !=(CreateImageRequestModel left, CreateImageRequestModel right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreateImageRequestModel"/>. </summary>
        public static implicit operator CreateImageRequestModel(string value) => new CreateImageRequestModel(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateImageRequestModel other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateImageRequestModel other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

