/*
 * This file was automatically generated from an OpenAPI .yaml file.
 * Edits made directly to this file will be lost.
 */

import "../chat";
import "../common";
import "./custom.tsp";

using TypeSpec.OpenAPI;

namespace OpenAI;

model CreateFineTuningJobRequest {
  /**
   * The name of the model to fine-tune. You can select one of the
   * [supported models](/docs/guides/fine-tuning#which-models-can-be-fine-tuned).
   */
  @extension("x-oaiTypeLabel", "string")
  `model`:
    | string
    | "babbage-002"
    | "davinci-002"
    | "gpt-3.5-turbo"
    | "gpt-4o-mini";

  @doc("""
    The ID of an uploaded file that contains training data.
    
    See [upload file](/docs/api-reference/files/create) for how to upload a file.
    
    Your dataset must be formatted as a JSONL file. Additionally, you must upload your file with the purpose `fine-tune`.
    
    The contents of the file should differ depending on if the model uses the [chat](/docs/api-reference/fine-tuning/chat-input), [completions](/docs/api-reference/fine-tuning/completions-input) format, or if the fine-tuning method uses the [preference](/docs/api-reference/fine-tuning/preference-input) format.
    
    See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.
    """)
  training_file: string;

  #deprecated "This field is marked as deprecated."
  @doc("""
    The hyperparameters used for the fine-tuning job.
    This value is now deprecated in favor of `method`, and should be passed in under the `method` parameter.
    """)
  hyperparameters?: {
    /**
     * Number of examples in each batch. A larger batch size means that model parameters
     * are updated less frequently, but with lower variance.
     */
    batch_size?: "auto" | int32 = "auto";

    /**
     * Scaling factor for the learning rate. A smaller learning rate may be useful to avoid
     * overfitting.
     */
    learning_rate_multiplier?: "auto" | float32 = "auto";

    /**
     * The number of epochs to train the model for. An epoch refers to one full cycle
     * through the training dataset.
     */
    n_epochs?: "auto" | int32 = "auto";
  };

  @doc("""
    A string of up to 64 characters that will be added to your fine-tuned model name.
    
    For example, a `suffix` of "custom-model-name" would produce a model name like `ft:gpt-4o-mini:openai:custom-model-name:7p4lURel`.
    """)
  @minLength(1)
  @maxLength(64)
  suffix?: string | null = null;

  @doc("""
    The ID of an uploaded file that contains validation data.
    
    If you provide this file, the data is used to generate validation
    metrics periodically during fine-tuning. These metrics can be viewed in
    the fine-tuning results file.
    The same data should not be present in both train and validation files.
    
    Your dataset must be formatted as a JSONL file. You must upload your file with the purpose `fine-tune`.
    
    See the [fine-tuning guide](/docs/guides/fine-tuning) for more details.
    """)
  validation_file?: string | null;

  // Tool customization: establish a discriminated type basis
  /** A list of integrations to enable for your fine-tuning job. */
  integrations?: CreateFineTuningJobRequestIntegration[] | null;

  /**
   * The seed controls the reproducibility of the job. Passing in the same seed and job parameters should produce the same results, but may differ in rare cases.
   * If a seed is not specified, one will be generated for you.
   */
  @minValue(0)
  @maxValue(2147483647)
  seed?: int32 | null;

  method?: FineTuneMethod;
}

model ListPaginatedFineTuningJobsResponse {
  data: FineTuningJob[];
  has_more: boolean;
  object: "list";
}

// Tool customization: Include spec-omitted 'has_more' property
model ListFineTuningJobEventsResponse {
  has_more: boolean;
  data: FineTuningJobEvent[];
  object: "list";
}

model ListFineTuningJobCheckpointsResponse {
  data: FineTuningJobCheckpoint[];
  object: "list";
  first_id?: string | null;
  last_id?: string | null;
  has_more: boolean;
}

// Tool customization: Represent undocumented response 'user_provided_suffix' property
@doc("""
  The `fine_tuning.job` object represents a fine-tuning job that has been created through the API.
  """)
