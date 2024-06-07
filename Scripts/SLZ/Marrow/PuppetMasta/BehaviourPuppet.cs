using System;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

namespace SLZ.Marrow.PuppetMasta
{
	// Token: 0x020000D8 RID: 216
	[HelpURL("http://root-motion.com/puppetmasterdox/html/page10.html")]
	[AddComponentMenu("Scripts/RootMotion.Dynamics/PuppetMaster/Behaviours/BehaviourPuppet")]
	public class BehaviourPuppet : BehaviourBase
	{
		// Token: 0x060007CC RID: 1996 RVA: 0x00003D1B File Offset: 0x00001F1B
		[ContextMenu("User Manual")]
		private void OpenUserManual()
		{
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00003D1D File Offset: 0x00001F1D
		[ContextMenu("Scrpt Reference")]
		private void OpenScriptReference()
		{
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060007CE RID: 1998 RVA: 0x000072F4 File Offset: 0x000054F4
		// (set) Token: 0x060007CF RID: 1999 RVA: 0x00003D1F File Offset: 0x00001F1F
		public BehaviourPuppet.State state
		{
			[CompilerGenerated]
			get
			{
				return BehaviourPuppet.State.Puppet;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00003D21 File Offset: 0x00001F21
		public override void OnReactivate(int phase = 0)
		{
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00003D23 File Offset: 0x00001F23
		public void Reset(Vector3 position, Quaternion rotation)
		{
		}

		// Token: 0x060007D2 RID: 2002 RVA: 0x00003D25 File Offset: 0x00001F25
		public override void OnTeleport(Quaternion deltaRotation, Vector3 deltaPosition, Vector3 pivot, bool moveToTarget)
		{
		}

		// Token: 0x060007D3 RID: 2003 RVA: 0x00003D27 File Offset: 0x00001F27
		protected override void OnInitiate()
		{
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00003D29 File Offset: 0x00001F29
		protected override void OnActivate()
		{
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00003D2B File Offset: 0x00001F2B
		public override void KillStart()
		{
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00003D2D File Offset: 0x00001F2D
		public override void KillEnd()
		{
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00003D2F File Offset: 0x00001F2F
		public override void Resurrect()
		{
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00003D31 File Offset: 0x00001F31
		protected override void OnDeactivate()
		{
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00003D33 File Offset: 0x00001F33
		protected override void OnFixedUpdate()
		{
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x00003D35 File Offset: 0x00001F35
		protected override void OnLateUpdate()
		{
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x00003D37 File Offset: 0x00001F37
		private bool SetKinematic()
		{
			return false;
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00003D3A File Offset: 0x00001F3A
		protected override void OnReadBehaviour()
		{
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x00003D3C File Offset: 0x00001F3C
		private void BlendMuscleMapping(int muscleIndex, ref bool to)
		{
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x00003D3E File Offset: 0x00001F3E
		public override void OnMuscleAdded(Muscle m)
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x00003D40 File Offset: 0x00001F40
		public override void OnMuscleRemoved(Muscle m)
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x00003D42 File Offset: 0x00001F42
		protected void MoveTarget(Vector3 position)
		{
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x00003D44 File Offset: 0x00001F44
		protected void RotateTarget(Quaternion rotation)
		{
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x00003D46 File Offset: 0x00001F46
		protected override void GroundTarget(LayerMask layers)
		{
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x00003D48 File Offset: 0x00001F48
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x00003D4A File Offset: 0x00001F4A
		public void Boost(float immunity, float impulseMlp)
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x00003D4C File Offset: 0x00001F4C
		public void Boost(int muscleIndex, float immunity, float impulseMlp)
		{
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x00003D4E File Offset: 0x00001F4E
		public void Boost(int muscleIndex, float immunity, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x00003D50 File Offset: 0x00001F50
		public void BoostImmunity(float immunity)
		{
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x00003D52 File Offset: 0x00001F52
		public void BoostImmunity(int muscleIndex, float immunity)
		{
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x00003D54 File Offset: 0x00001F54
		public void BoostImmunity(int muscleIndex, float immunity, float boostParents, float boostChildren)
		{
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x00003D56 File Offset: 0x00001F56
		public void BoostImpulseMlp(float impulseMlp)
		{
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x00003D58 File Offset: 0x00001F58
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp)
		{
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x00003D5A File Offset: 0x00001F5A
		public void BoostImpulseMlp(int muscleIndex, float impulseMlp, float boostParents, float boostChildren)
		{
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00003D5C File Offset: 0x00001F5C
		public void Unpin()
		{
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x00003D5E File Offset: 0x00001F5E
		protected override void OnMuscleHitBehaviour(MuscleHit hit)
		{
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00003D60 File Offset: 0x00001F60
		protected override void OnMuscleCollisionBehaviour(MuscleCollision m)
		{
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x00003D62 File Offset: 0x00001F62
		private float GetImpulse(MuscleCollision m, ref float layerThreshold)
		{
			return 0f;
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00003D69 File Offset: 0x00001F69
		private void UnPin(int muscleIndex, float unpin)
		{
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00003D6B File Offset: 0x00001F6B
		private void UnPinMuscle(int muscleIndex, float unpin)
		{
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00003D6D File Offset: 0x00001F6D
		private bool Activate(Collision collision, float impulse)
		{
			return false;
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x00003D70 File Offset: 0x00001F70
		public bool IsProne()
		{
			return false;
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x00003D73 File Offset: 0x00001F73
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren)
		{
			return 0f;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x00003D7A File Offset: 0x00001F7A
		private float GetFalloff(int i, int muscleIndex, float falloffParents, float falloffChildren, float falloffGroup)
		{
			return 0f;
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x00003D81 File Offset: 0x00001F81
		private bool InGroup(Muscle.Group group1, Muscle.Group group2)
		{
			return false;
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0000730C File Offset: 0x0000550C
		private BehaviourPuppet.MuscleProps GetProps(Muscle.Group group)
		{
			return default(BehaviourPuppet.MuscleProps);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00003D84 File Offset: 0x00001F84
		public void SetState(BehaviourPuppet.State newState)
		{
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x00003D86 File Offset: 0x00001F86
		public void SetColliders(bool unpinned)
		{
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x00003D88 File Offset: 0x00001F88
		private void SetColliders(Muscle m, bool unpinned)
		{
		}

		// Token: 0x04000488 RID: 1160
		public BehaviourPuppet.MasterProps masterProps;

		// Token: 0x04000489 RID: 1161
		[Tooltip("Will ground the target to those layers when getting up.")]
		public LayerMask groundLayers;

		// Token: 0x0400048A RID: 1162
		[Tooltip("Will unpin the muscles that collide with those layers.")]
		public LayerMask collisionLayers;

		// Token: 0x0400048B RID: 1163
		[Tooltip("The collision impulse sqrMagnitude threshold under which collisions will be ignored.")]
		public float collisionThreshold;

		// Token: 0x0400048C RID: 1164
		public Weight collisionResistance;

		// Token: 0x0400048D RID: 1165
		[Tooltip("Multiplies collision resistance for the specified layers.")]
		public BehaviourPuppet.CollisionResistanceMultiplier[] collisionResistanceMultipliers;

		// Token: 0x0400048E RID: 1166
		[Range(1f, 30f)]
		[Tooltip("An optimisation. Will only process up to this number of collisions per physics step.")]
		public int maxCollisions;

		// Token: 0x0400048F RID: 1167
		[Range(0.001f, 10f)]
		[Tooltip("How fast will the muscles of this group regain their pin weight?")]
		public float regainPinSpeed;

		// Token: 0x04000490 RID: 1168
		[Tooltip("'Boosting' is a term used for making muscles temporarily immune to collisions and/or deal more damage to the muscles of other characters. That is done by increasing Muscle.State.immunity and Muscle.State.impulseMlp. For example when you set muscle.state.immunity to 1, boostFalloff will determine how fast this value will fall back to normal (0). Use BehaviourPuppet.BoostImmunity() and BehaviourPuppet.BoostImpulseMlp() for boosting from your own scripts. It is helpful for making the puppet stronger and deliever more punch while playing a melee hitting/kicking animation.")]
		public float boostFalloff;

		// Token: 0x04000491 RID: 1169
		[Tooltip("The default muscle properties. If there are no 'Group Overrides', this will be used for all muscles.")]
		public BehaviourPuppet.MuscleProps defaults;

		// Token: 0x04000492 RID: 1170
		[Tooltip("Overriding default muscle properties for some muscle groups (for example making the feet stiffer or the hands looser).")]
		public BehaviourPuppet.MusclePropsGroup[] groupOverrides;

		// Token: 0x04000493 RID: 1171
		[Tooltip("If the distance from the muscle to it's target is larger than this value, the character will be knocked out.")]
		[Range(0.001f, 10f)]
		public float knockOutDistance;

		// Token: 0x04000494 RID: 1172
		[Range(0f, 1f)]
		[Tooltip("Smaller value makes the muscles weaker when the puppet is knocked out.")]
		public float unpinnedMuscleWeightMlp;

		// Token: 0x04000495 RID: 1173
		[Tooltip("Most character controllers apply supernatural accelerations to characters when changing running direction or jumping. It will require major pinning forces to be applied on the ragdoll to keep up with that acceleration. When a puppet collides with something at that point and is unpinned, those forces might shoot the puppet off to space. This variable limits the velocity of the ragdoll's Rigidbodies when the puppet is unpinned.")]
		public float maxRigidbodyVelocity;

		// Token: 0x04000496 RID: 1174
		[Range(0f, 1f)]
		[Tooltip("If a muscle has drifted farther than 'Knock Out Distance', will only unpin the puppet if it's pin weight is less than this value. Lowering this value will make puppets less likely to lose balance on minor collisions.")]
		public float pinWeightThreshold;

		// Token: 0x04000497 RID: 1175
		[Tooltip("If false, will not unbalance the puppet by muscles that have their pin weight set to 0 in PuppetMaster muscle settings.")]
		public bool unpinnedMuscleKnockout;

		// Token: 0x04000498 RID: 1176
		public bool canGetUp;

		// Token: 0x04000499 RID: 1177
		[Tooltip("Minimum delay for getting up after loosing balance. After that time has passed, will wait for the velocity of the hip muscle to come down below 'Max Get Up Velocity' and then switch to the GetUp state.")]
		public float getUpDelay;

		// Token: 0x0400049A RID: 1178
		[Tooltip("The duration of blending the animation target from the ragdoll pose to the getting up animation once the GetUp state has been triggered.")]
		public float blendToAnimationTime;

		// Token: 0x0400049B RID: 1179
		[Tooltip("Will not get up before the velocity of the hip muscle has come down to this value.")]
		public float maxGetUpVelocity;

		// Token: 0x0400049C RID: 1180
		[Tooltip("The duration of the 'GetUp' state after which it switches to the 'Puppetä state.")]
		public float minGetUpDuration;

		// Token: 0x0400049D RID: 1181
		[Tooltip("Collision resistance multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpCollisionResistanceMlp;

		// Token: 0x0400049E RID: 1182
		[Tooltip("Regain pin weight speed multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpRegainPinSpeedMlp;

		// Token: 0x0400049F RID: 1183
		[Tooltip("Knock out distance multiplier while in the GetUp state. Increasing this will prevent the character from loosing balance again immediatelly after going from Unpinned to GetUp state.")]
		public float getUpKnockOutDistanceMlp;

		// Token: 0x040004A0 RID: 1184
		[Tooltip("Offset of the target character (in character rotation space) from the hip bone when initiating getting up animation from a prone pose. Tweak this value if your character slides a bit when starting to get up.")]
		public Vector3 getUpOffsetProne;

		// Token: 0x040004A1 RID: 1185
		[Tooltip("Offset of the target character (in character rotation space) from the hip bone when initiating getting up animation from a supine pose. Tweak this value if your character slides a bit when starting to get up.")]
		public Vector3 getUpOffsetSupine;

		// Token: 0x040004A2 RID: 1186
		[Tooltip("Called when the character starts getting up from a prone pose (facing down).")]
		public BehaviourBase.PuppetEvent onGetUpProne;

		// Token: 0x040004A3 RID: 1187
		[Tooltip("Called when the character starts getting up from a supine pose (facing up).")]
		public BehaviourBase.PuppetEvent onGetUpSupine;

		// Token: 0x040004A4 RID: 1188
		[Tooltip("Called when the character is knocked out (loses balance). Doesn't matter from which state.")]
		public BehaviourBase.PuppetEvent onLoseBalance;

		// Token: 0x040004A5 RID: 1189
		[Tooltip("Called when the character is knocked out (loses balance) only from the normal Puppet state.")]
		public BehaviourBase.PuppetEvent onLoseBalanceFromPuppet;

		// Token: 0x040004A6 RID: 1190
		[Tooltip("Called when the character is knocked out (loses balance) only from the GetUp state.")]
		public BehaviourBase.PuppetEvent onLoseBalanceFromGetUp;

		// Token: 0x040004A7 RID: 1191
		[Tooltip("Called when the character has fully recovered and switched to the Puppet state.")]
		public BehaviourBase.PuppetEvent onRegainBalance;

		// Token: 0x040004A8 RID: 1192
		public BehaviourBase.CollisionDelegate OnCollision;

		// Token: 0x040004A9 RID: 1193
		public BehaviourPuppet.CollisionImpulseDelegate OnCollisionImpulse;

		// Token: 0x040004AB RID: 1195
		[HideInInspector]
		public bool canMoveTarget;

		// Token: 0x040004AC RID: 1196
		private float unpinnedTimer;

		// Token: 0x040004AD RID: 1197
		private float getUpTimer;

		// Token: 0x040004AE RID: 1198
		private Vector3 hipsForward;

		// Token: 0x040004AF RID: 1199
		private Vector3 hipsUp;

		// Token: 0x040004B0 RID: 1200
		private float getupAnimationBlendWeight;

		// Token: 0x040004B1 RID: 1201
		private float getupAnimationBlendWeightV;

		// Token: 0x040004B2 RID: 1202
		private bool getUpTargetFixed;

		// Token: 0x040004B3 RID: 1203
		private BehaviourPuppet.NormalMode lastNormalMode;

		// Token: 0x040004B4 RID: 1204
		private int collisions;

		// Token: 0x040004B5 RID: 1205
		private bool eventsEnabled;

		// Token: 0x040004B6 RID: 1206
		private float lastKnockOutDistance;

		// Token: 0x040004B7 RID: 1207
		private float knockOutDistanceSqr;

		// Token: 0x040004B8 RID: 1208
		private bool getupDisabled;

		// Token: 0x040004B9 RID: 1209
		private bool hasCollidedSinceGetUp;

		// Token: 0x040004BA RID: 1210
		private bool hasBoosted;

		// Token: 0x040004BB RID: 1211
		private MuscleCollisionBroadcaster broadcaster;

		// Token: 0x040004BC RID: 1212
		private Vector3 getUpPosition;

		// Token: 0x0200023B RID: 571
		[Serializable]
		public enum State
		{
			// Token: 0x04000EA9 RID: 3753
			Puppet,
			// Token: 0x04000EAA RID: 3754
			Unpinned,
			// Token: 0x04000EAB RID: 3755
			GetUp
		}

		// Token: 0x0200023C RID: 572
		[Serializable]
		public enum NormalMode
		{
			// Token: 0x04000EAD RID: 3757
			Active,
			// Token: 0x04000EAE RID: 3758
			Unmapped
		}

		// Token: 0x0200023D RID: 573
		[Serializable]
		public class MasterProps
		{
			// Token: 0x04000EAF RID: 3759
			public BehaviourPuppet.NormalMode normalMode;

			// Token: 0x04000EB0 RID: 3760
			public float mappingBlendSpeed;

			// Token: 0x04000EB1 RID: 3761
			public bool activateOnStaticCollisions;

			// Token: 0x04000EB2 RID: 3762
			public float activateOnImpulse;
		}

		// Token: 0x0200023E RID: 574
		[Serializable]
		public struct MuscleProps
		{
			// Token: 0x04000EB3 RID: 3763
			[Tooltip("How much will collisions with muscles of this group unpin parent muscles?")]
			[Range(0f, 1f)]
			public float unpinParents;

			// Token: 0x04000EB4 RID: 3764
			[Tooltip("How much will collisions with muscles of this group unpin child muscles?")]
			[Range(0f, 1f)]
			public float unpinChildren;

			// Token: 0x04000EB5 RID: 3765
			[Range(0f, 1f)]
			[Tooltip("How much will collisions with muscles of this group unpin muscles of the same group?")]
			public float unpinGroup;

			// Token: 0x04000EB6 RID: 3766
			[Tooltip("If 1, muscles of this group will always be mapped to the ragdoll.")]
			[Range(0f, 1f)]
			public float minMappingWeight;

			// Token: 0x04000EB7 RID: 3767
			[Tooltip("If 0, muscles of this group will not be mapped to the ragdoll pose even if they are unpinned.")]
			[Range(0f, 1f)]
			public float maxMappingWeight;

			// Token: 0x04000EB8 RID: 3768
			[Tooltip("If true, muscles of this group will have their colliders disabled while in puppet state (not unbalanced nor getting up).")]
			public bool disableColliders;

			// Token: 0x04000EB9 RID: 3769
			[Tooltip("How fast will muscles of this group regain their pin weight (multiplier)?")]
			public float regainPinSpeed;

			// Token: 0x04000EBA RID: 3770
			[Tooltip("Smaller value means more unpinning from collisions (multiplier).")]
			public float collisionResistance;

			// Token: 0x04000EBB RID: 3771
			[Tooltip("If the distance from the muscle to it's target is larger than this value, the character will be knocked out.")]
			public float knockOutDistance;

			// Token: 0x04000EBC RID: 3772
			[Tooltip("The PhysicsMaterial applied to the muscles while the character is in Puppet or GetUp state. Using a lower friction material reduces the risk of muscles getting stuck and pulled out of their joints.")]
			public PhysicMaterial puppetMaterial;

			// Token: 0x04000EBD RID: 3773
			[Tooltip("The PhysicsMaterial applied to the muscles while the character is in Unpinned state.")]
			public PhysicMaterial unpinnedMaterial;
		}

		// Token: 0x0200023F RID: 575
		[Serializable]
		public struct MusclePropsGroup
		{
			// Token: 0x04000EBE RID: 3774
			[HideInInspector]
			public string name;

			// Token: 0x04000EBF RID: 3775
			[Tooltip("Muscle groups to which those properties apply.")]
			public Muscle.Group[] groups;

			// Token: 0x04000EC0 RID: 3776
			[Tooltip("The muscle properties for those muscle groups.")]
			public BehaviourPuppet.MuscleProps props;
		}

		// Token: 0x02000240 RID: 576
		[Serializable]
		public struct CollisionResistanceMultiplier
		{
			// Token: 0x04000EC1 RID: 3777
			public LayerMask layers;

			// Token: 0x04000EC2 RID: 3778
			[Tooltip("Multiplier for the 'Collision Resistance' for these layers.")]
			public float multiplier;

			// Token: 0x04000EC3 RID: 3779
			[Tooltip("Overrides 'Collision Threshold' for these layers.")]
			public float collisionThreshold;
		}

		// Token: 0x02000241 RID: 577
		// (Invoke) Token: 0x0600112D RID: 4397
		public delegate void CollisionImpulseDelegate(MuscleCollision m, float impulse);
	}
}
