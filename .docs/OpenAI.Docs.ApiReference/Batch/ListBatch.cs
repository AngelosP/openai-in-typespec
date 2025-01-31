using System;
using NUnit.Framework;


using System.Text.Json;

// DO NOT INCLUDE IN DOCS ABOVE THIS POINT

using OpenAI.Batch;
using System.ClientModel.Primitives;

namespace OpenAI.Docs.ApiReference;
public partial class ListBatchApiReference {

    [Test]
    public void ListBatch()
    {
		BatchClient client = new(Environment.GetEnvironmentVariable("OPENAI_API_KEY"));
		CollectionResult result = client.GetBatches(null, null, new RequestOptions {});
		
		// DO NOT INCLUDE IN DOCS FROM THIS POINT ONWARDS
		
		//BinaryData output = result.GetRawResponse().Content;
		//using JsonDocument outputAsJson = JsonDocument.Parse(output);
		//Console.WriteLine(outputAsJson.RootElement.ToString());
	}
}
