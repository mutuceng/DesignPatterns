using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateMethod.AbstractClass;

namespace TemplateMethod.ConcreteClasses
{
    public class CallCenterA:CallCenterProcessor
    {
        protected override string GetMetaData(string callId)
        {
            // Çağrı Merkezi C'ye özgü meta veri alma mantığı
            return $"CallID: {callId}, Date: 2025-07-01, Priority: High (from Center C)";
        }

        protected override byte[] GetAudioData(string callId)
        {
            // Çağrı Merkezi C'ye özgü ses verisi alma mantığı
            return new byte[] { 11, 12, 13, 14, 15 }; // Örnek ses verisi
        }
    }
}
