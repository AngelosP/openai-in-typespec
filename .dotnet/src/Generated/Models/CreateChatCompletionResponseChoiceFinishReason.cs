// <auto-generated/>

using System;
using System.ComponentModel;

namespace OpenAI.Models
{
    /// <summary> Enum for finish_reason in CreateChatCompletionResponseChoice. </summary>
    public readonly partial struct CreateChatCompletionResponseChoiceFinishReason : IEquatable<CreateChatCompletionResponseChoiceFinishReason>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CreateChatCompletionResponseChoiceFinishReason"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CreateChatCompletionResponseChoiceFinishReason(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StopValue = "stop";
        private const string LengthValue = "length";
        private const string ToolCallsValue = "tool_calls";
        private const string ContentFilterValue = "content_filter";
        private const string FunctionCallValue = "function_call";

        /// <summary> stop. </summary>
        public static CreateChatCompletionResponseChoiceFinishReason Stop { get; } = new CreateChatCompletionResponseChoiceFinishReason(StopValue);
        /// <summary> length. </summary>
        public static CreateChatCompletionResponseChoiceFinishReason Length { get; } = new CreateChatCompletionResponseChoiceFinishReason(LengthValue);
        /// <summary> tool_calls. </summary>
        public static CreateChatCompletionResponseChoiceFinishReason ToolCalls { get; } = new CreateChatCompletionResponseChoiceFinishReason(ToolCallsValue);
        /// <summary> content_filter. </summary>
        public static CreateChatCompletionResponseChoiceFinishReason ContentFilter { get; } = new CreateChatCompletionResponseChoiceFinishReason(ContentFilterValue);
        /// <summary> function_call. </summary>
        public static CreateChatCompletionResponseChoiceFinishReason FunctionCall { get; } = new CreateChatCompletionResponseChoiceFinishReason(FunctionCallValue);
        /// <summary> Determines if two <see cref="CreateChatCompletionResponseChoiceFinishReason"/> values are the same. </summary>
        public static bool operator ==(CreateChatCompletionResponseChoiceFinishReason left, CreateChatCompletionResponseChoiceFinishReason right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CreateChatCompletionResponseChoiceFinishReason"/> values are not the same. </summary>
        public static bool operator !=(CreateChatCompletionResponseChoiceFinishReason left, CreateChatCompletionResponseChoiceFinishReason right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CreateChatCompletionResponseChoiceFinishReason"/>. </summary>
        public static implicit operator CreateChatCompletionResponseChoiceFinishReason(string value) => new CreateChatCompletionResponseChoiceFinishReason(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CreateChatCompletionResponseChoiceFinishReason other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CreateChatCompletionResponseChoiceFinishReason other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

