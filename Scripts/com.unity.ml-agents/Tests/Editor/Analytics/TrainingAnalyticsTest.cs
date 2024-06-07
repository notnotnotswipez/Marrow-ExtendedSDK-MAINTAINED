using System;
using System.Collections.Generic;
using NUnit.Framework;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Analytics;
using Unity.MLAgents.Policies;
using UnityEditor;

namespace Unity.MLAgents.Tests.Analytics
{
    [TestFixture]
    public class TrainingAnalyticsTests
    {
        [TestCase("foo?team=42", ExpectedResult = "foo")]
        [TestCase("foo", ExpectedResult = "foo")]
        [TestCase("foo?bar?team=1337", ExpectedResult = "foo?bar")]
        public string TestParseBehaviorName(string fullyQualifiedBehaviorName)
        {
            return TrainingAnalytics.ParseBehaviorName(fullyQualifiedBehaviorName);
        }

        [Test]
        public void TestRemotePolicyEvent()
        {
           
        }

        [Test]
        public void TestRemotePolicy()
        {
            
        }

        [TestCase("a name we expect to hash", ExpectedResult = "d084a8b6da6a6a1c097cdc9ffea95e1546da4647352113ed77cbe7b4192e6d73")]
        [TestCase("another_name", ExpectedResult = "0b74613c872e79aba11e06eda3538f2b646eb2b459e75087829ea500bd703d0b")]
        [TestCase("0b74613c872e79aba11e06eda3538f2b646eb2b459e75087829ea500bd703d0b", ExpectedResult = "0b74613c872e79aba11e06eda3538f2b646eb2b459e75087829ea500bd703d0b")]
        public string TestTrainingBehaviorInitialized(string stringToMaybeHash)
        {
            var tbiEvent = new TrainingBehaviorInitializedEvent();
            tbiEvent.BehaviorName = stringToMaybeHash;
            tbiEvent.Config = "{}";

            var sanitizedEvent = TrainingAnalytics.SanitizeTrainingBehaviorInitializedEvent(tbiEvent);
            return sanitizedEvent.BehaviorName;
        }

        [Test]
        public void TestEnableAnalytics()
        {
#if UNITY_EDITOR && MLA_UNITY_ANALYTICS_MODULE
            Assert.IsTrue(EditorAnalytics.enabled == TrainingAnalytics.EnableAnalytics());
#else
            Assert.IsFalse(TrainingAnalytics.EnableAnalytics());
#endif
        }
    }
}
