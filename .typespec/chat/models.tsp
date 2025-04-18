/*
 * This file was automatically generated from an OpenAPI .yaml file.
 * Edits made directly to this file will be lost.
 */

import "../common";
import "./custom.tsp";

using TypeSpec.OpenAPI;

namespace OpenAI;

// Tool generated type. Extracts from CreateChatCompletionResponse.choices
alias CreateChatCompletionResponseChoice = {
  @doc("""
    The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,
    `length` if the maximum number of tokens specified in the request was reached,
    `content_filter` if content was omitted due to a flag from our content filters,
    `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
    """)
  finish_reason:
    | "stop"
    | "length"
    | "tool_calls"
    | "content_filter"
    | "function_call";

  /** The index of the choice in the list of choices. */
  index: int32;

  message: ChatCompletionResponseMessage;

  /** Log probability information for the choice. */
  logprobs: {
    // Tool customization: Apply read-only visibility via annotation
    /** A list of message content tokens with log probability information. */
    @visibility("read")
    content: ChatCompletionTokenLogprob[] | null;

    // Tool customization: Apply read-only visibility via annotation
    /** A list of message refusal tokens with log probability information. */
    @visibility("read")
    refusal: ChatCompletionTokenLogprob[] | null;
  } | null;
};

// Tool generated type. Extracts from CreateChatCompletionFunctionResponse.choices
alias CreateChatCompletionFunctionResponseChoice = {
  @doc("""
    The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence, `length` if the maximum number of tokens specified in the request was reached, `content_filter` if content was omitted due to a flag from our content filters, or `function_call` if the model called a function.
    """)
  finish_reason: "stop" | "length" | "function_call" | "content_filter";

  /** The index of the choice in the list of choices. */
  index: int32;

  message: ChatCompletionResponseMessage;
};

// Tool generated type. Extracts from ChatCompletionTokenLogprob.top_logprobs
alias ChatCompletionTokenLogprobTopLogprob = {
  /** The token. */
  token: string;

  @doc("""
    The log probability of this token, if it is within the top 20 most likely tokens. Otherwise, the value `-9999.0` is used to signify that the token is very unlikely.
    """)
  logprob: float32;

  @doc("""
    A list of integers representing the UTF-8 bytes representation of the token. Useful in instances where characters are represented by multiple tokens and their byte representations must be combined to generate the correct text representation. Can be `null` if there is no bytes representation for the token.
    """)
  bytes: int32[] | null;
};

// Tool generated type. Extracts from CreateChatCompletionStreamResponse.choices
alias CreateChatCompletionStreamResponseChoice = {
  delta: ChatCompletionStreamResponseDelta;

  /** Log probability information for the choice. */
  logprobs?: {
    // Tool customization: Apply read-only visibility via annotation
    /** A list of message content tokens with log probability information. */
    @visibility("read")
    content: ChatCompletionTokenLogprob[] | null;

    // Tool customization: Apply read-only visibility via annotation
    /** A list of message refusal tokens with log probability information. */
    @visibility("read")
    refusal: ChatCompletionTokenLogprob[] | null;
  } | null;

  @doc("""
    The reason the model stopped generating tokens. This will be `stop` if the model hit a natural stop point or a provided stop sequence,
    `length` if the maximum number of tokens specified in the request was reached,
    `content_filter` if content was omitted due to a flag from our content filters,
    `tool_calls` if the model called a tool, or `function_call` (deprecated) if the model called a function.
    """)
  finish_reason:
    | "stop"
    | "length"
    | "tool_calls"
    | "content_filter"
    | "function_call"
    | null;

  /** The index of the choice in the list of choices. */
  index: int32;
};

