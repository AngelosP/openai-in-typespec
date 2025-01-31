#pragma warning disable OPENAI001
using NUnit.Framework;

#region usings
using System;
using System.ClientModel;

using OpenAI.Assistants;
#endregion

namespace OpenAI.Docs.ApiReference;
public partial class CreateRun_StreamingApiReference {

    [Test]
    public void CreateRun_Streaming()
    {
		AssistantClient assistantClient = new (new ApiKeyCredential(Environment.GetEnvironmentVariable("OPENAI_API_KEY")));
		
		var streamingUpdates = assistantClient.CreateRunStreaming("thread_abc123", "asst_abc123");
		
		foreach (StreamingUpdate streamingUpdate in streamingUpdates) {
		    if (streamingUpdate.UpdateKind == StreamingUpdateReason.RunCreated) {
		        Console.WriteLine($"--- Run started! ---");
		    }
		    if (streamingUpdate is MessageContentUpdate contentUpdate) {
		        Console.Write(contentUpdate.Text);
		    }
		}
	}
}
