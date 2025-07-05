using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.AbstractClass;

namespace TemplateMethod.ConcreteClasses
{
    public class CallCenterC : CallCenterProcessor
    {
        protected override string GetMetaData(string callId)
        {
            return $"Call metadata for {callId} from CallCenterC";
        }

        protected override byte[] GetAudioData(string callId)
        {
            Console.WriteLine($"Retrieving audio data for {callId} from CallCenterC");
            // Simulating audio data retrieval
            return Encoding.UTF8.GetBytes($"Audio data for {callId} from CallCenterC");
        }

        //protected override void ValidateAudioWithMetaData(byte[] audioData, string metaData)
        //{
        //    base.ValidateAudioWithMetaData(audioData, metaData);
        //    Console.WriteLine($"Additional validation for CallCenterC with metadata: {metaData}");
        //    // Additional validation logic specific to CallCenterC
        //}

        // hata aldım cünkü fonksiyon virtual olarak tanımlanmadığı için override edemedim
    }
}
