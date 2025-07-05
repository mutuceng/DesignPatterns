using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod.AbstractClass
{
    public abstract class CallCenterProcessor
    {
        public void ProcessCallRecords(string callId)
        {
            var metaData = GetMetaData(callId);
            StoreMetaData(metaData);

            var audioData = GetAudioData(callId);
            ValidateAudioWithMetaData(audioData, metaData);
            StoreAudioData(audioData);
        }

        protected abstract string GetMetaData(string callId);
        protected abstract byte[] GetAudioData(string callId);

        public void StoreMetaData(string metaData)
        {
            Console.WriteLine($"Storing metadata: {metaData}");
            // Logic to store metadata
        }

        public void StoreAudioData(byte[] audioData)
        {
            Console.WriteLine($"Storing audio data of size: {audioData.Length} bytes");
            // Logic to store audio data
        }

        protected void ValidateAudioWithMetaData(byte[] audioData, string metaData)
        {
            if (audioData == null || audioData.Length == 0)
            {
                throw new ArgumentException("Audio data cannot be null or empty.");
            }
            if (string.IsNullOrEmpty(metaData))
            {
                throw new ArgumentException("Metadata cannot be null or empty.");
            }
            Console.WriteLine("Validating audio data with metadata...");
            // Logic to validate audio data with metadata
        }

    }
}