model FineTuningJob {
  /** The descriptive suffix applied to the job, as specified in the job creation request. */
  user_provided_suffix?: string | null;

  /** The object identifier, which can be referenced in the API endpoints. */
  id: string;

  // Tool customization: 'created' and fields ending in '_at' are Unix encoded utcDateTime
  /** The Unix timestamp (in seconds) for when the fine-tuning job was created. */
  @encode("unixTimestamp", int32)
  created_at: utcDateTime;

  @doc("""
    For fine-tuning jobs that have `failed`, this will contain more information on the cause of the failure.
    """)
  error: {
    /** A machine-readable error code. */
    code: string;

    /** A human-readable error message. */
    message: string;

    @doc("""
      The parameter that was invalid, usually `training_file` or `validation_file`. This field will be null if the failure was not parameter-specific.
      """)
    param: string | null;
  } | null;

  /** The name of the fine-tuned model that is being created. The value will be null if the fine-tuning job is still running. */
  fine_tuned_model: string | null;

  // Tool customization: 'created' and fields ending in '_at' are Unix encoded utcDateTime
  /** The Unix timestamp (in seconds) for when the fine-tuning job was finished. The value will be null if the fine-tuning job is still running. */
  @encode("unixTimestamp", int32)
  finished_at: utcDateTime | null;

  @doc("""
    The hyperparameters used for the fine-tuning job. This value will only be returned when running `supervised` jobs.
    """)
  hyperparameters: {
    /**
     * Number of examples in each batch. A larger batch size means that model parameters
     * are updated less frequently, but with lower variance.
     */
    batch_size?: "auto" | int32 = "auto";

    /**
     * Scaling factor for the learning rate. A smaller learning rate may be useful to avoid
     * overfitting.
     */
    learning_rate_multiplier?: "auto" | float32 = "auto";

    /**
     * The number of epochs to train the model for. An epoch refers to one full cycle
     * through the training dataset.
     */
    n_epochs?: "auto" | int32 = "auto";
  };

  /** The base model that is being fine-tuned. */
  `model`: string;

  /** The object type, which is always "fine_tuning.job". */
  object: "fine_tuning.job";

  /** The organization that owns the fine-tuning job. */
  organization_id: string;

  /** The compiled results file ID(s) for the fine-tuning job. You can retrieve the results with the [Files API](/docs/api-reference/files/retrieve-contents). */
  result_files: string[];

  @doc("""
    The current status of the fine-tuning job, which can be either `validating_files`, `queued`, `running`, `succeeded`, `failed`, or `cancelled`.
    """)
  status:
    | "validating_files"
    | "queued"
    | "running"
    | "succeeded"
    | "failed"
    | "cancelled";

  /** The total number of billable tokens processed by this fine-tuning job. The value will be null if the fine-tuning job is still running. */
  trained_tokens: int32 | null;

  /** The file ID used for training. You can retrieve the training data with the [Files API](/docs/api-reference/files/retrieve-contents). */
  training_file: string;

  /** The file ID used for validation. You can retrieve the validation results with the [Files API](/docs/api-reference/files/retrieve-contents). */
  validation_file: string | null;

  /** A list of integrations to enable for this fine-tuning job. */
  // Tool note: can't automatically apply to nullable: @maxItems(5)
  @extension("x-oaiExpandable", true)
  integrations?: FineTuningIntegration[] | null;

  /** The seed used for the fine-tuning job. */
  seed: int32;

  // Tool customization: 'created' and fields ending in '_at' are Unix encoded utcDateTime
  /** The Unix timestamp (in seconds) for when the fine-tuning job is estimated to finish. The value will be null if the fine-tuning job is not running. */
  @encode("unixTimestamp", int32)
  estimated_finish?: utcDateTime | null;

  method?: FineTuneMethod;
}

// Tool customization: Convert to instantiation of discriminated type
model FineTuningIntegrationWandb extends FineTuningIntegration {
  /** The type of the integration being enabled for the fine-tuning job */
  type: "wandb";

  /**
   * The settings for your integration with Weights and Biases. This payload specifies the project that
   * metrics will be sent to. Optionally, you can set an explicit display name for your run, add tags
   * to your run, and set a default entity (team, username, etc) to be associated with your run.
   */
  wandb: {
    /** The name of the project that the new run will be created under. */
    project: string;

    /** A display name to set for the run. If not set, we will use the Job ID as the name. */
    name?: string | null;

    /**
     * The entity to use for the run. This allows you to set the team or username of the WandB user that you would
     * like associated with the run. If not set, the default entity for the registered WandB API key is used.
     */
    entity?: string | null;

    /**
     * A list of tags to be attached to the newly created run. These tags are passed through directly to WandB. Some
     * default tags are generated by OpenAI: "openai/finetune", "openai/{base-model}", "openai/{ftjob-abcdef}".
     */
    tags?: string[];
  };
}

/** Fine-tuning job event object */
model FineTuningJobEvent {
  /** The object type, which is always "fine_tuning.job.event". */
  object: "fine_tuning.job.event";

  /** The object identifier. */
  id: string;

  // Tool customization: 'created' and fields ending in '_at' are Unix encoded utcDateTime
  /** The Unix timestamp (in seconds) for when the fine-tuning job was created. */
  @encode("unixTimestamp", int32)
  created_at: utcDateTime;

  /** The log level of the event. */
  level: "info" | "warn" | "error";

  /** The message of the event. */
  message: string;

  /** The type of event. */
  type?: "message" | "metrics";

  /** The data associated with the event. */
  data?: unknown;
}

@doc("""
  The `fine_tuning.job.checkpoint` object represents a model checkpoint for a fine-tuning job that is ready to use.
  """)
