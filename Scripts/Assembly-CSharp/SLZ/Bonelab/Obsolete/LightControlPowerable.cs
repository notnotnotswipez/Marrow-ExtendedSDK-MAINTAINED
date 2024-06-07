using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace SLZ.Bonelab.Obsolete
{
	public class LightControlPowerable : Powerable
	{
		[CompilerGenerated]
		private sealed class _003CFlickerLight_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{

			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LightControlPowerable _003C_003E4__this;

			private float _003CblinkRange_003E5__2;

			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CFlickerLight_003Ed__24(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
				throw new NotImplementedException();
			}

			public object Current { get; }

			object IEnumerator.Current => Current;

			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			bool IEnumerator.MoveNext()
			{
				return MoveNext();
			}

			public void Dispose()
			{
				throw new NotImplementedException();
			}
		}

		[Header("VOLTAGE")]
		public bool isBinary;

		public bool Flicker;

		[Space(5f)]
		public float min_InputVoltage;

		public float max_InputVoltage;

		[Range(-1f, 1f)]
		public float cur_InputVoltage;

		[Space(5f)]
		public float min_LightVoltage;

		public float max_LightVoltage;

		private float att_LightVoltage;

		[Space(5f)]
		public float min_EmissiveVoltage;

		public float max_EmissiveVoltage;

		private float att_EmissiveVoltage;

		[Space(5f)]
		[Header("LIGHT MESH SOURCES")]
		public Renderer mat_Renderer;

		public Renderer mat_haloRenderer;

		[Range(0f, 1f)]
		public float per_Blink;

		[ColorUsage(true, true)]
		public Color hdr_OnColor;

		[ColorUsage(true, true)]
		public Color hdr_OffColor;

		[Space(5f)]
		[Header("LIGHT SOURCES")]
		[Tooltip("Only assign a value if you intend to modify a lightsource too")]
		public Light light_Actual;

		[Tooltip("If there is a lightSource, then modify this color value to modify the Light Component's Color")]
		[ColorUsage(true, true)]
		public Color color_LightOn;

		[ColorUsage(true, true)]
		public Color color_LightOff;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public override void SwitchPowerOnOff(bool isOn)
		{
		}

		public override void VoltageToObject(float voltage, int id = 0)
		{
		}

		public void BeginFlicker()
		{
		}

		[IteratorStateMachine(typeof(_003CFlickerLight_003Ed__24))]
		private IEnumerator FlickerLight()
		{
			return null;
		}

		public void SETLIGHT(float voltage = 1f)
		{
		}

		public void SETLIGHTMESH(float voltage = 1f)
		{
		}

		private Color LerpColor(float voltage, Color a, Color b)
		{
			return default(Color);
		}
	}
}
