using NUnit.Framework;
using UnityEngine;
using System.IO.Abstractions.TestingHelpers;
using System.Reflection;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.CommunicatorObjects;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Demonstrations;
using Unity.MLAgents.Policies;
using Unity.MLAgents.Utils.Tests;

namespace Unity.MLAgents.Tests
{
    [TestFixture]
    public class DemonstrationTests
    {
        const string k_DemoDirectory = "Assets/Demonstrations/";
        const string k_ExtensionType = ".demo";
        const string k_DemoName = "Test";

        [SetUp]
        public void SetUp()
        {
           
        }

        [Test]
        public void TestSanitization()
        {
            const string dirtyString = "abc1234567&!@";
            const string knownCleanString = "abc123";
            var cleanString = DemonstrationRecorder.SanitizeName(dirtyString, 6);
            Assert.AreNotEqual(dirtyString, cleanString);
            Assert.AreEqual(cleanString, knownCleanString);
        }

        [Test]
        public void TestStoreInitialize()
        {
           
        }

        public class ObservationAgent : TestAgent
        {
            public void CollectObservations(VectorSensor sensor)
            {
                collectObservationsCalls += 1;
                sensor.AddObservation(1f);
                sensor.AddObservation(2f);
                sensor.AddObservation(3f);
            }
        }

        [Test]
        public void TestAgentWrite()
        {
            
        }
    }
}
