using NUnit.Framework;
using UnityEngine;
using Unity.MLAgents.Sensors;

namespace Unity.MLAgents.Tests
{
    public class VectorSensorTests
    {
        [Test]
        public void TestCtor()
        {
            
        }

        [Test]
        public void TestWrite()
        {
            
        }

        [Test]
        public void TestAddObservationFloat()
        {
            
        }

        [Test]
        public void TestObservationType()
        {
            var sensor = new VectorSensor(1);
            var spec = sensor.GetObservationSpec();
            Assert.AreEqual((int)spec.ObservationType, (int)ObservationType.Default);
            sensor = new VectorSensor(1, observationType: ObservationType.Default);
            spec = sensor.GetObservationSpec();
            Assert.AreEqual((int)spec.ObservationType, (int)ObservationType.Default);
            sensor = new VectorSensor(1, observationType: ObservationType.GoalSignal);
            spec = sensor.GetObservationSpec();
            Assert.AreEqual((int)spec.ObservationType, (int)ObservationType.GoalSignal);
        }

        [Test]
        public void TestAddObservationInt()
        {
            
        }

        [Test]
        public void TestAddObservationVec()
        {
            
        }

        [Test]
        public void TestAddObservationQuaternion()
        {
            
        }

        [Test]
        public void TestWriteEnumerable()
        {
            
        }

        [Test]
        public void TestAddObservationBool()
        {
            
        }

        [Test]
        public void TestAddObservationOneHot()
        {
            
        }

        [Test]
        public void TestWriteTooMany()
        {
            
        }

        [Test]
        public void TestWriteNotEnough()
        {
            
        }
    }
}