model CreateChatCompletionRequest {
  /**
   * A list of messages comprising the conversation so far. Depending on the
   * [model](/docs/models) you use, different message types (modalities) are
   * supported, like [text](/docs/guides/text-generation),
   * [images](/docs/guides/vision), and [audio](/docs/guides/audio).
   */
  @minItems(1)
  messages: ChatCompletionRequestMessage[];

  /** ID of the model to use. See the [model endpoint compatibility](/docs/models#model-endpoint-compatibility) table for details on which models work with the Chat API. */
  @extension("x-oaiTypeLabel", "string")
  `model`:
    | string
    | "o3-mini"
    | "o3-mini-2025-01-31"
    | "o1"
    | "o1-2024-12-17"
    | "o1-preview"
    | "o1-preview-2024-09-12"
    | "o1-mini"
    | "o1-mini-2024-09-12"
    | "gpt-4o"
    | "gpt-4o-2024-11-20"
    | "gpt-4o-2024-08-06"
    | "gpt-4o-2024-05-13"
    | "gpt-4o-audio-preview"
    | "gpt-4o-audio-preview-2024-10-01"
    | "gpt-4o-audio-preview-2024-12-17"
    | "gpt-4o-mini-audio-preview"
    | "gpt-4o-mini-audio-preview-2024-12-17"
    | "chatgpt-4o-latest"
    | "gpt-4o-mini"
    | "gpt-4o-mini-2024-07-18"
    | "gpt-4-turbo"
    | "gpt-4-turbo-2024-04-09"
    | "gpt-4-0125-preview"
    | "gpt-4-turbo-preview"
    | "gpt-4-1106-preview"
    | "gpt-4-vision-preview"
    | "gpt-4"
    | "gpt-4-0314"
    | "gpt-4-0613"
    | "gpt-4-32k"
    | "gpt-4-32k-0314"
    | "gpt-4-32k-0613"
    | "gpt-3.5-turbo"
    | "gpt-3.5-turbo-16k"
    | "gpt-3.5-turbo-0301"
    | "gpt-3.5-turbo-0613"
    | "gpt-3.5-turbo-1106"
    | "gpt-3.5-turbo-0125"
    | "gpt-3.5-turbo-16k-0613";

  /**
   * Whether or not to store the output of this chat completion request for
   * use in our [model distillation](/docs/guides/distillation) or
   * [evals](/docs/guides/evals) products.
   */
  store?: boolean | null = false;

  @doc("""
    **o1 models only** 
    
    Constrains effort on reasoning for 
    [reasoning models](https://platform.openai.com/docs/guides/reasoning).
    Currently supported values are `low`, `medium`, and `high`. Reducing
    reasoning effort can result in faster responses and fewer tokens used
    on reasoning in a response.
    """)
  reasoning_effort?: "low" | "medium" | "high" = "medium";

  ...MetadataPropertyForRequest;

  /**
   * Number between -2.0 and 2.0. Positive values penalize new tokens based on
   * their existing frequency in the text so far, decreasing the model's
   * likelihood to repeat the same line verbatim.
   */
  @minValue(-2)
  @maxValue(2)
  frequency_penalty?: float32 | null = 0;

  /**
   * Modify the likelihood of specified tokens appearing in the completion.
   *
   * Accepts a JSON object that maps tokens (specified by their token ID in the
   * tokenizer) to an associated bias value from -100 to 100. Mathematically,
   * the bias is added to the logits generated by the model prior to sampling.
   * The exact effect will vary per model, but values between -1 and 1 should
   * decrease or increase likelihood of selection; values like -100 or 100
   * should result in a ban or exclusive selection of the relevant token.
   */
  @extension("x-oaiTypeLabel", "map")
  logit_bias?: Record<int32> | null = null;

  @doc("""
    Whether to return log probabilities of the output tokens or not. If true,
    returns the log probabilities of each output token returned in the
    `content` of `message`.
    """)
  logprobs?: boolean | null = false;

  @doc("""
    An integer between 0 and 20 specifying the number of most likely tokens to
    return at each token position, each with an associated log probability.
    `logprobs` must be set to `true` if this parameter is used.
    """)
  @minValue(0)
  @maxValue(20)
  top_logprobs?: int32 | null;

  #deprecated "This field is marked as deprecated."
  @doc("""
    The maximum number of [tokens](/tokenizer) that can be generated in the
    chat completion. This value can be used to control
    [costs](https://openai.com/api/pricing/) for text generated via API.
    
    This value is now deprecated in favor of `max_completion_tokens`, and is
    not compatible with [o1 series models](/docs/guides/reasoning).
    """)
  max_tokens?: int32 | null;

  /** An upper bound for the number of tokens that can be generated for a completion, including visible output tokens and [reasoning tokens](/docs/guides/reasoning). */
  max_completion_tokens?: int32 | null;

  @doc("""
    How many chat completion choices to generate for each input message. Note that you will be charged based on the number of generated tokens across all of the choices. Keep `n` as `1` to minimize costs.
    """)
  @minValue(1)
  @maxValue(128)
  n?: int32 | null = 1;

  modalities?: ChatCompletionModalities | null;

  // Tool customization: Apply an implied base discriminated type to 'prediction'
  /**
   * Configuration for a [Predicted Output](/docs/guides/predicted-outputs),
   * which can greatly improve response times when large parts of the model
   * response are known ahead of time. This is most common when you are
   * regenerating a file with only minor changes to most of the content.
   */
  @extension("x-oaiExpandable", true)
  prediction?: ChatOutputPrediction | null;

  @doc("""
    Parameters for audio output. Required when audio output is requested with
    `modalities: ["audio"]`. [Learn more](/docs/guides/audio).
    """)
  @extension("x-oaiExpandable", true)
  audio?: {
    @doc("""
      The voice the model uses to respond. Supported voices are `ash`, `ballad`, `coral`, `sage`, and `verse` (also supported but not recommended are `alloy`, `echo`, and `shimmer`; these voices are less expressive).
      """)
    voice:
      | "alloy"
      | "ash"
      | "ballad"
      | "coral"
      | "echo"
      | "sage"
      | "shimmer"
      | "verse";

    @doc("""
      Specifies the output audio format. Must be one of `wav`, `mp3`, `flac`,
      `opus`, or `pcm16`.
      """)
    format: "wav" | "mp3" | "flac" | "opus" | "pcm16";
  } | null;

  /**
   * Number between -2.0 and 2.0. Positive values penalize new tokens based on
   * whether they appear in the text so far, increasing the model's likelihood
   * to talk about new topics.
   */
  @minValue(-2)
  @maxValue(2)
  presence_penalty?: float32 | null = 0;

  // Tool customization: apply a named union type
  @doc("""
    An object specifying the format that the model must output.
    
    Setting to `{ "type": "json_schema", "json_schema": {...} }` enables
    Structured Outputs which ensures the model will match your supplied JSON
    schema. Learn more in the [Structured Outputs
    guide](/docs/guides/structured-outputs).
    
    Setting to `{ "type": "json_object" }` enables JSON mode, which ensures
    the message the model generates is valid JSON.
    
    **Important:** when using JSON mode, you **must** also instruct the model
    to produce JSON yourself via a system or user message. Without this, the
    model may generate an unending stream of whitespace until the generation
    reaches the token limit, resulting in a long-running and seemingly "stuck"
    request. Also note that the message content may be partially cut off if
    `finish_reason="length"`, which indicates the generation exceeded
    `max_tokens` or the conversation exceeded the max context length.
    """)
  @extension("x-oaiExpandable", true)
  response_format?: ChatResponseFormat;

  @doc("""
    This feature is in Beta.
    If specified, our system will make a best effort to sample deterministically, such that repeated requests with the same `seed` and parameters should return the same result.
    Determinism is not guaranteed, and you should refer to the `system_fingerprint` response parameter to monitor changes in the backend.
    """)
  seed?: int64 | null;

  /**
   * Specifies the latency tier to use for processing the request. This parameter is relevant for customers subscribed to the scale tier service:
   *   - If set to 'auto', and the Project is Scale tier enabled, the system will utilize scale tier credits until they are exhausted.
   *   - If set to 'auto', and the Project is not Scale tier enabled, the request will be processed using the default service tier with a lower uptime SLA and no latency guarantee.
   *   - If set to 'default', the request will be processed using the default service tier with a lower uptime SLA and no latency guarantee.
   *   - When not set, the default behavior is 'auto'.
   */
  service_tier?: "auto" | "default" | null = "auto";

  /** Up to 4 sequences where the API will stop generating further tokens. */
  stop?: string | string[] | null = null;

  @doc("""
    If set, partial message deltas will be sent, like in ChatGPT. Tokens will be sent as data-only [server-sent events](https://developer.mozilla.org/en-US/docs/Web/API/Server-sent_events/Using_server-sent_events#Event_stream_format) as they become available, with the stream terminated by a `data: [DONE]` message. [Example Python code](https://cookbook.openai.com/examples/how_to_stream_completions).
    """)
  stream?: boolean | null = false;

  stream_options?: ChatCompletionStreamOptions | null = null;

  @doc("""
    What sampling temperature to use, between 0 and 2. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic.
    We generally recommend altering this or `top_p` but not both.
    """)
  @minValue(0)
  @maxValue(2)
  temperature?: float32 | null = 1;

  @doc("""
    An alternative to sampling with temperature, called nucleus sampling,
    where the model considers the results of the tokens with top_p probability
    mass. So 0.1 means only the tokens comprising the top 10% probability mass
    are considered.
    
    We generally recommend altering this or `temperature` but not both.
    """)
  @minValue(0)
  @maxValue(1)
  top_p?: float32 | null = 1;

  /** A list of tools the model may call. Currently, only functions are supported as a tool. Use this to provide a list of functions the model may generate JSON inputs for. A max of 128 functions are supported. */
  tools?: ChatCompletionTool[];

  tool_choice?: ChatCompletionToolChoiceOption;
  parallel_tool_calls?: ParallelToolCalls = true;

  /** A unique identifier representing your end-user, which can help OpenAI to monitor and detect abuse. [Learn more](/docs/guides/safety-best-practices#end-user-ids). */
  user?: string;

  #deprecated "This field is marked as deprecated."
  @doc("""
    Deprecated in favor of `tool_choice`.
    
    Controls which (if any) function is called by the model.
    
    `none` means the model will not call a function and instead generates a
    message.
    
    `auto` means the model can pick between generating a message or calling a
    function.
    
    Specifying a particular function via `{"name": "my_function"}` forces the
    model to call that function.
    
    `none` is the default when no functions are present. `auto` is the default
    if functions are present.
    """)
  @extension("x-oaiExpandable", true)
  function_call?: "none" | "auto" | ChatCompletionFunctionCallOption;

  #deprecated "This field is marked as deprecated."
  @doc("""
    Deprecated in favor of `tools`.
    
    A list of functions the model may generate JSON inputs for.
    """)
  @minItems(1)
  @maxItems(128)
  functions?: ChatCompletionFunctions[];
}

