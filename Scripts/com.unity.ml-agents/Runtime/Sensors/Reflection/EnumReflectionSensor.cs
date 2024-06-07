using System;
using Unity.MLAgents.Policies;

namespace Unity.MLAgents.Sensors.Reflection
{
    internal class EnumReflectionSensor
    {
        Array m_Values;
        bool m_IsFlags;

        

        internal void WriteReflectedField(ObservationWriter writer)
        {
         
        }

        internal static int GetEnumObservationSize(Type t)
        {
            var values = Enum.GetValues(t);
            // Account for all enum values
            return values.Length;
        }
    }
}
