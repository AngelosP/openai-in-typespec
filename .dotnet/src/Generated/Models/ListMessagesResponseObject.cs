// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Models
{
    /// <summary> The ListMessagesResponse_object. </summary>
    public readonly partial struct ListMessagesResponseObject : IEquatable<ListMessagesResponseObject>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ListMessagesResponseObject"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ListMessagesResponseObject(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ListValue = "list";

        /// <summary> list. </summary>
        public static ListMessagesResponseObject List { get; } = new ListMessagesResponseObject(ListValue);
        /// <summary> Determines if two <see cref="ListMessagesResponseObject"/> values are the same. </summary>
        public static bool operator ==(ListMessagesResponseObject left, ListMessagesResponseObject right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ListMessagesResponseObject"/> values are not the same. </summary>
        public static bool operator !=(ListMessagesResponseObject left, ListMessagesResponseObject right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ListMessagesResponseObject"/>. </summary>
        public static implicit operator ListMessagesResponseObject(string value) => new ListMessagesResponseObject(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ListMessagesResponseObject other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ListMessagesResponseObject other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