/** Represents a chat completion response returned by model, based on the provided input. */
model CreateChatCompletionResponse {
  /** A unique identifier for the chat completion. */
  id: string;

  @doc("""
    A list of chat completion choices. Can be more than one if `n` is greater than 1.
    """)
  choices: CreateChatCompletionResponseChoice[];

  // Tool customization: 'created' and fields ending in '_at' are Unix encoded utcDateTime
  /** The Unix timestamp (in seconds) of when the chat completion was created. */
  @encode("unixTimestamp", int32)
  created: utcDateTime;

  /** The model used for the chat completion. */
  `model`: string;

  /** The service tier used for processing the request. */
  service_tier?: "scale" | "default" | null;

  @doc("""
    This fingerprint represents the backend configuration that the model runs with.
    
    Can be used in conjunction with the `seed` request parameter to understand when backend changes have been made that might impact determinism.
    """)
  system_fingerprint?: string;

  @doc("""
    The object type, which is always `chat.completion`.
    """)
  object: "chat.completion";

  usage?: CompletionUsage;
}

model ChatCompletionTool {
  @doc("""
    The type of the tool. Currently, only `function` is supported.
    """)
  type: "function";

  function: FunctionObject;
}

/** Specifies a tool the model should use. Use to force the model to call a specific function. */
model ChatCompletionNamedToolChoice {
  @doc("""
    The type of the tool. Currently, only `function` is supported.
    """)
  type: "function";

  function: {
    /** The name of the function to call. */
    name: string;
  };
}

