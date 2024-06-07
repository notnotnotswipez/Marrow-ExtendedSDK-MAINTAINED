using System;
using System.Reflection;
using NUnit.Framework;
using UnityEngine;

namespace Unity.MLAgents.Tests
{
    public class MultiAgentGroupTests
    {
        class TestAgent : Agent
        {
            internal int _GroupId
            {
                get
                {
                    return (int)typeof(Agent).GetField("m_GroupId", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(this);
                }
            }

            internal float _GroupReward
            {
                get
                {
                    return (float)typeof(Agent).GetField("m_GroupReward", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(this);
                }
            }

            internal Action<Agent> _OnAgentDisabledActions
            {
                get
                {
                    return (Action<Agent>)typeof(Agent).GetField("OnAgentDisabled", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(this);
                }
            }
        }

        [Test]
        public void TestRegisteredAgentGroupId()
        {
            
        }

        [Test]
        public void TestRegisterMultipleAgent()
        {
            
        }

        [Test]
        public void TestGroupIdCounter()
        {
            SimpleMultiAgentGroup group1 = new SimpleMultiAgentGroup();
            SimpleMultiAgentGroup group2 = new SimpleMultiAgentGroup();
            // id should be unique
            Assert.AreNotEqual(group1.GetId(), group2.GetId());
        }
    }
}
