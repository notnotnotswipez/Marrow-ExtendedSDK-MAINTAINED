using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using Unity.MLAgents.Sensors;
using UnityEngine.TestTools;

namespace Unity.MLAgents.Tests
{
    public class RayPerceptionSensorTests
    {
        [Test]
        public void TestGetRayAngles()
        {
            var anglesAlternating = RayPerceptionSensorComponentBase.GetRayAnglesAlternating(3, 90f);
            var expectedAnglesAlternating = new[] { 90f, 60f, 120f, 30f, 150f, 0f, 180f };
            Assert.AreEqual(expectedAnglesAlternating.Length, anglesAlternating.Length);
            for (var i = 0; i < anglesAlternating.Length; i++)
            {
                Assert.AreEqual(expectedAnglesAlternating[i], anglesAlternating[i], .01);
            }

            var angles = RayPerceptionSensorComponentBase.GetRayAngles(3, 90f);
            var expectedAngles = new[] { 0f, 30f, 60f, 90f, 120f, 150f, 180f };
            Assert.AreEqual(expectedAngles.Length, angles.Length);
            for (var i = 0; i < angles.Length; i++)
            {
                Assert.AreEqual(expectedAngles[i], angles[i], .01);
            }
        }
    }

    public class RayPerception3DTests
    {
        [Test]
        public void TestDefaultLayersAreNegativeFive()
        {
#if MLA_UNITY_PHYSICS_MODULE
            Assert.IsTrue(Physics.DefaultRaycastLayers == -5);
#endif
#if MLA_UNITY_PHYSICS2D_MODULE
            Assert.IsTrue(Physics2D.DefaultRaycastLayers == -5);
#endif
        }

#if MLA_UNITY_PHYSICS_MODULE
        // Use built-in tags
        const string k_CubeTag = "Player";
        const string k_SphereTag = "Respawn";

        [TearDown]
        public void RemoveGameObjects()
        {
            var objects = GameObject.FindObjectsOfType<GameObject>();
            foreach (var o in objects)
            {
                UnityEngine.Object.DestroyImmediate(o);
            }
        }

        void SetupScene()
        {
            /* Creates game objects in the world for testing.
             *   C is a cube
             *   S are spheres
             *   @ is the agent (at the origin)
             * Each space or line is 5 world units, +x is right, +z is up
             *
             *      C
             *    S   S
             *      @
             *
             *      S
             */
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = new Vector3(0, 0, 10);
            cube.tag = k_CubeTag;
            cube.name = "cube";

            var sphere1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere1.transform.position = new Vector3(-5, 0, 5);
            sphere1.tag = k_SphereTag;
            sphere1.name = "sphere1";

            var sphere2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere2.transform.position = new Vector3(5, 0, 5);
            // No tag for sphere2
            sphere2.name = "sphere2";

            var sphere3 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere3.transform.position = new Vector3(0, 0, -10);
            sphere3.tag = k_SphereTag;
            sphere3.name = "sphere3";


            Physics.SyncTransforms();
        }

        [Test]
        public void TestRaycasts()
        {
            
        }

        [Test]
        public void TestRaycastMiss()
        {
            
        }

        [Test]
        public void TestRayFilter()
        {
            
        }

        [Test]
        public void TestRaycastsScaled()
        {
            
        }

        [Test]
        public void TestRayZeroLength()
        {
            
        }

        [Test]
        public void TestStaticPerceive()
        {
            
        }

        [Test]
        public void TestStaticPerceiveInvalidTags()
        {
            
        }

        [Test]
        public void TestStaticPerceiveNoTags()
        {
            
        }

        [Test]
        public void TestStaticBatchedPerceive()
        {
            
        }

        [Test]
        public void TestStaticPerceiveBatchedInvalidTags()
        {
            
        }

        [Test]
        public void TestStaticPerceiveBatchedNoTags()
        {
            
        }

        [Test]
        public void TestCreateDefault()
        {
            SetupScene();
            var obj = new GameObject("agent");
            var perception = obj.AddComponent<RayPerceptionSensorComponent3D>();

            Assert.DoesNotThrow(() =>
            {
                perception.CreateSensors();
            });
        }

#endif
    }
}