@doc("""
  Controls which (if any) tool is called by the model.
  `none` means the model will not call any tool and instead generates a message.
  `auto` means the model can pick between generating a message or calling one or more tools.
  `required` means the model must call one or more tools.
  Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.
  
  `none` is the default when no tools are present. `auto` is the default if tools are present.
  """)
@extension("x-oaiExpandable", true)
union ChatCompletionToolChoiceOption {
  "none" | "auto" | "required",
  ChatCompletionNamedToolChoice,
}

/** Learn about [text inputs](/docs/guides/text-generation). */
model ChatCompletionRequestMessageContentPartText {
  /** The type of the content part. */
  type: "text";

  /** The text content. */
  text: string;
}

/** Learn about [image inputs](/docs/guides/vision). */
model ChatCompletionRequestMessageContentPartImage {
  /** The type of the content part. */
  type: "image_url";

  image_url: {
    // Tool customization: url uses the url type
    /** Either a URL of the image or the base64 encoded image data. */
    url: url;

    /** Specifies the detail level of the image. Learn more in the [Vision guide](/docs/guides/vision#low-or-high-fidelity-image-understanding). */
    detail?: "auto" | "low" | "high" = "auto";
  };
}

model ChatCompletionRequestMessageContentPartRefusal {
  /** The type of the content part. */
  type: "refusal";

  /** The refusal message generated by the model. */
  refusal: string;
}

