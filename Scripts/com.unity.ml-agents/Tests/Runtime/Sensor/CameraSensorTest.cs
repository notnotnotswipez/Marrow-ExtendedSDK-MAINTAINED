using System;
using NUnit.Framework;
using UnityEngine;
using Unity.MLAgents.Sensors;

namespace Unity.MLAgents.Tests
{
    [TestFixture]
    public class CameraSensorTest
    {
        [Test]
        public void TestCameraSensor()
        {
            
        }

        [Test]
        public void TestObservationType()
        {
            var width = 24;
            var height = 16;
            var camera = Camera.main;
            var sensor = new CameraSensor(camera, width, height, true, "TestCameraSensor", SensorCompressionType.None);
            var spec = sensor.GetObservationSpec();
            Assert.AreEqual((int)spec.ObservationType, (int)ObservationType.Default);
            sensor = new CameraSensor(camera, width, height, true, "TestCameraSensor", SensorCompressionType.None, ObservationType.Default);
            spec = sensor.GetObservationSpec();
            Assert.AreEqual((int)spec.ObservationType, (int)ObservationType.Default);
            sensor = new CameraSensor(camera, width, height, true, "TestCameraSensor", SensorCompressionType.None, ObservationType.GoalSignal);
            spec = sensor.GetObservationSpec();
            Assert.AreEqual((int)spec.ObservationType, (int)ObservationType.GoalSignal);
        }
    }
}
