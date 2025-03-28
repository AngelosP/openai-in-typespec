// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalCreateAssistantRequestToolResourcesCodeInterpreter
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        public InternalCreateAssistantRequestToolResourcesCodeInterpreter()
        {
            FileIds = new ChangeTrackingList<string>();
        }

        internal InternalCreateAssistantRequestToolResourcesCodeInterpreter(IList<string> fileIds, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            FileIds = fileIds;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public IList<string> FileIds { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