model ChatCompletionMessageToolCall {
  /** The ID of the tool call. */
  id: string;

  @doc("""
    The type of the tool. Currently, only `function` is supported.
    """)
  type: "function";

  /** The function that the model called. */
  function: {
    /** The name of the function to call. */
    name: string;

    /** The arguments to call the function with, as generated by the model in JSON format. Note that the model does not always generate valid JSON, and may hallucinate parameters not defined by your function schema. Validate the arguments in your code before calling your function. */
    arguments: string;
  };
}

// Tool customization: convert to discriminated type
@extension("x-oaiExpandable", true)
@discriminator("role")
model ChatCompletionRequestMessage {
  /** The role of the author of this message. */
  role: string;
}

/** Learn about [audio inputs](/docs/guides/audio). */
model ChatCompletionRequestMessageContentPartAudio {
  @doc("""
    The type of the content part. Always `input_audio`.
    """)
  type: "input_audio";

  input_audio: {
    // Tool customization: use encoded type for audio data
    /** Base64 encoded audio data. */
    @encode("base64")
    data: bytes;

    /** The format of the encoded audio data. Currently supports "wav" and "mp3". */
    format: "wav" | "mp3";
  };
}

@extension("x-oaiExpandable", true)
union ChatCompletionRequestSystemMessageContentPart {
  ChatCompletionRequestMessageContentPartText,
}

@extension("x-oaiExpandable", true)
union ChatCompletionRequestUserMessageContentPart {
  ChatCompletionRequestMessageContentPartText,
  ChatCompletionRequestMessageContentPartImage,
  ChatCompletionRequestMessageContentPartAudio,
}

@extension("x-oaiExpandable", true)
union ChatCompletionRequestAssistantMessageContentPart {
  ChatCompletionRequestMessageContentPartText,
  ChatCompletionRequestMessageContentPartRefusal,
}

@extension("x-oaiExpandable", true)
union ChatCompletionRequestToolMessageContentPart {
  ChatCompletionRequestMessageContentPartText,
}

// Tool customization: apply discriminated type base
@doc("""
  Developer-provided instructions that the model should follow, regardless of
  messages sent by the user. With o1 models and newer, use `developer` messages
  for this purpose instead.
  """)
