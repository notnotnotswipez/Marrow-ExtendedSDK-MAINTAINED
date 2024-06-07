using System;
using System.Text.RegularExpressions;
using Google.Protobuf;
using NUnit.Framework;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Demonstrations;
using Unity.MLAgents.Policies;
using Unity.MLAgents.Sensors;

using Unity.MLAgents.Analytics;
using Unity.MLAgents.CommunicatorObjects;
using UnityEngine;
using UnityEngine.TestTools;

namespace Unity.MLAgents.Tests
{
    [TestFixture]
    public class GrpcExtensionsTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void TestDefaultBrainParametersToProto()
        {
            
        }

        [Test]
        public void TestDefaultActionSpecToProto()
        {
           
        }

        [Test]
        public void ToBrainParameters()
        {
           
        }

        [Test]
        public void TestDefaultAgentInfoToProto()
        {
           
        }

        [Test]
        public void TestDefaultDemonstrationMetaDataToProto()
        {
            // Should be able to convert a default instance to proto.
            var demoMetaData = new DemonstrationMetaData();
            demoMetaData.ToProto();
        }

        class DummySensor : ISensor
        {
            public ObservationSpec ObservationSpec;
            public SensorCompressionType CompressionType;

            public ObservationSpec GetObservationSpec()
            {
                return ObservationSpec;
            }

            public int Write(ObservationWriter writer)
            {
                return 0;
            }

            public byte[] GetCompressedObservation()
            {
                return new byte[] { 13, 37 };
            }

            public void Update() { }

            public void Reset() { }

            public CompressionSpec GetCompressionSpec()
            {
                return new CompressionSpec(CompressionType);
            }

            public string GetName()
            {
                return "Dummy";
            }
        }

        [Test]
        public void TestGetObservationProtoCapabilities()
        {
            // Shape, compression type, concatenatedPngObservations, expect throw
            var variants = new[]
            {
                // Vector observations
                (new[] {3}, SensorCompressionType.None, false, false),
                // Uncompressed floats
                (new[] {3, 4, 4}, SensorCompressionType.None, false, false),
                // Compressed floats, 3 channels
                (new[] {3, 4, 4}, SensorCompressionType.PNG, false, true),

                // Compressed floats, >3 channels
                (new[] {4, 4, 4}, SensorCompressionType.PNG, false, false), // Unsupported - results in uncompressed
                (new[] {4, 4, 4}, SensorCompressionType.PNG, true, true), // Supported compressed
            };

            foreach (var (shape, compressionType, supportsMultiPngObs, expectCompressed) in variants)
            {
                
            }
        }

        [Test]
        public void TestDefaultTrainingEvents()
        {
            var trainingEnvInit = new TrainingEnvironmentInitialized
            {
                PythonVersion = "test",
            };
            var trainingEnvInitEvent = trainingEnvInit.ToTrainingEnvironmentInitializedEvent();
            Assert.AreEqual(trainingEnvInit.PythonVersion, trainingEnvInitEvent.TrainerPythonVersion);

            var trainingBehavInit = new TrainingBehaviorInitialized
            {
                BehaviorName = "testBehavior",
                ExtrinsicRewardEnabled = true,
                CuriosityRewardEnabled = true,

                RecurrentEnabled = true,
                SelfPlayEnabled = true,
            };
            var trainingBehavInitEvent = trainingBehavInit.ToTrainingBehaviorInitializedEvent();
            Assert.AreEqual(trainingBehavInit.BehaviorName, trainingBehavInitEvent.BehaviorName);

            Assert.AreEqual(RewardSignals.Extrinsic | RewardSignals.Curiosity, trainingBehavInitEvent.RewardSignalFlags);
            Assert.AreEqual(TrainingFeatures.Recurrent | TrainingFeatures.SelfPlay, trainingBehavInitEvent.TrainingFeatureFlags);
        }
    }
}
