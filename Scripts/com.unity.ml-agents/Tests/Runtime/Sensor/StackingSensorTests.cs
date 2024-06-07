using NUnit.Framework;
using System;
using System.Linq;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Policies;
using UnityEngine;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Utils.Tests;

namespace Unity.MLAgents.Tests
{
    public class StackingSensorTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [TearDown]
        public void TearDown()
        {
            CommunicatorFactory.ClearCreator();
        }

        [Test]
        public void TestCtor()
        {
            
        }

        [Test]
        public void AssertStackingReset()
        {
            
        }

        [Test]
        public void TestVectorStacking()
        {
            
        }

        [Test]
        public void TestVectorStackingReset()
        {
           
        }

        class Dummy3DSensor : ISensor
        {
            public SensorCompressionType CompressionType = SensorCompressionType.PNG;
            public int[] Mapping;
            public ObservationSpec ObservationSpec;
            public float[,,] CurrentObservation;

            public ObservationSpec GetObservationSpec()
            {
                return ObservationSpec;
            }

            public int Write(ObservationWriter writer)
            {
                return -1;
            }

            public byte[] GetCompressedObservation()
            {
                return null;
            }

            public void Update() { }

            public void Reset() { }

            public CompressionSpec GetCompressionSpec()
            {
                return new CompressionSpec(CompressionType, Mapping);
            }

            public string GetName()
            {
                return "Dummy";
            }
        }

        [Test]
        public void TestStackingMapping()
        {
            
        }

        [Test]
        public void Test3DStacking()
        {
            
        }

        [Test]
        public void TestStackedGetCompressedObservation()
        {
            
        }

        [Test]
        public void TestStackingSensorBuiltInSensorType()
        {
            
        }
    }
}