model ChatCompletionRequestSystemMessage extends ChatCompletionRequestMessage {
  /** The contents of the system message. */
  content: string | ChatCompletionRequestSystemMessageContentPart[];

  @doc("""
    The role of the messages author, in this case `system`.
    """)
  role: "system";

  /** An optional name for the participant. Provides the model information to differentiate between participants of the same role. */
  name?: string;
}

// Tool customization: apply discriminated type base
@doc("""
  Developer-provided instructions that the model should follow, regardless of
  messages sent by the user. With o1 models and newer, `developer` messages
  replace the previous `system` messages.
  """)
model ChatCompletionRequestDeveloperMessage
  extends ChatCompletionRequestMessage {
  /** The contents of the developer message. */
  content: string | ChatCompletionRequestMessageContentPartText[];

  @doc("""
    The role of the messages author, in this case `developer`.
    """)
  role: "developer";

  /** An optional name for the participant. Provides the model information to differentiate between participants of the same role. */
  name?: string;
}

// Tool customization: apply discriminated type base
/**
 * Messages sent by an end user, containing prompts or additional context
 * information.
 */
model ChatCompletionRequestUserMessage extends ChatCompletionRequestMessage {
  /** The contents of the user message. */
  @extension("x-oaiExpandable", true)
  content: string | ChatCompletionRequestUserMessageContentPart[];

  @doc("""
    The role of the messages author, in this case `user`.
    """)
  role: "user";

  /** An optional name for the participant. Provides the model information to differentiate between participants of the same role. */
  name?: string;
}

// Tool customization: apply discriminated type base
/** Messages sent by the model in response to user messages. */
model ChatCompletionRequestAssistantMessage
  extends ChatCompletionRequestMessage {
  @doc("""
    The contents of the assistant message. Required unless `tool_calls` or `function_call` is specified.
    """)
  @extension("x-oaiExpandable", true)
  content?: string | ChatCompletionRequestAssistantMessageContentPart[] | null;

  /** The refusal message by the assistant. */
  refusal?: string | null;

  @doc("""
    The role of the messages author, in this case `assistant`.
    """)
  role: "assistant";

  /** An optional name for the participant. Provides the model information to differentiate between participants of the same role. */
  name?: string;

  /**
   * Data about a previous audio response from the model.
   * [Learn more](/docs/guides/audio).
   */
  @extension("x-oaiExpandable", true)
  audio?: {
    /** Unique identifier for a previous audio response from the model. */
    id: string;
  } | null;

  tool_calls?: ChatCompletionMessageToolCalls;

  // Tool customization: preserve earlier, more intuitive field order
  #deprecated "This field is marked as deprecated."
  @doc("""
    Deprecated and replaced by `tool_calls`. The name and arguments of a function that should be called, as generated by the model.
    """)
  function_call?: {
    name: string;
    arguments: string;
  } | null;
}

// Tool customization: apply discriminated type base
model ChatCompletionRequestToolMessage extends ChatCompletionRequestMessage {
  @doc("""
    The role of the messages author, in this case `tool`.
    """)
  role: "tool";

  /** The contents of the tool message. */
  content: string | ChatCompletionRequestToolMessageContentPart[];

  /** Tool call that this message is responding to. */
  tool_call_id: string;
}

// Tool customization: apply discriminated type base
#deprecated "This field is marked as deprecated."
model ChatCompletionRequestFunctionMessage
  extends ChatCompletionRequestMessage {
  @doc("""
    The role of the messages author, in this case `function`.
    """)
  role: "function";

  /** The contents of the function message. */
  content: string | null;

  /** The name of the function to call. */
  name: string;
}

/** The tool calls generated by the model, such as function calls. */
model ChatCompletionMessageToolCalls is ChatCompletionMessageToolCall[];

