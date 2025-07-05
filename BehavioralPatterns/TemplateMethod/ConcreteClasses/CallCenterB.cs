using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.AbstractClass;

namespace TemplateMethod.ConcreteClasses
{
    public class CallCenterB:CallCenterProcessor
    {
        protected override string GetMetaData(string callId)
        {
            // Çağrı Merkezi B'ye özgü meta veri alma mantığı
            return $"CallID: {callId}, Date: 2025-07-01, Agent: John (from Center B)";
        }

        protected override byte[] GetAudioData(string callId)
        {
            // Çağrı Merkezi B'ye özgü ses verisi alma mantığı
            return new byte[] { 6, 7, 8, 9, 10 }; // Örnek ses verisi
        }
    }
}
