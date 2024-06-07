using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Policies;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Sensors.Reflection;
using NUnit.Framework;
using Unity.MLAgents.Actuators;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PublicApiAgent : Agent
    {
        public int numHeuristicCalls;

        [Observable]
        public float ObservableFloat;

        public void Heuristic(in ActionBuffers actionsOut)
        {

        }
    }

    // Simple SensorComponent that sets up a StackingSensor
    public class StackingComponent : SensorComponent
    {
        public SensorComponent wrappedComponent;
        public int numStacks;

        public override ISensor[] CreateSensors()
        {
            var wrappedSensors = wrappedComponent.CreateSensors();
            var sensorsOut = new ISensor[wrappedSensors.Length];

            return sensorsOut;
        }
    }

    public class RuntimeApiTest
    {
        [SetUp]
        public static void Setup()
        {
            
        }

        [UnityTest]
        public IEnumerator RuntimeApiTestWithEnumeratorPasses()
        {
            yield break;
        }
    }
}
