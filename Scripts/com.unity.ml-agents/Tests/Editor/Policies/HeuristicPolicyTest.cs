using NUnit.Framework;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Policies;
using UnityEngine;

namespace Unity.MLAgents.Tests.Policies
{
    [TestFixture]
    public class HeuristicPolicyTest
    {
        [SetUp]
        public void SetUp()
        {
           
        }

        /// <summary>
        /// Assert that the action buffers are initialized to zero, and then set them to non-zero values.
        /// </summary>
        /// <param name="actionsOut"></param>
        static void CheckAndSetBuffer(in ActionBuffers actionsOut)
        {
            var continuousActions = actionsOut.ContinuousActions;
            for (var continuousIndex = 0; continuousIndex < continuousActions.Length; continuousIndex++)
            {
                Assert.AreEqual(continuousActions[continuousIndex], 0.0f);
                continuousActions[continuousIndex] = 1.0f;
            }

            var discreteActions = actionsOut.DiscreteActions;
            for (var discreteIndex = 0; discreteIndex < discreteActions.Length; discreteIndex++)
            {
                Assert.AreEqual(discreteActions[discreteIndex], 0);
                discreteActions[discreteIndex] = 1;
            }
        }

        class ActionClearedAgent : Agent
        {
            
        }

        class ActionClearedActuator : IActuator
        {
            public int HeuristicCalls;
            public ActionClearedActuator(ActionSpec actionSpec)
            {
                ActionSpec = actionSpec;
                Name = GetType().Name;
            }

            public void OnActionReceived(ActionBuffers actionBuffers)
            {
            }

            public void WriteDiscreteActionMask(IDiscreteActionMask actionMask)
            {
            }

            public void Heuristic(in ActionBuffers actionBuffersOut)
            {
                CheckAndSetBuffer(actionBuffersOut);
                HeuristicCalls++;
            }

            public ActionSpec ActionSpec { get; }
            public string Name { get; }

            public void ResetData()
            {
            }
        }

        class ActionClearedActuatorComponent : ActuatorComponent
        {
            public ActionClearedActuator ActionClearedActuator;
            public ActionClearedActuatorComponent()
            {
                ActionSpec = new ActionSpec(2, new[] { 3, 3 });
            }

            public override IActuator[] CreateActuators()
            {
                ActionClearedActuator = new ActionClearedActuator(ActionSpec);
                return new IActuator[] { ActionClearedActuator };
            }

            public override ActionSpec ActionSpec { get; }
        }

        [Test]
        public void TestActionsCleared()
        {
            
        }
    }
}