model FineTuningJobCheckpoint {
  /** The checkpoint identifier, which can be referenced in the API endpoints. */
  id: string;

  // Tool customization: 'created' and fields ending in '_at' are Unix encoded utcDateTime
  /** The Unix timestamp (in seconds) for when the checkpoint was created. */
  @encode("unixTimestamp", int32)
  created_at: utcDateTime;

  /** The name of the fine-tuned checkpoint model that is created. */
  fine_tuned_model_checkpoint: string;

  /** The step number that the checkpoint was created at. */
  step_number: int32;

  /** Metrics at the step number during the fine-tuning job. */
  metrics: {
    step?: float32;
    train_loss?: float32;
    train_mean_token_accuracy?: float32;
    valid_loss?: float32;
    valid_mean_token_accuracy?: float32;
    full_valid_loss?: float32;
    full_valid_mean_token_accuracy?: float32;
  };

  /** The name of the fine-tuning job that this checkpoint was created from. */
  fine_tuning_job_id: string;

  /** The object type, which is always "fine_tuning.job.checkpoint". */
  object: "fine_tuning.job.checkpoint";
}

model FineTuneChatCompletionRequestAssistantMessage
  extends ChatCompletionRequestAssistantMessage {}

/** The per-line training example of a fine-tuning input file for chat models using the supervised method. */
model FineTuneChatRequestInput {
  @minItems(1)
  @extension("x-oaiExpandable", true)
  messages?: (
    | ChatCompletionRequestSystemMessage
    | ChatCompletionRequestUserMessage
    | FineTuneChatCompletionRequestAssistantMessage
    | ChatCompletionRequestToolMessage
    | ChatCompletionRequestFunctionMessage)[];

  /** A list of tools the model may generate JSON inputs for. */
  tools?: ChatCompletionTool[];

  parallel_tool_calls?: ParallelToolCalls = true;

  /** A list of functions the model may generate JSON inputs for. */
  #deprecated "This field is marked as deprecated."
  @minItems(1)
  @maxItems(128)
  functions?: ChatCompletionFunctions[];
}

/** The per-line training example of a fine-tuning input file for completions models */
model FineTuneCompletionRequestInput {
  /** The input prompt for this training example. */
  prompt?: string;

  /** The desired completion for this training example. */
  completion?: string;
}

/** Configuration for the DPO fine-tuning method. */
model FineTuneDPOMethod {
  /** The hyperparameters used for the fine-tuning job. */
  hyperparameters?: {
    /** The beta value for the DPO method. A higher beta value will increase the weight of the penalty between the policy and reference model. */
    beta?: "auto" | float32 = "auto";

    /** Number of examples in each batch. A larger batch size means that model parameters are updated less frequently, but with lower variance. */
    batch_size?: "auto" | int32 = "auto";

    /** Scaling factor for the learning rate. A smaller learning rate may be useful to avoid overfitting. */
    learning_rate_multiplier?: "auto" | float32 = "auto";

    /** The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset. */
    n_epochs?: "auto" | int32 = "auto";
  };
}

/** The method used for fine-tuning. */
model FineTuneMethod {
  @doc("""
    The type of method. Is either `supervised` or `dpo`.
    """)
  type?: "supervised" | "dpo";

  supervised?: FineTuneSupervisedMethod;
  dpo?: FineTuneDPOMethod;
}

/** The per-line training example of a fine-tuning input file for chat models using the dpo method. */
model FineTunePreferenceRequestInput {
  input?: {
    @minItems(1)
    @extension("x-oaiExpandable", true)
    messages?: (
      | ChatCompletionRequestSystemMessage
      | ChatCompletionRequestUserMessage
      | FineTuneChatCompletionRequestAssistantMessage
      | ChatCompletionRequestToolMessage
      | ChatCompletionRequestFunctionMessage)[];

    /** A list of tools the model may generate JSON inputs for. */
    tools?: ChatCompletionTool[];

    parallel_tool_calls?: ParallelToolCalls = true;
  };

  /** The preferred completion message for the output. */
  @maxItems(1)
  @extension("x-oaiExpandable", true)
  preferred_completion?: ChatCompletionRequestAssistantMessage[];

  /** The non-preferred completion message for the output. */
  @maxItems(1)
  @extension("x-oaiExpandable", true)
  non_preferred_completion?: ChatCompletionRequestAssistantMessage[];
}

/** Configuration for the supervised fine-tuning method. */
model FineTuneSupervisedMethod {
  /** The hyperparameters used for the fine-tuning job. */
  hyperparameters?: {
    /** Number of examples in each batch. A larger batch size means that model parameters are updated less frequently, but with lower variance. */
    batch_size?: "auto" | int32 = "auto";

    /** Scaling factor for the learning rate. A smaller learning rate may be useful to avoid overfitting. */
    learning_rate_multiplier?: "auto" | float32 = "auto";

    /** The number of epochs to train the model for. An epoch refers to one full cycle through the training dataset. */
    n_epochs?: "auto" | int32 = "auto";
  };
}
