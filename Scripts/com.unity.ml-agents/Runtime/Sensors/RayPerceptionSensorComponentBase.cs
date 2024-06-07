using System;
using System.Collections.Generic;
using Unity.MLAgents.Policies;
using UnityEngine;
using UnityEngine.Serialization;

namespace Unity.MLAgents.Sensors
{
    /// <summary>
    /// A base class to support sensor components for raycast-based sensors.
    /// </summary>
    public abstract class RayPerceptionSensorComponentBase : SensorComponent
    {
        [HideInInspector, SerializeField, FormerlySerializedAs("sensorName")]
        string m_SensorName = "RayPerceptionSensor";

        /// <summary>
        /// The name of the Sensor that this component wraps.
        /// Note that changing this at runtime does not affect how the Agent sorts the sensors.
        /// </summary>
        public string SensorName
        {
            get { return m_SensorName; }
            set { m_SensorName = value; }
        }

        [SerializeField, FormerlySerializedAs("detectableTags")]
        [Tooltip("List of tags in the scene to compare against.")]
        List<string> m_DetectableTags;

        /// <summary>
        /// List of tags in the scene to compare against.
        /// Note that this should not be changed at runtime.
        /// </summary>
        public List<string> DetectableTags
        {
            get { return m_DetectableTags; }
            set { m_DetectableTags = value; }
        }

        [HideInInspector, SerializeField, FormerlySerializedAs("raysPerDirection")]
        [Range(0, 50)]
        [Tooltip("Number of rays to the left and right of center.")]
        int m_RaysPerDirection = 3;

        /// <summary>
        /// Number of rays to the left and right of center.
        /// Note that this should not be changed at runtime.
        /// </summary>
        public int RaysPerDirection
        {
            get { return m_RaysPerDirection; }
            // Note: can't change at runtime
            set { m_RaysPerDirection = value; }
        }

        [HideInInspector, SerializeField, FormerlySerializedAs("maxRayDegrees")]
        [Range(0, 180)]
        [Tooltip("Cone size for rays. Using 90 degrees will cast rays to the left and right. " +
            "Greater than 90 degrees will go backwards.")]
        float m_MaxRayDegrees = 70;

        /// <summary>
        /// Cone size for rays. Using 90 degrees will cast rays to the left and right.
        /// Greater than 90 degrees will go backwards.
        /// </summary>
        public float MaxRayDegrees
        {
            get => m_MaxRayDegrees;
            set { m_MaxRayDegrees = value; UpdateSensor(); }
        }

        [HideInInspector, SerializeField, FormerlySerializedAs("sphereCastRadius")]
        [Range(0f, 10f)]
        [Tooltip("Radius of sphere to cast. Set to zero for raycasts.")]
        float m_SphereCastRadius = 0.5f;

        /// <summary>
        /// Radius of sphere to cast. Set to zero for raycasts.
        /// </summary>
        public float SphereCastRadius
        {
            get => m_SphereCastRadius;
            set { m_SphereCastRadius = value; UpdateSensor(); }
        }

        [HideInInspector, SerializeField, FormerlySerializedAs("rayLength")]
        [Range(1, 1000)]
        [Tooltip("Length of the rays to cast.")]
        float m_RayLength = 20f;

        /// <summary>
        /// Length of the rays to cast.
        /// </summary>
        public float RayLength
        {
            get => m_RayLength;
            set { m_RayLength = value; UpdateSensor(); }
        }

        // The value of the default layers.
        const int k_PhysicsDefaultLayers = -5;
        [HideInInspector, SerializeField, FormerlySerializedAs("rayLayerMask")]
        [Tooltip("Controls which layers the rays can hit.")]
        LayerMask m_RayLayerMask = k_PhysicsDefaultLayers;

        /// <summary>
        /// Controls which layers the rays can hit.
        /// </summary>
        public LayerMask RayLayerMask
        {
            get => m_RayLayerMask;
            set { m_RayLayerMask = value; UpdateSensor(); }
        }

        [HideInInspector, SerializeField, FormerlySerializedAs("observationStacks")]
        [Range(1, 50)]
        [Tooltip("Number of raycast results that will be stacked before being fed to the neural network.")]
        int m_ObservationStacks = 1;

        /// <summary>
        /// Whether to stack previous observations. Using 1 means no previous observations.
        /// Note that changing this after the sensor is created has no effect.
        /// </summary>
        public int ObservationStacks
        {
            get { return m_ObservationStacks; }
            set { m_ObservationStacks = value; }
        }

        [HideInInspector, SerializeField]
        [Tooltip("Disable to provide the rays in left to right order.  Warning: Alternating order will be deprecated, disable it to ensure compatibility with future versions of ML-Agents.")]
        public bool m_AlternatingRayOrder = true;

        /// <summary>
        /// Determines how the rays are ordered.  By default the ordering is as follows: middle ray is first;
        /// then alternates outward adding rays to the left and right.  If set to false, then the rays are
        /// ordered from left to right (viewed from above) which is more amenable to processing with
        /// conv nets.
        /// This property will be deprecated with the next major version update and the left to right ordering
        /// will be used thereafter.
        /// </summary>
        public bool AlternatingRayOrder
        {
            get { return m_AlternatingRayOrder; }
            set { m_AlternatingRayOrder = value; }
        }

        [HideInInspector, SerializeField]
        [Tooltip("Enable to use batched raycasts and the jobs system.")]
        public bool m_UseBatchedRaycasts = false;

