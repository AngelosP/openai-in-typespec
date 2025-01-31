using NUnit.Framework;
using System.Text.Json;

#region usings
using System;
using System.ClientModel;

using OpenAI.FineTuning;
#endregion

namespace OpenAI.Docs.ApiReference;
public partial class CreateFineTunningJobApiReference {

    [Test]
    public void CreateFineTunningJob()
    {
		FineTuningClient client = new(Environment.GetEnvironmentVariable("OPENAI_API_KEY"));
		
		var content = BinaryContent.Create(
		    BinaryData.FromObjectAsJson(new
		    {
		        training_file = "file_abc123"
		    })
		);
		
		var result = client.CreateFineTuningJob(content, false);
		
		// DO NOT INCLUDE IN DOCS FROM THIS POINT ONWARDS
		
		BinaryData output = result.GetRawResponse().Content;
		using JsonDocument outputAsJson = JsonDocument.Parse(output);
		Console.WriteLine(outputAsJson.RootElement.ToString());
	}
}
