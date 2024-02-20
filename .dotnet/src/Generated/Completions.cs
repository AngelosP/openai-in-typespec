// <auto-generated/>

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenAI.Models;

namespace OpenAI
{
    // Data plane generated sub-client.
    /// <summary> The Completions sub-client. </summary>
    public partial class Completions
    {
        private const string AuthorizationHeader = "Authorization";
        private readonly ApiKeyCredential _credential;
        private const string AuthorizationApiKeyPrefix = "Bearer";
        private readonly ClientPipeline _pipeline;
        private readonly Uri _endpoint;

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual ClientPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of Completions for mocking. </summary>
        protected Completions()
        {
        }

        /// <summary> Initializes a new instance of Completions. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="credential"> The key credential to copy. </param>
        /// <param name="endpoint"> OpenAI Endpoint. </param>
        internal Completions(ClientPipeline pipeline, ApiKeyCredential credential, Uri endpoint)
        {
            _pipeline = pipeline;
            _credential = credential;
            _endpoint = endpoint;
        }

        /// <summary> Creates a completion for the provided prompt and parameters. </summary>
        /// <param name="createCompletionRequest"> The <see cref="CreateCompletionRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createCompletionRequest"/> is null. </exception>
        public virtual async Task<ClientResult<CreateCompletionResponse>> CreateCompletionAsync(CreateCompletionRequest createCompletionRequest)
        {
            if (createCompletionRequest is null) throw new ArgumentNullException(nameof(createCompletionRequest));

            using BinaryContent content = BinaryContent.Create(createCompletionRequest);
            ClientResult result = await CreateCompletionAsync(content).ConfigureAwait(false);
            return ClientResult.FromValue(CreateCompletionResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary> Creates a completion for the provided prompt and parameters. </summary>
        /// <param name="createCompletionRequest"> The <see cref="CreateCompletionRequest"/> to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="createCompletionRequest"/> is null. </exception>
        public virtual ClientResult<CreateCompletionResponse> CreateCompletion(CreateCompletionRequest createCompletionRequest)
        {
            if (createCompletionRequest is null) throw new ArgumentNullException(nameof(createCompletionRequest));

            using BinaryContent content = BinaryContent.Create(createCompletionRequest);
            ClientResult result = CreateCompletion(content);
            return ClientResult.FromValue(CreateCompletionResponse.FromResponse(result.GetRawResponse()), result.GetRawResponse());
        }

        /// <summary>
        /// [Protocol Method] Creates a completion for the provided prompt and parameters.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateCompletionAsync(CreateCompletionRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual async Task<ClientResult> CreateCompletionAsync(BinaryContent content, RequestOptions options = null)
        {
            if (content is null) throw new ArgumentNullException(nameof(content));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateCreateCompletionRequest(content, options);
            await _pipeline.SendAsync(message).ConfigureAwait(false);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw await ClientResultException.CreateAsync(response).ConfigureAwait(false);
            }

            return ClientResult.FromResponse(response);
        }

        /// <summary>
        /// [Protocol Method] Creates a completion for the provided prompt and parameters.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="CreateCompletion(CreateCompletionRequest)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="options"> The request options, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <exception cref="ClientResultException"> Service returned a non-success status code. </exception>
        /// <returns> The response returned from the service. </returns>
        public virtual ClientResult CreateCompletion(BinaryContent content, RequestOptions options = null)
        {
            if (content is null) throw new ArgumentNullException(nameof(content));
            options ??= new RequestOptions();
            using PipelineMessage message = CreateCreateCompletionRequest(content, options);
            _pipeline.Send(message);
            PipelineResponse response = message.Response!;

            if (response.IsError && options.ErrorOptions == ClientErrorBehaviors.Default)
            {
                throw new ClientResultException(response);
            }

            return ClientResult.FromResponse(response);
        }

        internal PipelineMessage CreateCreateCompletionRequest(BinaryContent content, RequestOptions options)
        {
            PipelineMessage message = _pipeline.CreateMessage();
            message.ResponseClassifier = ResponseErrorClassifier200;
            PipelineRequest request = message.Request;
            request.Method = "POST";
            UriBuilder uriBuilder = new(_endpoint.ToString());
            StringBuilder path = new();
            path.Append("/completions");
            uriBuilder.Path += path.ToString();
            request.Uri = uriBuilder.Uri;
            request.Headers.Set("Accept", "application/json");
            request.Headers.Set("Content-Type", "application/json");
            request.Content = content;
            message.Apply(options);
            return message;
        }

        private static PipelineMessageClassifier _responseErrorClassifier200;
        private static PipelineMessageClassifier ResponseErrorClassifier200 => _responseErrorClassifier200 ??= PipelineMessageClassifier.Create(stackalloc ushort[] { 200 });
    }
}