@doc("""
  Output types that you would like the model to generate for this request.
  Most models are capable of generating text, which is the default:
  
  `["text"]`
  
  The `gpt-4o-audio-preview` model can also be used to [generate audio](/docs/guides/audio). To
  request that this model generate both text and audio responses, you can
  use:
  
  `["text", "audio"]`
  """)
model ChatCompletionModalities is ("text" | "audio")[];

// Tool customization: convert to enum (and add developer)
/** The role of the author of a message */
enum ChatCompletionRole {
  system,
  developer,
  user,
  assistant,
  tool,
  function,
}

/** Represents a chat completion response returned by model, based on the provided input. */
model CreateChatCompletionFunctionResponse {
  /** A unique identifier for the chat completion. */
  id: string;

  @doc("""
    A list of chat completion choices. Can be more than one if `n` is greater than 1.
    """)
  choices: CreateChatCompletionFunctionResponseChoice[];

  // Tool customization: 'created' and fields ending in '_at' are Unix encoded utcDateTime
  /** The Unix timestamp (in seconds) of when the chat completion was created. */
  @encode("unixTimestamp", int32)
  created: utcDateTime;

  /** The model used for the chat completion. */
  `model`: string;

  @doc("""
    This fingerprint represents the backend configuration that the model runs with.
    
    Can be used in conjunction with the `seed` request parameter to understand when backend changes have been made that might impact determinism.
    """)
  system_fingerprint?: string;

  @doc("""
    The object type, which is always `chat.completion`.
    """)
  object: "chat.completion";

  usage?: CompletionUsage;
}

/** A chat completion message generated by the model. */
model ChatCompletionResponseMessage {
  /** The contents of the message. */
  content: string | null;

  /** The refusal message generated by the model. */
  refusal: string | null;

  tool_calls?: ChatCompletionMessageToolCalls;

  /** The role of the author of this message. */
  role: "assistant";

  // Tool customization: preserve earlier, more intuitive field order
  #deprecated "This field is marked as deprecated."
  @doc("""
    Deprecated and replaced by `tool_calls`. The name and arguments of a function that should be called, as generated by the model.
    """)
  function_call?: {
    name: string;
    arguments: string;
  };

  /**
   * If the audio output modality is requested, this object contains data
   * about the audio response from the model. [Learn more](/docs/guides/audio).
   */
  @extension("x-oaiExpandable", true)
  audio?: {
    /** Unique identifier for this audio response. */
    id: string;

    // Tool customization: 'created' and fields ending in '_at' are Unix encoded utcDateTime
    /**
     * The Unix timestamp (in seconds) for when this audio response will
     * no longer be accessible on the server for use in multi-turn
     * conversations.
     */
    @encode("unixTimestamp", int32)
    expires_at: utcDateTime;

    // Tool customization: use encoded type for audio data
    /**
     * Base64 encoded audio bytes generated by the model, in the format
     * specified in the request.
     */
    @encode("base64")
    data: bytes;

    /** Transcript of the audio generated by the model. */
    transcript: string;
  } | null;
}

model ChatCompletionTokenLogprob {
  /** The token. */
  token: string;

  @doc("""
    The log probability of this token, if it is within the top 20 most likely tokens. Otherwise, the value `-9999.0` is used to signify that the token is very unlikely.
    """)
  logprob: float32;

  @doc("""
    A list of integers representing the UTF-8 bytes representation of the token. Useful in instances where characters are represented by multiple tokens and their byte representations must be combined to generate the correct text representation. Can be `null` if there is no bytes representation for the token.
    """)
  bytes: int32[] | null;

  @doc("""
    List of the most likely tokens and their log probability, at this token position. In rare cases, there may be fewer than the number of requested `top_logprobs` returned.
    """)
  top_logprobs: ChatCompletionTokenLogprobTopLogprob[];
}

@doc("""
  Specifying a particular function via `{"name": "my_function"}` forces the model to call that function.
  """)
model ChatCompletionFunctionCallOption {
  /** The name of the function to call. */
  name: string;
}

