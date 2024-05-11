// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.Internal.Models
{
    /// <summary> Enum for detail in InternalMessageContentImageUrlObjectImageUrl. </summary>
    internal readonly partial struct InternalMessageContentImageUrlObjectImageUrlDetail : IEquatable<InternalMessageContentImageUrlObjectImageUrlDetail>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InternalMessageContentImageUrlObjectImageUrlDetail"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InternalMessageContentImageUrlObjectImageUrlDetail(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "auto";
        private const string LowValue = "low";
        private const string HighValue = "high";

        /// <summary> auto. </summary>
        public static InternalMessageContentImageUrlObjectImageUrlDetail Auto { get; } = new InternalMessageContentImageUrlObjectImageUrlDetail(AutoValue);
        /// <summary> low. </summary>
        public static InternalMessageContentImageUrlObjectImageUrlDetail Low { get; } = new InternalMessageContentImageUrlObjectImageUrlDetail(LowValue);
        /// <summary> high. </summary>
        public static InternalMessageContentImageUrlObjectImageUrlDetail High { get; } = new InternalMessageContentImageUrlObjectImageUrlDetail(HighValue);
        /// <summary> Determines if two <see cref="InternalMessageContentImageUrlObjectImageUrlDetail"/> values are the same. </summary>
        public static bool operator ==(InternalMessageContentImageUrlObjectImageUrlDetail left, InternalMessageContentImageUrlObjectImageUrlDetail right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InternalMessageContentImageUrlObjectImageUrlDetail"/> values are not the same. </summary>
        public static bool operator !=(InternalMessageContentImageUrlObjectImageUrlDetail left, InternalMessageContentImageUrlObjectImageUrlDetail right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="InternalMessageContentImageUrlObjectImageUrlDetail"/>. </summary>
        public static implicit operator InternalMessageContentImageUrlObjectImageUrlDetail(string value) => new InternalMessageContentImageUrlObjectImageUrlDetail(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InternalMessageContentImageUrlObjectImageUrlDetail other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InternalMessageContentImageUrlObjectImageUrlDetail other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
