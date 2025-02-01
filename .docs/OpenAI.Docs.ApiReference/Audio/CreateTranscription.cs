using NUnit.Framework;

#region usings
using System;
using System.IO;

using OpenAI.Audio;
#endregion

namespace OpenAI.Docs.ApiReference;
public partial class CreateTranscriptionApiReference {

    [Test]
    public void CreateTranscription()
    {
        #region logic

        AudioClient client = new(
		    model: "whisper-1",
		    apiKey: Environment.GetEnvironmentVariable("OPENAI_API_KEY")
		);
		
		string filePath = Path.Combine("speech.mp3");
		AudioTranscription transcription = client.TranscribeAudio(
		    filePath,
		    new() 
			{
		        ResponseFormat = AudioTranscriptionFormat.Verbose,
		        TimestampGranularities = AudioTimestampGranularities.Word
		    }
		);
		
		Console.WriteLine($"{transcription.Text}");

        #endregion

        Console.Read();
	}
}
