using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using System.Reflection;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Sensors.Reflection;
using Unity.MLAgents.Policies;
using Unity.MLAgents.SideChannels;
using Unity.MLAgents.Utils.Tests;

namespace Unity.MLAgents.Tests
{
    [TestFixture]
    public class EditModeTestGeneration
    {
        [SetUp]
        public void SetUp()
        {
           
        }

        [Test]
        public void TestAcademy()
        {
            
        }

        [Test]
        public void TestAgent()
        {
            
        }
    }

    [TestFixture]
    public class EditModeTestInitialization
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void TestAcademy()
        {
            
        }

        [Test]
        public void TestAcademyDispose()
        {
           
        }

        [Test]
        public void TestAgent()
        {
            
        }
    }

    [TestFixture]
    public class EditModeTestStep
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void TestAcademy()
        {
            
        }

        [Test]
        public void TestAcademyAutostep()
        {
            
        }

        [Test]
        public void TestAgent()
        {
            
        }
    }

    [TestFixture]
    public class EditModeTestReset
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void TestAcademy()
        {
            
        }

        [Test]
        public void TestAgent()
        {
            
        }
    }

    [TestFixture]
    public class EditModeTestMiscellaneous
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        [Test]
        public void TestCumulativeReward()
        {
            
        }

        [Test]
        public void TestMaxStepsReset()
        {
            
        }

        [Test]
        public void TestHeuristicPolicyStepsSensors()
        {
            
        }

        [Test]
        public void TestNullList()
        {
            var nullList = new HeuristicPolicy.NullList();
            Assert.Throws<NotImplementedException>(() =>
            {
                _ = ((IEnumerable<float>)nullList).GetEnumerator();
            });

            Assert.Throws<NotImplementedException>(() =>
            {
                _ = ((IEnumerable)nullList).GetEnumerator();
            });

            Assert.Throws<NotImplementedException>(() =>
            {
                nullList.CopyTo(new[] { 0f }, 0);
            });

            nullList.Add(0);
            Assert.IsTrue(nullList.Count == 0);

            nullList.Clear();
            Assert.IsTrue(nullList.Count == 0);

            nullList.Add(0);
            Assert.IsFalse(nullList.Contains(0));
            Assert.IsFalse(nullList.Remove(0));
            Assert.IsFalse(nullList.IsReadOnly);
            Assert.IsTrue(nullList.IndexOf(0) == -1);
            nullList.Insert(0, 0);
            Assert.IsFalse(nullList.Count > 0);
            nullList.RemoveAt(0);
            Assert.IsTrue(nullList.Count == 0);
            Assert.IsTrue(Mathf.Approximately(0f, nullList[0]));
            Assert.IsTrue(Mathf.Approximately(0f, nullList[1]));
        }
    }

    [TestFixture]
    public class TestOnEnableOverride
    {
        public class OnEnableAgent : Agent
        {
            
        }

        static void _InnerAgentTestOnEnableOverride(bool callBase = false)
        {
           
        }

        [Test]
        public void TestAgentCallBaseOnEnable()
        {
            _InnerAgentTestOnEnableOverride(true);
        }

        [Test]
        public void TestAgentDontCallBaseOnEnable()
        {
            _InnerAgentTestOnEnableOverride();
        }
    }

    [TestFixture]
    public class ObservableAttributeBehaviorTests
    {
        public class BaseObservableAgent : Agent
        {
            [Observable]
            public float BaseField;
        }

        public class DerivedObservableAgent : BaseObservableAgent
        {
            [Observable]
            public float DerivedField;
        }


        [Test]
        public void TestObservableAttributeBehaviorIgnore()
        {
            
        }
    }

    [TestFixture]
    public class AgentRecursionTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        class CollectObsEndEpisodeAgent : Agent
        {
            
        }

        class OnEpisodeBeginEndEpisodeAgent : Agent
        {
            
        }

        void TestRecursiveThrows<T>() where T : Agent
        {
            
        }

        [Test]
        public void TestRecursiveCollectObsEndEpisodeThrows()
        {
            TestRecursiveThrows<CollectObsEndEpisodeAgent>();
        }

        [Test]
        public void TestRecursiveOnEpisodeBeginEndEpisodeThrows()
        {
            TestRecursiveThrows<OnEpisodeBeginEndEpisodeAgent>();
        }
    }
}
