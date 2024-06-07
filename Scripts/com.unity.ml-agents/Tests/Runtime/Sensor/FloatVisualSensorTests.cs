using NUnit.Framework;
using Unity.MLAgents.Policies;
using Unity.MLAgents.Sensors;

namespace Unity.MLAgents.Tests
{
    public class Float2DSensor : ISensor
    {
        public int Width { get; }
        public int Height { get; }
        string m_Name;
        private ObservationSpec m_ObservationSpec;
        public float[,] floatData;

        public Float2DSensor(int width, int height, string name)
        {
            Width = width;
            Height = height;
            m_Name = name;

            m_ObservationSpec = ObservationSpec.Visual(1, height, width);
            floatData = new float[Height, Width];
        }

        public Float2DSensor(float[,] floatData, string name)
        {
            this.floatData = floatData;
            Height = floatData.GetLength(0);
            Width = floatData.GetLength(1);
            m_Name = name;
            m_ObservationSpec = ObservationSpec.Visual(1, Height, Width);
        }

        public string GetName()
        {
            return m_Name;
        }

        public ObservationSpec GetObservationSpec()
        {
            return m_ObservationSpec;
        }

        public byte[] GetCompressedObservation()
        {
            return null;
        }

        public int Write(ObservationWriter writer)
        {
            return -1;
        }

        public void Update() { }
        public void Reset() { }

        public CompressionSpec GetCompressionSpec()
        {
            return CompressionSpec.Default();
        }
    }

    public class FloatVisualSensorTests
    {
        [Test]
        public void TestFloat2DSensorWrite()
        {
            
        }

        [Test]
        public void TestFloat2DSensorExternalData()
        {
            var data = new float[4, 3];
            var sensor = new Float2DSensor(data, "floatsensor");
            Assert.AreEqual(sensor.Height, 4);
            Assert.AreEqual(sensor.Width, 3);
        }
    }
}
