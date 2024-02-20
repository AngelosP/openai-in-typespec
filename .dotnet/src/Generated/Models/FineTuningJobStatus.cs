// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Models
{
    /// <summary> Enum for status in FineTuningJob. </summary>
    public readonly partial struct FineTuningJobStatus : IEquatable<FineTuningJobStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FineTuningJobStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FineTuningJobStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatedValue = "created";
        private const string PendingValue = "pending";
        private const string RunningValue = "running";
        private const string SucceededValue = "succeeded";
        private const string FailedValue = "failed";
        private const string CancelledValue = "cancelled";

        /// <summary> created. </summary>
        public static FineTuningJobStatus Created { get; } = new FineTuningJobStatus(CreatedValue);
        /// <summary> pending. </summary>
        public static FineTuningJobStatus Pending { get; } = new FineTuningJobStatus(PendingValue);
        /// <summary> running. </summary>
        public static FineTuningJobStatus Running { get; } = new FineTuningJobStatus(RunningValue);
        /// <summary> succeeded. </summary>
        public static FineTuningJobStatus Succeeded { get; } = new FineTuningJobStatus(SucceededValue);
        /// <summary> failed. </summary>
        public static FineTuningJobStatus Failed { get; } = new FineTuningJobStatus(FailedValue);
        /// <summary> cancelled. </summary>
        public static FineTuningJobStatus Cancelled { get; } = new FineTuningJobStatus(CancelledValue);
        /// <summary> Determines if two <see cref="FineTuningJobStatus"/> values are the same. </summary>
        public static bool operator ==(FineTuningJobStatus left, FineTuningJobStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FineTuningJobStatus"/> values are not the same. </summary>
        public static bool operator !=(FineTuningJobStatus left, FineTuningJobStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FineTuningJobStatus"/>. </summary>
        public static implicit operator FineTuningJobStatus(string value) => new FineTuningJobStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FineTuningJobStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FineTuningJobStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

