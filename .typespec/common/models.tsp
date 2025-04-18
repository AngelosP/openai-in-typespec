/*
 * This file was automatically generated from an OpenAPI .yaml file.
 * Edits made directly to this file will be lost.
 */

import "./custom.tsp";

using TypeSpec.OpenAPI;

namespace OpenAI;

model Error {
  code: string | null;
  message: string;
  param: string | null;
  type: string;
}

// Tool customization: apply error decorator
@error
model ErrorResponse {
  error: Error;
}

// Tool customization: Wrap for reuse
@doc("""
  The parameters the functions accepts, described as a JSON Schema object. See the [guide](/docs/guides/function-calling) for examples, and the [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format. 
  
  Omitting `parameters` defines a function with an empty parameter list.
  """)
model FunctionParametersCommon {
  /**
   * The parameters the functions accepts, described as a JSON Schema object. See the [guide](/docs/guides/function-calling) for examples, and the [JSON Schema reference](https://json-schema.org/understanding-json-schema/) for documentation about the format.
   *
   * Omitting `parameters` defines a function with an empty parameter list.
   */
  parameters?: unknown;
}

model FunctionObject {
  /** A description of what the function does, used by the model to choose when and how to call the function. */
  description?: string;

  /** The name of the function to be called. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64. */
  name: string;

  ...FunctionParametersCommon;

  @doc("""
    Whether to enable strict schema adherence when generating the function call. If set to true, the model will follow the exact schema defined in the `parameters` field. Only a subset of JSON Schema is supported when `strict` is `true`. Learn more about Structured Outputs in the [function calling guide](docs/guides/function-calling).
    """)
  strict?: boolean | null = false;
}

// Tool customization: Wrap for reuse
/**
 * Set of 16 key-value pairs that can be attached to an object. This can be
 * useful for storing additional information about the object in a structured
 * format, and querying for objects via API or the dashboard.
 *
 * Keys are strings with a maximum length of 64 characters. Values are strings
 * with a maximum length of 512 characters.
 */
model MetadataPropertyForRequest {
  /**
   * Set of 16 key-value pairs that can be attached to an object. This can be
   * useful for storing additional information about the object in a structured
   * format, and querying for objects via API or the dashboard.
   *
   * Keys are strings with a maximum length of 64 characters. Values are strings
   * with a maximum length of 512 characters.
   */
  @extension("x-oaiTypeLabel", "map")
  metadata?: Record<string>;
}
model MetadataPropertyForResponse {
  /**
   * Set of 16 key-value pairs that can be attached to an object. This can be
   * useful for storing additional information about the object in a structured
   * format, and querying for objects via API or the dashboard.
   *
   * Keys are strings with a maximum length of 64 characters. Values are strings
   * with a maximum length of 512 characters.
   */
  @extension("x-oaiTypeLabel", "map")
  metadata: Record<string> | null;
}

// Tool customization: establish a common, discriminated union
model ResponseFormatText extends OmniTypedResponseFormat {
  @doc("""
    The type of response format being defined: `text`
    """)
  type: "text";
}

// Tool customization: establish a common, discriminated union
model ResponseFormatJsonObject extends OmniTypedResponseFormat {
  @doc("""
    The type of response format being defined: `json_object`
    """)
  type: "json_object";
}

/** The schema for the response format, described as a JSON Schema object. */
model ResponseFormatJsonSchemaSchema is Record<unknown>;

// Tool customization: establish a common, discriminated union
model ResponseFormatJsonSchema extends OmniTypedResponseFormat {
  @doc("""
    The type of response format being defined: `json_schema`
    """)
  type: "json_schema";

  json_schema: {
    /** A description of what the response format is for, used by the model to determine how to respond in the format. */
    description?: string;

    /** The name of the response format. Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64. */
    name: string;

    schema?: ResponseFormatJsonSchemaSchema;

    @doc("""
      Whether to enable strict schema adherence when generating the output. If set to true, the model will always follow the exact schema defined in the `schema` field. Only a subset of JSON Schema is supported when `strict` is `true`. To learn more, read the [Structured Outputs guide](/docs/guides/structured-outputs).
      """)
    strict?: boolean | null = false;
  };
}

/** Whether to enable [parallel function calling](/docs/guides/function-calling#configuring-parallel-function-calling) during tool use. */
scalar ParallelToolCalls extends boolean;

/** Usage statistics for the completion request. */
model CompletionUsage {
  /** Number of tokens in the generated completion. */
  completion_tokens: int32;

  /** Number of tokens in the prompt. */
  prompt_tokens: int32;

  /** Total number of tokens used in the request (prompt + completion). */
  total_tokens: int32;

  /** Breakdown of tokens used in a completion. */
  completion_tokens_details?: {
    /**
     * When using Predicted Outputs, the number of tokens in the
     * prediction that appeared in the completion.
     */
    accepted_prediction_tokens?: int32;

    /** Audio input tokens generated by the model. */
    audio_tokens?: int32;

    /** Tokens generated by the model for reasoning. */
    reasoning_tokens?: int32;

    /**
     * When using Predicted Outputs, the number of tokens in the
     * prediction that did not appear in the completion. However, like
     * reasoning tokens, these tokens are still counted in the total
     * completion tokens for purposes of billing, output, and context window
     * limits.
     */
    rejected_prediction_tokens?: int32;
  };

  /** Breakdown of tokens used in the prompt. */
  prompt_tokens_details?: {
    /** Audio input tokens present in the prompt. */
    audio_tokens?: int32;

    /** Cached tokens present in the prompt. */
    cached_tokens?: int32;
  };
}

@doc("""
  Options for streaming response. Only set this when you set `stream: true`.
  """)
model ChatCompletionStreamOptions {
  @doc("""
    If set, an additional chunk will be streamed before the `data: [DONE]` message. The `usage` field on this chunk shows the token usage statistics for the entire request, and the `choices` field will always be an empty array. All other chunks will also include a `usage` field, but with a null value.
    """)
  include_usage?: boolean;
}
