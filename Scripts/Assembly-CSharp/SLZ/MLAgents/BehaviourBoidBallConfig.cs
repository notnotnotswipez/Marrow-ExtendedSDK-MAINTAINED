using System;
using SLZ.Marrow.Data;
using SLZ.Marrow.PuppetMasta;
using UnityEngine;

namespace SLZ.MLAgents
{
	public class BehaviourBoidBallConfig : BaseEnemyConfig
	{
		[Flags]
		[SerializeField]
		public enum BoidTriggerOptions
		{
			NONE = 1,
			PRIMARY = 2,
			SECONDARY = 4
		}

		[SerializeField]
		[Header("----Boid Specific Section----")]
		[Tooltip("Handles Instantiation of Boid Spawner Automatically")]
		private bool createBoidSpawner;

		[SerializeField]
		[Tooltip("Set spawners concurrent alive and total values = to model manager # of boids")]
		private bool override_spawn_vals;

		[Tooltip("Config File for Boid's Model Manager")]
		[SerializeField]
		public ModelManagerConfig boidManagerConfig;

		[Tooltip("Never stop spawning boids (concurrentTotal = 0)")]
		[SerializeField]
		private bool infiniteBoidSpawns;

		[Tooltip("How many boids will be spawned in total")]
		[SerializeField]
		private int nb_boids;

		[SerializeField]
		[Range(0.1f, 1f)]
		[Tooltip("Range 0 - 1 representing how many slices per tick on the model manager (lower = less overhead, but dumber)")]
		private float overhead_range;

		[SerializeField]
		[Tooltip("Crate reference to boid")]
		private Spawnable boidCrate;

		[Tooltip("Delay between spawns")]
		[SerializeField]
		private float spawnFrequency;

		[Tooltip("To spawn boids at random directions")]
		public bool spawnRandomRotations;

		[Tooltip("Agro boids on the player as soon as they spawn")]
		[SerializeField]
		private bool auto_agro_on_spawn;

		[Tooltip("How long to wait before destroying the boids on death, this is important for killing boid while gripped")]
		[SerializeField]
		private bool delayed_destruction;

		[Tooltip("How long to wait for destroy event after despawn")]
		[SerializeField]
		private int destroyFrames;

		[Tooltip("Whether to destroy the boids on death, this is important for preventing boids from being recycled to different model managers")]
		[SerializeField]
		private bool destroy_on_despawn;

		[SerializeField]
		[Tooltip("Use teleport ball to if it goes to low")]
		[Header("----Boid Ball Section----")]
		public bool useTeleport;

		[Tooltip("Position to teleport ball to if it goes to low")]
		[SerializeField]
		public Vector3 teleportToPos;

		[Tooltip("How low till teleport is initiated")]
		[SerializeField]
		public float yDistTeleportThresh;

		[Tooltip("Outer Radius Min")]
		[SerializeField]
		private float rest_goal_min;

		[Tooltip("Outer Radius Max")]
		[SerializeField]
		private float rest_goal_max;

		[Tooltip("Inner Radius Min")]
		[SerializeField]
		private float rest_prox_min;

		[Tooltip("Inner Radius Max")]
		[SerializeField]
		private float rest_prox_max;

		[Tooltip("Min speed of radius min/max transition")]
		[SerializeField]
		private float rest_lerp_speed_min;

		[Tooltip("Max speed of radius min/max transition")]
		[SerializeField]
		private float rest_lerp_speed_max;

		[SerializeField]
		[Tooltip("Hover Height")]
		private float rest_height;

		[SerializeField]
		[Tooltip("NB Boids to Spawn")]
		private int nbBoidsRest;

		[SerializeField]
		[Tooltip("Outer Radius Min")]
		private float roam_goal_min;

		[SerializeField]
		[Tooltip("Outer Radius Max")]
		private float roam_goal_max;

		[SerializeField]
		[Tooltip("Inner Radius Min")]
		private float roam_prox_min;

		[Tooltip("Inner Radius Max")]
		[SerializeField]
		private float roam_prox_max;

		[SerializeField]
		[Tooltip("Min speed of radius min/max transition")]
		private float roam_lerp_speed_min;

		[Tooltip("Max speed of radius min/max transition")]
		[SerializeField]
		private float roam_lerp_speed_max;

		[Tooltip("Hover Height")]
		[SerializeField]
		private float roam_height;

		[Tooltip("NB Boids to Spawn")]
		[SerializeField]
		private int nbBoidsRoam;

		[Tooltip("Outer Radius Min")]
		[SerializeField]
		private float investigate_goal_min;

		[Tooltip("Outer Radius Max")]
		[SerializeField]
		private float investigate_goal_max;

		[Tooltip("Inner Radius Min")]
		[SerializeField]
		private float investigate_prox_min;

		[SerializeField]
		[Tooltip("Inner Radius Max")]
		private float investigate_prox_max;

		[SerializeField]
		[Tooltip("Min speed of radius min/max transition")]
		private float investigate_lerp_speed_min;

		[Tooltip("Max speed of radius min/max transition")]
		[SerializeField]
		private float investigate_lerp_speed_max;

		[Tooltip("Hover Height")]
		[SerializeField]
		private float investigate_height;

		[Tooltip("NB Boids to Spawn")]
		[SerializeField]
		private int nbBoidsInvestigate;

		[SerializeField]
		[Tooltip("Outer Radius Min")]
		private float agro_goal_min;

		[SerializeField]
		[Tooltip("Outer Radius Max")]
		private float agro_goal_max;

		[Tooltip("Inner Radius Min")]
		[SerializeField]
		private float agro_prox_min;

		[Tooltip("Inner Radius Max")]
		[SerializeField]
		private float agro_prox_max;

		[Tooltip("Min speed of radius min/max transition")]
		[SerializeField]
		private float agro_lerp_speed_min;

		[Tooltip("Max speed of radius min/max transition")]
		[SerializeField]
		private float agro_lerp_speed_max;

		[Tooltip("Hover Height")]
		[SerializeField]
		private float agro_height;

		[SerializeField]
		[Tooltip("NB Boids to Spawn")]
		private int nbBoidsAgro;

		[Tooltip("Amount of time boids spend back at ball between attacks")]
		[SerializeField]
		private float waypointAgroTime;

		public void ApplyToBall(BehaviourBoidBall ball)
		{
		}
	}
}
