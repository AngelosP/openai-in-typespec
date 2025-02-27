// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.OpenAI
{
    internal partial class InternalAzureContentFilterResultForPromptContentFilterResults
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalAzureContentFilterResultForPromptContentFilterResults(ContentFilterDetectionResult jailbreak, ContentFilterDetectionResult indirectAttack)
        {
            Jailbreak = jailbreak;
            IndirectAttack = indirectAttack;
        }

        internal InternalAzureContentFilterResultForPromptContentFilterResults(ContentFilterSeverityResult sexual, ContentFilterSeverityResult hate, ContentFilterSeverityResult violence, ContentFilterSeverityResult selfHarm, ContentFilterDetectionResult profanity, ContentFilterBlocklistResult customBlocklists, InternalAzureContentFilterResultForChoiceError error, ContentFilterDetectionResult jailbreak, ContentFilterDetectionResult indirectAttack, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Sexual = sexual;
            Hate = hate;
            Violence = violence;
            SelfHarm = selfHarm;
            Profanity = profanity;
            CustomBlocklists = customBlocklists;
            Error = error;
            Jailbreak = jailbreak;
            IndirectAttack = indirectAttack;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public ContentFilterSeverityResult Sexual { get; set; }

        public ContentFilterSeverityResult Hate { get; set; }

        public ContentFilterSeverityResult Violence { get; set; }

        public ContentFilterSeverityResult SelfHarm { get; set; }

        public ContentFilterDetectionResult Profanity { get; set; }

        public ContentFilterBlocklistResult CustomBlocklists { get; set; }

        public InternalAzureContentFilterResultForChoiceError Error { get; set; }

        public ContentFilterDetectionResult Jailbreak { get; set; }

        public ContentFilterDetectionResult IndirectAttack { get; set; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
