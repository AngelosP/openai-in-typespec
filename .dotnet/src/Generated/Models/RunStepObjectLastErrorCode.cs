// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Models
{
    /// <summary> Enum for code in RunStepObjectLastError. </summary>
    public readonly partial struct RunStepObjectLastErrorCode : IEquatable<RunStepObjectLastErrorCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RunStepObjectLastErrorCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RunStepObjectLastErrorCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServerErrorValue = "server_error";
        private const string RateLimitExceededValue = "rate_limit_exceeded";

        /// <summary> server_error. </summary>
        public static RunStepObjectLastErrorCode ServerError { get; } = new RunStepObjectLastErrorCode(ServerErrorValue);
        /// <summary> rate_limit_exceeded. </summary>
        public static RunStepObjectLastErrorCode RateLimitExceeded { get; } = new RunStepObjectLastErrorCode(RateLimitExceededValue);
        /// <summary> Determines if two <see cref="RunStepObjectLastErrorCode"/> values are the same. </summary>
        public static bool operator ==(RunStepObjectLastErrorCode left, RunStepObjectLastErrorCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RunStepObjectLastErrorCode"/> values are not the same. </summary>
        public static bool operator !=(RunStepObjectLastErrorCode left, RunStepObjectLastErrorCode right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RunStepObjectLastErrorCode"/>. </summary>
        public static implicit operator RunStepObjectLastErrorCode(string value) => new RunStepObjectLastErrorCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RunStepObjectLastErrorCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RunStepObjectLastErrorCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