#deprecated "This field is marked as deprecated."
model ChatCompletionFunctions {
  /** A description of what the function does, used by the model to choose when and how to call the function. */
  description?: string;

  /** The name of the function to be called. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64. */
  name: string;

  ...FunctionParametersCommon;
}

// Tool customization: Add a missing "audio" to the chat streaming delta definition
/** A chat completion delta generated by streamed model responses. */
model ChatCompletionStreamResponseDelta {
  /** Response audio associated with the streaming chat delta payload. */
  audio?: ChatCompletionMessageAudioChunk;

  /** The contents of the chunk message. */
  content?: string | null;

  // Tool customization: preserve earlier, more intuitive field order
  #deprecated "This field is marked as deprecated."
  @doc("""
    Deprecated and replaced by `tool_calls`. The name and arguments of a function that should be called, as generated by the model.
    """)
  function_call?: {
    name?: string;
    arguments?: string;
  };

  tool_calls?: ChatCompletionMessageToolCallChunk[];

  /** The role of the author of this message. */
  role?: "system" | "user" | "assistant" | "tool";

  /** The refusal message generated by the model. */
  refusal?: string | null;
}

model ChatCompletionMessageToolCallChunk {
  index: int32;

  /** The ID of the tool call. */
  id?: string;

  @doc("""
    The type of the tool. Currently, only `function` is supported.
    """)
  type?: "function";

  function?: {
    /** The name of the function to call. */
    name?: string;

    /** The arguments to call the function with, as generated by the model in JSON format. Note that the model does not always generate valid JSON, and may hallucinate parameters not defined by your function schema. Validate the arguments in your code before calling your function. */
    arguments?: string;
  };
}

/** Represents a streamed chunk of a chat completion response returned by model, based on the provided input. */
model CreateChatCompletionStreamResponse {
  /** A unique identifier for the chat completion. Each chunk has the same ID. */
  id: string;

  @doc("""
    A list of chat completion choices. Can contain more than one elements if `n` is greater than 1. Can also be empty for the
    last chunk if you set `stream_options: {"include_usage": true}`.
    """)
  choices: CreateChatCompletionStreamResponseChoice[];

  // Tool customization: 'created' and fields ending in '_at' are Unix encoded utcDateTime
  /** The Unix timestamp (in seconds) of when the chat completion was created. Each chunk has the same timestamp. */
  @encode("unixTimestamp", int32)
  created: utcDateTime;

  /** The model to generate the completion. */
  `model`: string;

  /** The service tier used for processing the request. */
  service_tier?: "scale" | "default" | null;

  @doc("""
    This fingerprint represents the backend configuration that the model runs with.
    Can be used in conjunction with the `seed` request parameter to understand when backend changes have been made that might impact determinism.
    """)
  system_fingerprint?: string;

  @doc("""
    The object type, which is always `chat.completion.chunk`.
    """)
  object: "chat.completion.chunk";

  @doc("""
    An optional field that will only be present when you set `stream_options: {"include_usage": true}` in your request.
    When present, it contains a null value except for the last chunk which contains the token usage statistics for the entire request.
    """)
  usage?: {
    /** Number of tokens in the generated completion. */
    completion_tokens: int32;

    /** Number of tokens in the prompt. */
    prompt_tokens: int32;

    /** Total number of tokens used in the request (prompt + completion). */
    total_tokens: int32;
  } | null;
}

/** Represents a streamed chunk of a chat completion response returned by model, based on the provided input. */
alias CreateChatCompletionImageResponse = unknown;

// Tool customization: Apply an implied base discriminated type to 'prediction'
/**
 * Static predicted output content, such as the content of a text file that is
 * being regenerated.
 */
model ChatOutputPredictionContent extends ChatOutputPrediction {
  @doc("""
    The type of the predicted content you want to provide. This type is
    currently always `content`.
    """)
  type: "content";

  /**
   * The content that should be matched when generating a model response.
   * If generated tokens would match this content, the entire model response
   * can be returned much more quickly.
   */
  @extension("x-oaiExpandable", true)
  content: string | ChatCompletionRequestMessageContentPartText[];
}