        /// <summary>
        /// Determines whether to use batched raycasts and the jobs system. Default = false.
        /// </summary>
        public bool UseBatchedRaycasts
        {
            get { return m_UseBatchedRaycasts; }
            set { m_UseBatchedRaycasts = value; }
        }


        /// <summary>
        /// Color to code a ray that hits another object.
        /// </summary>
        [HideInInspector]
        [SerializeField]
        [Header("Debug Gizmos", order = 999)]
        internal Color rayHitColor = Color.red;

        /// <summary>
        /// Color to code a ray that avoid or misses all other objects.
        /// </summary>
        [HideInInspector]
        [SerializeField]
        internal Color rayMissColor = Color.white;

        [NonSerialized]
        RayPerceptionSensor m_RaySensor;

        /// <summary>
        /// Get the RayPerceptionSensor that was created.
        /// </summary>
        public RayPerceptionSensor RaySensor
        {
            get => m_RaySensor;
        }

        /// <summary>
        /// Returns the <see cref="RayPerceptionCastType"/> for the associated raycast sensor.
        /// </summary>
        /// <returns></returns>
        public abstract RayPerceptionCastType GetCastType();

        /// <summary>
        /// Returns the amount that the ray start is offset up or down by.
        /// </summary>
        /// <returns></returns>
        public virtual float GetStartVerticalOffset()
        {
            return 0f;
        }

        /// <summary>
        /// Returns the amount that the ray end is offset up or down by.
        /// </summary>
        /// <returns></returns>
        public virtual float GetEndVerticalOffset()
        {
            return 0f;
        }

        /// <summary>
        /// Returns an initialized raycast sensor.
        /// </summary>
        /// <returns></returns>
        public override ISensor[] CreateSensors()
        {
            

            return new ISensor[] { m_RaySensor };
        }

        /// <summary>
        /// Returns the specific ray angles given the number of rays per direction and the
        /// cone size for the rays.
        /// </summary>
        /// <param name="raysPerDirection">Number of rays to the left and right of center.</param>
        /// <param name="maxRayDegrees">
        /// Cone size for rays. Using 90 degrees will cast rays to the left and right.
        /// Greater than 90 degrees will go backwards.
        /// Orders the rays starting with the centermost and alternating to the left and right.
        /// Should be deprecated with a future major version release (doing so will break existing
        /// models).
        /// </param>
        /// <returns></returns>
        internal static float[] GetRayAnglesAlternating(int raysPerDirection, float maxRayDegrees)
        {
            // Example:
            // { 90, 90 - delta, 90 + delta, 90 - 2*delta, 90 + 2*delta }
            var anglesOut = new float[2 * raysPerDirection + 1];
            var delta = maxRayDegrees / raysPerDirection;
            anglesOut[0] = 90f;
            for (var i = 0; i < raysPerDirection; i++)
            {
                anglesOut[2 * i + 1] = 90 - (i + 1) * delta;
                anglesOut[2 * i + 2] = 90 + (i + 1) * delta;
            }
            return anglesOut;
        }

        /// <summary>
        /// Returns the specific ray angles given the number of rays per direction and the
        /// cone size for the rays.
        /// </summary>
        /// <param name="raysPerDirection">Number of rays to the left and right of center.</param>
        /// <param name="maxRayDegrees">
        /// Cone size for rays. Using 90 degrees will cast rays to the left and right.
        /// Greater than 90 degrees will go backwards.
        /// Orders the rays from the left-most to the right-most which makes using a convolution
        /// in the model easier.
        /// </param>
        /// <returns></returns>
        internal static float[] GetRayAngles(int raysPerDirection, float maxRayDegrees)
        {
            // Example:
            // { 90 - 3*delta, 90 - 2*delta, ..., 90, 90 + delta, ..., 90 + 3*delta }
            var anglesOut = new float[2 * raysPerDirection + 1];
            var delta = maxRayDegrees / raysPerDirection;

            for (var i = 0; i < 2 * raysPerDirection + 1; i++)
            {
                anglesOut[i] = 90 + (i - raysPerDirection) * delta;
            }

            return anglesOut;
        }

        /// <summary>
        /// Get the RayPerceptionInput that is used by the <see cref="RayPerceptionSensor"/>.
        /// </summary>
        /// <returns></returns>
        public RayPerceptionInput GetRayPerceptionInput()
        {
            return null;
        }

        internal void UpdateSensor()
        {

        }

        internal int SensorObservationAge()
        {


            return 0;
        }

        void OnDrawGizmosSelected()
        {

        }

        /// <summary>
        /// Draw the debug information from the sensor (if available).
        /// </summary>
        void DrawRaycastGizmos(RayPerceptionOutput.RayOutput rayOutput, float alpha = 1.0f)
        {
            
        }
    }

    public class RayPerceptionOutput
    {
        public class RayOutput
        {
            
        }
    }

    public class RayPerceptionCastType
    {
    }

    public class RayPerceptionInput
    {
    }

    public class RayPerceptionSensor : ISensor
    {
        public ObservationSpec GetObservationSpec()
        {
            throw new NotImplementedException();
        }

        public int Write(ObservationWriter writer)
        {
            throw new NotImplementedException();
        }

        public byte[] GetCompressedObservation()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public CompressionSpec GetCompressionSpec()
        {
            throw new NotImplementedException();
        }

        public string GetName()
        {
            throw new NotImplementedException();
        }
    }
}
