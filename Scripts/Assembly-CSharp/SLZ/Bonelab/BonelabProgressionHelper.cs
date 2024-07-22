using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Newtonsoft.Json.Linq;
using SLZ.Bonelab.SaveData;
using SLZ.Marrow;
using SLZ.Marrow.SaveData;
using SLZ.Marrow.Warehouse;
using UnityEngine;

namespace SLZ.Bonelab
{
	public static class BonelabProgressionHelper
	{
		internal enum Level
		{
			Descent = 0,
			LongRun = 1,
			Ascent = 2,
			Outro = 3,
			None = 4
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003C_restoreSlotsOnReady_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public Transform leftHand;

			public Transform rightHand;

			public JObject inventoryJson;

			public Func<Barcode, Barcode> itemFilter;

			public Inventory inventory;

			private UniTask<bool[]>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

            void IAsyncStateMachine.MoveNext()
            {
                throw new NotImplementedException();
            }

            [DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

            void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
            {
                throw new NotImplementedException();
            }
        }

		public const string INITIAL_INVENTORY = "SLZ.Bonelab.initial_inventory";

		public const string IN_PROGRESS_INVENTORY = "SLZ.Bonelab.in_progress_inventory";

		public const string FINAL_INVENTORY_DEPRECATED = "SLZ.Bonelab.final_inventory";

		public const string FINAL_AMMO_DELTA = "SLZ.Bonelab.final_ammo_delta";

		public const string IN_PROGRESS_AMMO = "SLZ.Bonelab.in_progress_ammo";

		public static Dictionary<string, int> CalculateStartingAmmo(this PlayerProgression progression, params string[] priorLevels)
		{
			return null;
		}

		public static Dictionary<string, int> CalculateFinalAmmoDelta(this PlayerProgression progression, params string[] priorLevels)
		{
			return null;
		}

		public static Dictionary<string, int> UpdateFinalAmmoDelta(this PlayerProgression progression, string levelKey, params string[] priorLevels)
		{
			return null;
		}

		public static Dictionary<string, Dictionary<string, int>> GatherAmmoDeltas(this PlayerProgression progression)
		{
			return null;
		}

		private static bool GatherInventory(out JObject slotBarcodes)
		{
			slotBarcodes = null;
			return false;
		}

		public static bool RestoreInventory(this PlayerProgression progression, string levelKey, bool freshLoad, Transform leftHand, Transform rightHand, Func<Barcode, Barcode> itemFilter = null, params string[] priorLevels)
		{
			return false;
		}

		[AsyncStateMachine(typeof(_003C_restoreSlotsOnReady_003Ed__11))]
		private static UniTaskVoid _restoreSlotsOnReady(Inventory inventory, JObject inventoryJson, Transform leftHand, Transform rightHand, Func<Barcode, Barcode> itemFilter)
		{
			return default(UniTaskVoid);
		}

		public static bool SaveInProgressAmmoCount(this PlayerProgression progression, string levelKey)
		{
			return false;
		}

		public static void RestoreAmmoCounts(this PlayerProgression progression, string levelKey, bool freshLoad, params string[] priorLevels)
		{
		}

		public static bool PushInventoryInto(this PlayerProgression progression, params string[] intoLevelKeys)
		{
			return false;
		}

		public static bool SaveInventoryInProgress(this PlayerProgression progression, string levelKey)
		{
			return false;
		}

		[Obsolete("To be replaced with PushInventoryInto")]
		public static bool SaveInventoryFinal_Deprecated(this PlayerProgression progression, string levelKey)
		{
			return false;
		}

		internal static void DeletePartialProgressForKey(this PlayerProgression p, string levelKey, Confirmation1 confirmation = Confirmation1.IMadeAMistake)
		{
		}

		internal static void DeletePartialProgressForLevelsExcept(this PlayerProgression p, Level level)
		{
		}

		internal static void KeywiseAdd(this Dictionary<string, int> dict, Dictionary<string, int> other)
		{
		}

		internal static void KeywiseSubtract(this Dictionary<string, int> dict, Dictionary<string, int> other)
		{
		}

		internal static void KeywiseMax(this Dictionary<string, int> dict, Dictionary<string, int> other)
		{
		}
	}
}
