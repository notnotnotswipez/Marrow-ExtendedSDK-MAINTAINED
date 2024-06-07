using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.XR;

namespace SLZ.Marrow.Input
{
	// Token: 0x02000153 RID: 339
	public class InputActions : IInputActionCollection2, IInputActionCollection, IEnumerable<InputAction>, IEnumerable, IDisposable
	{
		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00004B03 File Offset: 0x00002D03
		public InputActionAsset asset
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x00004B0E File Offset: 0x00002D0E
		public void Dispose()
		{
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000CD5 RID: 3285 RVA: 0x00007DEC File Offset: 0x00005FEC
		// (set) Token: 0x06000CD6 RID: 3286 RVA: 0x00004B10 File Offset: 0x00002D10
		public InputBinding? bindingMask
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000CD7 RID: 3287 RVA: 0x00007E04 File Offset: 0x00006004
		// (set) Token: 0x06000CD8 RID: 3288 RVA: 0x00004B12 File Offset: 0x00002D12
		public ReadOnlyArray<InputDevice>? devices
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000CD9 RID: 3289 RVA: 0x00007E1C File Offset: 0x0000601C
		public ReadOnlyArray<InputControlScheme> controlSchemes
		{
			get
			{
				return default(ReadOnlyArray<InputControlScheme>);
			}
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00004B14 File Offset: 0x00002D14
		public bool Contains(InputAction action)
		{
			return false;
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00004B17 File Offset: 0x00002D17
		public IEnumerator<InputAction> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00004B1A File Offset: 0x00002D1A
		 IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x06000CDD RID: 3293 RVA: 0x00004B1D File Offset: 0x00002D1D
		public void Enable()
		{
		}

		// Token: 0x06000CDE RID: 3294 RVA: 0x00004B1F File Offset: 0x00002D1F
		public void Disable()
		{
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x06000CDF RID: 3295 RVA: 0x00004B21 File Offset: 0x00002D21
		public IEnumerable<InputBinding> bindings
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06000CE0 RID: 3296 RVA: 0x00004B24 File Offset: 0x00002D24
		public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
		{
			return null;
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00004B27 File Offset: 0x00002D27
		public int FindBinding(InputBinding bindingMask, out InputAction action)
		{
			action = null;
			return 0;
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x00007E34 File Offset: 0x00006034
		public InputActions.HMDActions HMD
		{
			get
			{
				return default(InputActions.HMDActions);
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000CE3 RID: 3299 RVA: 0x00007E4C File Offset: 0x0000604C
		public InputActions.ControllerLActions ControllerL
		{
			get
			{
				return default(InputActions.ControllerLActions);
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00007E64 File Offset: 0x00006064
		public InputActions.ControllerRActions ControllerR
		{
			get
			{
				return default(InputActions.ControllerRActions);
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000CE5 RID: 3301 RVA: 0x00007E7C File Offset: 0x0000607C
		public InputActions.GamepadActions Gamepad
		{
			get
			{
				return default(InputActions.GamepadActions);
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00007E94 File Offset: 0x00006094
		public InputActions.MouseActions Mouse
		{
			get
			{
				return default(InputActions.MouseActions);
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000CE7 RID: 3303 RVA: 0x00007EAC File Offset: 0x000060AC
		public InputActions.PositionalKeyboardActions PositionalKeyboard
		{
			get
			{
				return default(InputActions.PositionalKeyboardActions);
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x00007EC4 File Offset: 0x000060C4
		public InputActions.JoystickActions Joystick
		{
			get
			{
				return default(InputActions.JoystickActions);
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000CE9 RID: 3305 RVA: 0x00007EDC File Offset: 0x000060DC
		public InputActions.TrackersActions Trackers
		{
			get
			{
				return default(InputActions.TrackersActions);
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00007EF4 File Offset: 0x000060F4
		public InputControlScheme XRUsageScheme
		{
			get
			{
				return default(InputControlScheme);
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000CEB RID: 3307 RVA: 0x00007F0C File Offset: 0x0000610C
		public InputControlScheme GamepadScheme
		{
			get
			{
				return default(InputControlScheme);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x00007F24 File Offset: 0x00006124
		public InputControlScheme PositionalKeyboardMouseScheme
		{
			get
			{
				return default(InputControlScheme);
			}
		}

		// Token: 0x040007B9 RID: 1977
		private readonly InputActionMap m_HMD;

		// Token: 0x040007BA RID: 1978
		private List<InputActions.IHMDActions> m_HMDActionsCallbackInterfaces;

		// Token: 0x040007BB RID: 1979
		private readonly InputAction m_HMD_TrackingState;

		// Token: 0x040007BC RID: 1980
		private readonly InputAction m_HMD_Position;

		// Token: 0x040007BD RID: 1981
		private readonly InputAction m_HMD_Rotation;

		// Token: 0x040007BE RID: 1982
		private readonly InputAction m_HMD_Velocity;

		// Token: 0x040007BF RID: 1983
		private readonly InputAction m_HMD_AngularVelocity;

		// Token: 0x040007C0 RID: 1984
		private readonly InputAction m_HMD_IsTracked;

		// Token: 0x040007C1 RID: 1985
		private readonly InputActionMap m_ControllerL;

		// Token: 0x040007C2 RID: 1986
		private List<InputActions.IControllerLActions> m_ControllerLActionsCallbackInterfaces;

		// Token: 0x040007C3 RID: 1987
		private readonly InputAction m_ControllerL_TrackingState;

		// Token: 0x040007C4 RID: 1988
		private readonly InputAction m_ControllerL_PalmPose;

		// Token: 0x040007C5 RID: 1989
		private readonly InputAction m_ControllerL_PointerPose;

		// Token: 0x040007C6 RID: 1990
		private readonly InputAction m_ControllerL_Velocity;

		// Token: 0x040007C7 RID: 1991
		private readonly InputAction m_ControllerL_AngularVelocity;

		// Token: 0x040007C8 RID: 1992
		private readonly InputAction m_ControllerL_Primary2DAxis;

		// Token: 0x040007C9 RID: 1993
		private readonly InputAction m_ControllerL_Primary2DAxisClick;

		// Token: 0x040007CA RID: 1994
		private readonly InputAction m_ControllerL_Primary2DAxisTouch;

		// Token: 0x040007CB RID: 1995
		private readonly InputAction m_ControllerL_Touchpad;

		// Token: 0x040007CC RID: 1996
		private readonly InputAction m_ControllerL_TouchpadClick;

		// Token: 0x040007CD RID: 1997
		private readonly InputAction m_ControllerL_TouchpadTouch;

		// Token: 0x040007CE RID: 1998
		private readonly InputAction m_ControllerL_Trigger;

		// Token: 0x040007CF RID: 1999
		private readonly InputAction m_ControllerL_TriggerPress;

		// Token: 0x040007D0 RID: 2000
		private readonly InputAction m_ControllerL_TriggerTouch;

		// Token: 0x040007D1 RID: 2001
		private readonly InputAction m_ControllerL_Grip;

		// Token: 0x040007D2 RID: 2002
		private readonly InputAction m_ControllerL_GripPress;

		// Token: 0x040007D3 RID: 2003
		private readonly InputAction m_ControllerL_GripForce;

		// Token: 0x040007D4 RID: 2004
		private readonly InputAction m_ControllerL_PrimaryButton;

		// Token: 0x040007D5 RID: 2005
		private readonly InputAction m_ControllerL_PrimaryTouch;

		// Token: 0x040007D6 RID: 2006
		private readonly InputAction m_ControllerL_SecondaryButton;

		// Token: 0x040007D7 RID: 2007
		private readonly InputAction m_ControllerL_SecondaryTouch;

		// Token: 0x040007D8 RID: 2008
		private readonly InputAction m_ControllerL_MenuButton;

		// Token: 0x040007D9 RID: 2009
		private readonly InputAction m_ControllerL_Haptic;

		// Token: 0x040007DA RID: 2010
		private readonly InputAction m_ControllerL_IsTracked;

		// Token: 0x040007DB RID: 2011
		private readonly InputActionMap m_ControllerR;

		// Token: 0x040007DC RID: 2012
		private List<InputActions.IControllerRActions> m_ControllerRActionsCallbackInterfaces;

		// Token: 0x040007DD RID: 2013
		private readonly InputAction m_ControllerR_TrackingState;

		// Token: 0x040007DE RID: 2014
		private readonly InputAction m_ControllerR_PalmPose;

		// Token: 0x040007DF RID: 2015
		private readonly InputAction m_ControllerR_PointerPose;

		// Token: 0x040007E0 RID: 2016
		private readonly InputAction m_ControllerR_Velocity;

		// Token: 0x040007E1 RID: 2017
		private readonly InputAction m_ControllerR_AngularVelocity;

		// Token: 0x040007E2 RID: 2018
		private readonly InputAction m_ControllerR_Primary2DAxis;

		// Token: 0x040007E3 RID: 2019
		private readonly InputAction m_ControllerR_Primary2DAxisClick;

		// Token: 0x040007E4 RID: 2020
		private readonly InputAction m_ControllerR_Primary2DAxisTouch;

		// Token: 0x040007E5 RID: 2021
		private readonly InputAction m_ControllerR_Touchpad;

		// Token: 0x040007E6 RID: 2022
		private readonly InputAction m_ControllerR_TouchpadClick;

		// Token: 0x040007E7 RID: 2023
		private readonly InputAction m_ControllerR_TouchpadTouch;

		// Token: 0x040007E8 RID: 2024
		private readonly InputAction m_ControllerR_Trigger;

		// Token: 0x040007E9 RID: 2025
		private readonly InputAction m_ControllerR_TriggerPress;

		// Token: 0x040007EA RID: 2026
		private readonly InputAction m_ControllerR_TriggerTouch;

		// Token: 0x040007EB RID: 2027
		private readonly InputAction m_ControllerR_Grip;

		// Token: 0x040007EC RID: 2028
		private readonly InputAction m_ControllerR_GripPress;

		// Token: 0x040007ED RID: 2029
		private readonly InputAction m_ControllerR_GripForce;

		// Token: 0x040007EE RID: 2030
		private readonly InputAction m_ControllerR_PrimaryButton;

		// Token: 0x040007EF RID: 2031
		private readonly InputAction m_ControllerR_PrimaryTouch;

		// Token: 0x040007F0 RID: 2032
		private readonly InputAction m_ControllerR_SecondaryButton;

		// Token: 0x040007F1 RID: 2033
		private readonly InputAction m_ControllerR_SecondaryTouch;

		// Token: 0x040007F2 RID: 2034
		private readonly InputAction m_ControllerR_Haptic;

		// Token: 0x040007F3 RID: 2035
		private readonly InputAction m_ControllerR_IsTracked;

		// Token: 0x040007F4 RID: 2036
		private readonly InputActionMap m_Gamepad;

		// Token: 0x040007F5 RID: 2037
		private List<InputActions.IGamepadActions> m_GamepadActionsCallbackInterfaces;

		// Token: 0x040007F6 RID: 2038
		private readonly InputAction m_Gamepad_LeftJoystick2DAxis;

		// Token: 0x040007F7 RID: 2039
		private readonly InputAction m_Gamepad_LeftTrigger1DAxis;

		// Token: 0x040007F8 RID: 2040
		private readonly InputAction m_Gamepad_LeftJoystickButton;

		// Token: 0x040007F9 RID: 2041
		private readonly InputAction m_Gamepad_LeftShoulderButton;

		// Token: 0x040007FA RID: 2042
		private readonly InputAction m_Gamepad_LeftNorthButton;

		// Token: 0x040007FB RID: 2043
		private readonly InputAction m_Gamepad_LeftEastButton;

		// Token: 0x040007FC RID: 2044
		private readonly InputAction m_Gamepad_LeftSouthButton;

		// Token: 0x040007FD RID: 2045
		private readonly InputAction m_Gamepad_LeftWestButton;

		// Token: 0x040007FE RID: 2046
		private readonly InputAction m_Gamepad_SelectButton;

		// Token: 0x040007FF RID: 2047
		private readonly InputAction m_Gamepad_RightJoystick2DAxis;

		// Token: 0x04000800 RID: 2048
		private readonly InputAction m_Gamepad_RightTrigger1DAxis;

		// Token: 0x04000801 RID: 2049
		private readonly InputAction m_Gamepad_RightJoystickButton;

		// Token: 0x04000802 RID: 2050
		private readonly InputAction m_Gamepad_RightShoulderButton;

		// Token: 0x04000803 RID: 2051
		private readonly InputAction m_Gamepad_RightNorthButton;

		// Token: 0x04000804 RID: 2052
		private readonly InputAction m_Gamepad_RightEastButton;

		// Token: 0x04000805 RID: 2053
		private readonly InputAction m_Gamepad_RightSouthButton;

		// Token: 0x04000806 RID: 2054
		private readonly InputAction m_Gamepad_RightWestButton;

		// Token: 0x04000807 RID: 2055
		private readonly InputAction m_Gamepad_StartButton;

		// Token: 0x04000808 RID: 2056
		private readonly InputActionMap m_Mouse;

		// Token: 0x04000809 RID: 2057
		private List<InputActions.IMouseActions> m_MouseActionsCallbackInterfaces;

		// Token: 0x0400080A RID: 2058
		private readonly InputAction m_Mouse_Mouse_ForwardButton;

		// Token: 0x0400080B RID: 2059
		private readonly InputAction m_Mouse_Mouse_BackButton;

		// Token: 0x0400080C RID: 2060
		private readonly InputAction m_Mouse_Mouse_RButton;

		// Token: 0x0400080D RID: 2061
		private readonly InputAction m_Mouse_Mouse_MButton;

		// Token: 0x0400080E RID: 2062
		private readonly InputAction m_Mouse_Mouse_LButton;

		// Token: 0x0400080F RID: 2063
		private readonly InputAction m_Mouse_Mouse_Delta;

		// Token: 0x04000810 RID: 2064
		private readonly InputAction m_Mouse_Mouse_Scroll;

		// Token: 0x04000811 RID: 2065
		private readonly InputActionMap m_PositionalKeyboard;

		// Token: 0x04000812 RID: 2066
		private List<InputActions.IPositionalKeyboardActions> m_PositionalKeyboardActionsCallbackInterfaces;

		// Token: 0x04000813 RID: 2067
		private readonly InputAction m_PositionalKeyboard_Positional_Escape;

		// Token: 0x04000814 RID: 2068
		private readonly InputAction m_PositionalKeyboard_Positional_Space;

		// Token: 0x04000815 RID: 2069
		private readonly InputAction m_PositionalKeyboard_Positional_Enter;

		// Token: 0x04000816 RID: 2070
		private readonly InputAction m_PositionalKeyboard_Positional_Tab;

		// Token: 0x04000817 RID: 2071
		private readonly InputAction m_PositionalKeyboard_Positional_Backquote;

		// Token: 0x04000818 RID: 2072
		private readonly InputAction m_PositionalKeyboard_Positional_Quote;

		// Token: 0x04000819 RID: 2073
		private readonly InputAction m_PositionalKeyboard_Positional_Semicolon;

		// Token: 0x0400081A RID: 2074
		private readonly InputAction m_PositionalKeyboard_Positional_Comma;

		// Token: 0x0400081B RID: 2075
		private readonly InputAction m_PositionalKeyboard_Positional_Period;

		// Token: 0x0400081C RID: 2076
		private readonly InputAction m_PositionalKeyboard_Positional_Slash;

		// Token: 0x0400081D RID: 2077
		private readonly InputAction m_PositionalKeyboard_Positional_Backslash;

		// Token: 0x0400081E RID: 2078
		private readonly InputAction m_PositionalKeyboard_Positional_LeftBracket;

		// Token: 0x0400081F RID: 2079
		private readonly InputAction m_PositionalKeyboard_Positional_RightBracket;

		// Token: 0x04000820 RID: 2080
		private readonly InputAction m_PositionalKeyboard_Positional_Minus;

		// Token: 0x04000821 RID: 2081
		private readonly InputAction m_PositionalKeyboard_Positional_Equals;

		// Token: 0x04000822 RID: 2082
		private readonly InputAction m_PositionalKeyboard_Positional_UpArrow;

		// Token: 0x04000823 RID: 2083
		private readonly InputAction m_PositionalKeyboard_Positional_DownArrow;

		// Token: 0x04000824 RID: 2084
		private readonly InputAction m_PositionalKeyboard_Positional_LeftArrow;

		// Token: 0x04000825 RID: 2085
		private readonly InputAction m_PositionalKeyboard_Positional_RightArrow;

		// Token: 0x04000826 RID: 2086
		private readonly InputAction m_PositionalKeyboard_Positional_A;

		// Token: 0x04000827 RID: 2087
		private readonly InputAction m_PositionalKeyboard_Positional_B;

		// Token: 0x04000828 RID: 2088
		private readonly InputAction m_PositionalKeyboard_Positional_C;

		// Token: 0x04000829 RID: 2089
		private readonly InputAction m_PositionalKeyboard_Positional_D;

		// Token: 0x0400082A RID: 2090
		private readonly InputAction m_PositionalKeyboard_Positional_E;

		// Token: 0x0400082B RID: 2091
		private readonly InputAction m_PositionalKeyboard_Positional_F;

		// Token: 0x0400082C RID: 2092
		private readonly InputAction m_PositionalKeyboard_Positional_G;

		// Token: 0x0400082D RID: 2093
		private readonly InputAction m_PositionalKeyboard_Positional_H;

		// Token: 0x0400082E RID: 2094
		private readonly InputAction m_PositionalKeyboard_Positional_I;

		// Token: 0x0400082F RID: 2095
		private readonly InputAction m_PositionalKeyboard_Positional_J;

		// Token: 0x04000830 RID: 2096
		private readonly InputAction m_PositionalKeyboard_Positional_K;

		// Token: 0x04000831 RID: 2097
		private readonly InputAction m_PositionalKeyboard_Positional_L;

		// Token: 0x04000832 RID: 2098
		private readonly InputAction m_PositionalKeyboard_Positional_M;

		// Token: 0x04000833 RID: 2099
		private readonly InputAction m_PositionalKeyboard_Positional_N;

		// Token: 0x04000834 RID: 2100
		private readonly InputAction m_PositionalKeyboard_Positional_O;

		// Token: 0x04000835 RID: 2101
		private readonly InputAction m_PositionalKeyboard_Positional_P;

		// Token: 0x04000836 RID: 2102
		private readonly InputAction m_PositionalKeyboard_Positional_Q;

		// Token: 0x04000837 RID: 2103
		private readonly InputAction m_PositionalKeyboard_Positional_R;

		// Token: 0x04000838 RID: 2104
		private readonly InputAction m_PositionalKeyboard_Positional_S;

		// Token: 0x04000839 RID: 2105
		private readonly InputAction m_PositionalKeyboard_Positional_T;

		// Token: 0x0400083A RID: 2106
		private readonly InputAction m_PositionalKeyboard_Positional_U;

		// Token: 0x0400083B RID: 2107
		private readonly InputAction m_PositionalKeyboard_Positional_V;

		// Token: 0x0400083C RID: 2108
		private readonly InputAction m_PositionalKeyboard_Positional_W;

		// Token: 0x0400083D RID: 2109
		private readonly InputAction m_PositionalKeyboard_Positional_X;

		// Token: 0x0400083E RID: 2110
		private readonly InputAction m_PositionalKeyboard_Positional_Y;

		// Token: 0x0400083F RID: 2111
		private readonly InputAction m_PositionalKeyboard_Positional_Z;

		// Token: 0x04000840 RID: 2112
		private readonly InputAction m_PositionalKeyboard_Positional_1;

		// Token: 0x04000841 RID: 2113
		private readonly InputAction m_PositionalKeyboard_Positional_2;

		// Token: 0x04000842 RID: 2114
		private readonly InputAction m_PositionalKeyboard_Positional_3;

		// Token: 0x04000843 RID: 2115
		private readonly InputAction m_PositionalKeyboard_Positional_4;

		// Token: 0x04000844 RID: 2116
		private readonly InputAction m_PositionalKeyboard_Positional_5;

		// Token: 0x04000845 RID: 2117
		private readonly InputAction m_PositionalKeyboard_Positional_6;

		// Token: 0x04000846 RID: 2118
		private readonly InputAction m_PositionalKeyboard_Positional_7;

		// Token: 0x04000847 RID: 2119
		private readonly InputAction m_PositionalKeyboard_Positional_8;

		// Token: 0x04000848 RID: 2120
		private readonly InputAction m_PositionalKeyboard_Positional_9;

		// Token: 0x04000849 RID: 2121
		private readonly InputAction m_PositionalKeyboard_Positional_0;

		// Token: 0x0400084A RID: 2122
		private readonly InputAction m_PositionalKeyboard_Positional_LeftShift;

		// Token: 0x0400084B RID: 2123
		private readonly InputAction m_PositionalKeyboard_Positional_RightShift;

		// Token: 0x0400084C RID: 2124
		private readonly InputAction m_PositionalKeyboard_Positional_LeftAlt;

		// Token: 0x0400084D RID: 2125
		private readonly InputAction m_PositionalKeyboard_Positional_RightAlt;

		// Token: 0x0400084E RID: 2126
		private readonly InputAction m_PositionalKeyboard_Positional_LeftCtrl;

		// Token: 0x0400084F RID: 2127
		private readonly InputAction m_PositionalKeyboard_Positional_RightCtrl;

		// Token: 0x04000850 RID: 2128
		private readonly InputAction m_PositionalKeyboard_Positional_LeftMeta;

		// Token: 0x04000851 RID: 2129
		private readonly InputAction m_PositionalKeyboard_Positional_RightMeta;

		// Token: 0x04000852 RID: 2130
		private readonly InputAction m_PositionalKeyboard_Positional_ContextMenu;

		// Token: 0x04000853 RID: 2131
		private readonly InputAction m_PositionalKeyboard_Positional_Backspace;

		// Token: 0x04000854 RID: 2132
		private readonly InputAction m_PositionalKeyboard_Positional_PageDown;

		// Token: 0x04000855 RID: 2133
		private readonly InputAction m_PositionalKeyboard_Positional_PageUp;

		// Token: 0x04000856 RID: 2134
		private readonly InputAction m_PositionalKeyboard_Positional_Home;

		// Token: 0x04000857 RID: 2135
		private readonly InputAction m_PositionalKeyboard_Positional_End;

		// Token: 0x04000858 RID: 2136
		private readonly InputAction m_PositionalKeyboard_Positional_Insert;

		// Token: 0x04000859 RID: 2137
		private readonly InputAction m_PositionalKeyboard_Positional_Delete;

		// Token: 0x0400085A RID: 2138
		private readonly InputAction m_PositionalKeyboard_Positional_CapsLock;

		// Token: 0x0400085B RID: 2139
		private readonly InputAction m_PositionalKeyboard_Positional_NumLock;

		// Token: 0x0400085C RID: 2140
		private readonly InputAction m_PositionalKeyboard_Positional_PrintScreen;

		// Token: 0x0400085D RID: 2141
		private readonly InputAction m_PositionalKeyboard_Positional_ScrollLock;

		// Token: 0x0400085E RID: 2142
		private readonly InputAction m_PositionalKeyboard_Positional_Pause;

		// Token: 0x0400085F RID: 2143
		private readonly InputAction m_PositionalKeyboard_Positional_NumpadEnter;

		// Token: 0x04000860 RID: 2144
		private readonly InputAction m_PositionalKeyboard_Positional_NumpadDivide;

		// Token: 0x04000861 RID: 2145
		private readonly InputAction m_PositionalKeyboard_Positional_NumpadMultiply;

		// Token: 0x04000862 RID: 2146
		private readonly InputAction m_PositionalKeyboard_Positional_NumpadPlus;

		// Token: 0x04000863 RID: 2147
		private readonly InputAction m_PositionalKeyboard_Positional_NumpadMinus;

		// Token: 0x04000864 RID: 2148
		private readonly InputAction m_PositionalKeyboard_Positional_NumpadPeriod;

		// Token: 0x04000865 RID: 2149
		private readonly InputAction m_PositionalKeyboard_Positional_NumpadEquals;

		// Token: 0x04000866 RID: 2150
		private readonly InputAction m_PositionalKeyboard_Positional_Numpad1;

		// Token: 0x04000867 RID: 2151
		private readonly InputAction m_PositionalKeyboard_Positional_Numpad2;

		// Token: 0x04000868 RID: 2152
		private readonly InputAction m_PositionalKeyboard_Positional_Numpad3;

		// Token: 0x04000869 RID: 2153
		private readonly InputAction m_PositionalKeyboard_Positional_Numpad4;

		// Token: 0x0400086A RID: 2154
		private readonly InputAction m_PositionalKeyboard_Positional_Numpad5;

		// Token: 0x0400086B RID: 2155
		private readonly InputAction m_PositionalKeyboard_Positional_Numpad6;

		// Token: 0x0400086C RID: 2156
		private readonly InputAction m_PositionalKeyboard_Positional_Numpad7;

		// Token: 0x0400086D RID: 2157
		private readonly InputAction m_PositionalKeyboard_Positional_Numpad8;

		// Token: 0x0400086E RID: 2158
		private readonly InputAction m_PositionalKeyboard_Positional_Numpad9;

		// Token: 0x0400086F RID: 2159
		private readonly InputAction m_PositionalKeyboard_Positional_Numpad0;

		// Token: 0x04000870 RID: 2160
		private readonly InputAction m_PositionalKeyboard_Positional_F1;

		// Token: 0x04000871 RID: 2161
		private readonly InputAction m_PositionalKeyboard_Positional_F2;

		// Token: 0x04000872 RID: 2162
		private readonly InputAction m_PositionalKeyboard_Positional_F3;

		// Token: 0x04000873 RID: 2163
		private readonly InputAction m_PositionalKeyboard_Positional_F4;

		// Token: 0x04000874 RID: 2164
		private readonly InputAction m_PositionalKeyboard_Positional_F5;

		// Token: 0x04000875 RID: 2165
		private readonly InputAction m_PositionalKeyboard_Positional_F6;

		// Token: 0x04000876 RID: 2166
		private readonly InputAction m_PositionalKeyboard_Positional_F7;

		// Token: 0x04000877 RID: 2167
		private readonly InputAction m_PositionalKeyboard_Positional_F8;

		// Token: 0x04000878 RID: 2168
		private readonly InputAction m_PositionalKeyboard_Positional_F9;

		// Token: 0x04000879 RID: 2169
		private readonly InputAction m_PositionalKeyboard_Positional_F10;

		// Token: 0x0400087A RID: 2170
		private readonly InputAction m_PositionalKeyboard_Positional_F11;

		// Token: 0x0400087B RID: 2171
		private readonly InputAction m_PositionalKeyboard_Positional_F12;

		// Token: 0x0400087C RID: 2172
		private readonly InputAction m_PositionalKeyboard_Positional_OEM1;

		// Token: 0x0400087D RID: 2173
		private readonly InputAction m_PositionalKeyboard_Positional_OEM2;

		// Token: 0x0400087E RID: 2174
		private readonly InputAction m_PositionalKeyboard_Positional_OEM3;

		// Token: 0x0400087F RID: 2175
		private readonly InputAction m_PositionalKeyboard_Positional_OEM4;

		// Token: 0x04000880 RID: 2176
		private readonly InputAction m_PositionalKeyboard_Positional_OEM5;

		// Token: 0x04000881 RID: 2177
		private readonly InputActionMap m_Joystick;

		// Token: 0x04000882 RID: 2178
		private List<InputActions.IJoystickActions> m_JoystickActionsCallbackInterfaces;

		// Token: 0x04000883 RID: 2179
		private readonly InputAction m_Joystick_Stick;

		// Token: 0x04000884 RID: 2180
		private readonly InputAction m_Joystick_Trigger;

		// Token: 0x04000885 RID: 2181
		private readonly InputActionMap m_Trackers;

		// Token: 0x04000886 RID: 2182
		private List<InputActions.ITrackersActions> m_TrackersActionsCallbackInterfaces;

		// Token: 0x04000887 RID: 2183
		private readonly InputAction m_Trackers_LeftFoot;

		// Token: 0x04000888 RID: 2184
		private readonly InputAction m_Trackers_LeftFootTrackingState;

		// Token: 0x04000889 RID: 2185
		private readonly InputAction m_Trackers_RightFoot;

		// Token: 0x0400088A RID: 2186
		private readonly InputAction m_Trackers_RightFootTrackingState;

		// Token: 0x0400088B RID: 2187
		private readonly InputAction m_Trackers_LeftShoulder;

		// Token: 0x0400088C RID: 2188
		private readonly InputAction m_Trackers_LeftShoulderTrackingState;

		// Token: 0x0400088D RID: 2189
		private readonly InputAction m_Trackers_RightShoulder;

		// Token: 0x0400088E RID: 2190
		private readonly InputAction m_Trackers_RightShoulderTrackingState;

		// Token: 0x0400088F RID: 2191
		private readonly InputAction m_Trackers_LeftElbow;

		// Token: 0x04000890 RID: 2192
		private readonly InputAction m_Trackers_LeftElbowTrackingState;

		// Token: 0x04000891 RID: 2193
		private readonly InputAction m_Trackers_RightElbow;

		// Token: 0x04000892 RID: 2194
		private readonly InputAction m_Trackers_RightElbowTrackingState;

		// Token: 0x04000893 RID: 2195
		private readonly InputAction m_Trackers_LeftKnee;

		// Token: 0x04000894 RID: 2196
		private readonly InputAction m_Trackers_LeftKneeTrackingState;

		// Token: 0x04000895 RID: 2197
		private readonly InputAction m_Trackers_RightKnee;

		// Token: 0x04000896 RID: 2198
		private readonly InputAction m_Trackers_RightKneeTrackingState;

		// Token: 0x04000897 RID: 2199
		private readonly InputAction m_Trackers_Waist;

		// Token: 0x04000898 RID: 2200
		private readonly InputAction m_Trackers_WaistTrackingState;

		// Token: 0x04000899 RID: 2201
		private readonly InputAction m_Trackers_Chest;

		// Token: 0x0400089A RID: 2202
		private readonly InputAction m_Trackers_ChestTrackingState;

		// Token: 0x0400089B RID: 2203
		private int m_XRUsageSchemeIndex;

		// Token: 0x0400089C RID: 2204
		private int m_GamepadSchemeIndex;

		// Token: 0x0400089D RID: 2205
		private int m_PositionalKeyboardMouseSchemeIndex;

		// Token: 0x02000277 RID: 631
		public struct HMDActions
		{

			// Token: 0x17000331 RID: 817
			// (get) Token: 0x060011B6 RID: 4534 RVA: 0x000058BE File Offset: 0x00003ABE
			public InputAction TrackingState
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000332 RID: 818
			// (get) Token: 0x060011B7 RID: 4535 RVA: 0x000058C1 File Offset: 0x00003AC1
			public InputAction Position
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000333 RID: 819
			// (get) Token: 0x060011B8 RID: 4536 RVA: 0x000058C4 File Offset: 0x00003AC4
			public InputAction Rotation
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000334 RID: 820
			// (get) Token: 0x060011B9 RID: 4537 RVA: 0x000058C7 File Offset: 0x00003AC7
			public InputAction Velocity
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000335 RID: 821
			// (get) Token: 0x060011BA RID: 4538 RVA: 0x000058CA File Offset: 0x00003ACA
			public InputAction AngularVelocity
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000336 RID: 822
			// (get) Token: 0x060011BB RID: 4539 RVA: 0x000058CD File Offset: 0x00003ACD
			public InputAction IsTracked
			{
				get
				{
					return null;
				}
			}

			// Token: 0x060011BC RID: 4540 RVA: 0x000058D0 File Offset: 0x00003AD0
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x060011BD RID: 4541 RVA: 0x000058D3 File Offset: 0x00003AD3
			public void Enable()
			{
			}

			// Token: 0x060011BE RID: 4542 RVA: 0x000058D5 File Offset: 0x00003AD5
			public void Disable()
			{
			}

			// Token: 0x17000337 RID: 823
			// (get) Token: 0x060011BF RID: 4543 RVA: 0x000058D7 File Offset: 0x00003AD7
			public bool enabled
			{
				get
				{
					return false;
				}
			}

			// Token: 0x060011C0 RID: 4544 RVA: 0x000058DA File Offset: 0x00003ADA
			public static implicit operator InputActionMap(InputActions.HMDActions set)
			{
				return null;
			}

			// Token: 0x060011C1 RID: 4545 RVA: 0x000058DD File Offset: 0x00003ADD
			public void AddCallbacks(InputActions.IHMDActions instance)
			{
			}

			// Token: 0x060011C2 RID: 4546 RVA: 0x000058DF File Offset: 0x00003ADF
			private void UnregisterCallbacks(InputActions.IHMDActions instance)
			{
			}

			// Token: 0x060011C3 RID: 4547 RVA: 0x000058E1 File Offset: 0x00003AE1
			public void RemoveCallbacks(InputActions.IHMDActions instance)
			{
			}

			// Token: 0x060011C4 RID: 4548 RVA: 0x000058E3 File Offset: 0x00003AE3
			public void SetCallbacks(InputActions.IHMDActions instance)
			{
			}

			// Token: 0x04000FDA RID: 4058
			private InputActions m_Wrapper;
		}

		// Token: 0x02000278 RID: 632
		public struct ControllerLActions
		{

			// Token: 0x17000338 RID: 824
			// (get) Token: 0x060011C6 RID: 4550 RVA: 0x000058E7 File Offset: 0x00003AE7
			public InputAction TrackingState
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000339 RID: 825
			// (get) Token: 0x060011C7 RID: 4551 RVA: 0x000058EA File Offset: 0x00003AEA
			public InputAction PalmPose
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700033A RID: 826
			// (get) Token: 0x060011C8 RID: 4552 RVA: 0x000058ED File Offset: 0x00003AED
			public InputAction PointerPose
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700033B RID: 827
			// (get) Token: 0x060011C9 RID: 4553 RVA: 0x000058F0 File Offset: 0x00003AF0
			public InputAction Velocity
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700033C RID: 828
			// (get) Token: 0x060011CA RID: 4554 RVA: 0x000058F3 File Offset: 0x00003AF3
			public InputAction AngularVelocity
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700033D RID: 829
			// (get) Token: 0x060011CB RID: 4555 RVA: 0x000058F6 File Offset: 0x00003AF6
			public InputAction Primary2DAxis
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700033E RID: 830
			// (get) Token: 0x060011CC RID: 4556 RVA: 0x000058F9 File Offset: 0x00003AF9
			public InputAction Primary2DAxisClick
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700033F RID: 831
			// (get) Token: 0x060011CD RID: 4557 RVA: 0x000058FC File Offset: 0x00003AFC
			public InputAction Primary2DAxisTouch
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000340 RID: 832
			// (get) Token: 0x060011CE RID: 4558 RVA: 0x000058FF File Offset: 0x00003AFF
			public InputAction Touchpad
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000341 RID: 833
			// (get) Token: 0x060011CF RID: 4559 RVA: 0x00005902 File Offset: 0x00003B02
			public InputAction TouchpadClick
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000342 RID: 834
			// (get) Token: 0x060011D0 RID: 4560 RVA: 0x00005905 File Offset: 0x00003B05
			public InputAction TouchpadTouch
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000343 RID: 835
			// (get) Token: 0x060011D1 RID: 4561 RVA: 0x00005908 File Offset: 0x00003B08
			public InputAction Trigger
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000344 RID: 836
			// (get) Token: 0x060011D2 RID: 4562 RVA: 0x0000590B File Offset: 0x00003B0B
			public InputAction TriggerPress
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000345 RID: 837
			// (get) Token: 0x060011D3 RID: 4563 RVA: 0x0000590E File Offset: 0x00003B0E
			public InputAction TriggerTouch
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000346 RID: 838
			// (get) Token: 0x060011D4 RID: 4564 RVA: 0x00005911 File Offset: 0x00003B11
			public InputAction Grip
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000347 RID: 839
			// (get) Token: 0x060011D5 RID: 4565 RVA: 0x00005914 File Offset: 0x00003B14
			public InputAction GripPress
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000348 RID: 840
			// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00005917 File Offset: 0x00003B17
			public InputAction GripForce
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000349 RID: 841
			// (get) Token: 0x060011D7 RID: 4567 RVA: 0x0000591A File Offset: 0x00003B1A
			public InputAction PrimaryButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700034A RID: 842
			// (get) Token: 0x060011D8 RID: 4568 RVA: 0x0000591D File Offset: 0x00003B1D
			public InputAction PrimaryTouch
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700034B RID: 843
			// (get) Token: 0x060011D9 RID: 4569 RVA: 0x00005920 File Offset: 0x00003B20
			public InputAction SecondaryButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700034C RID: 844
			// (get) Token: 0x060011DA RID: 4570 RVA: 0x00005923 File Offset: 0x00003B23
			public InputAction SecondaryTouch
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700034D RID: 845
			// (get) Token: 0x060011DB RID: 4571 RVA: 0x00005926 File Offset: 0x00003B26
			public InputAction MenuButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700034E RID: 846
			// (get) Token: 0x060011DC RID: 4572 RVA: 0x00005929 File Offset: 0x00003B29
			public InputAction Haptic
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700034F RID: 847
			// (get) Token: 0x060011DD RID: 4573 RVA: 0x0000592C File Offset: 0x00003B2C
			public InputAction IsTracked
			{
				get
				{
					return null;
				}
			}

			// Token: 0x060011DE RID: 4574 RVA: 0x0000592F File Offset: 0x00003B2F
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x060011DF RID: 4575 RVA: 0x00005932 File Offset: 0x00003B32
			public void Enable()
			{
			}

			// Token: 0x060011E0 RID: 4576 RVA: 0x00005934 File Offset: 0x00003B34
			public void Disable()
			{
			}

			// Token: 0x17000350 RID: 848
			// (get) Token: 0x060011E1 RID: 4577 RVA: 0x00005936 File Offset: 0x00003B36
			public bool enabled
			{
				get
				{
					return false;
				}
			}

			// Token: 0x060011E2 RID: 4578 RVA: 0x00005939 File Offset: 0x00003B39
			public static implicit operator InputActionMap(InputActions.ControllerLActions set)
			{
				return null;
			}

			// Token: 0x060011E3 RID: 4579 RVA: 0x0000593C File Offset: 0x00003B3C
			public void AddCallbacks(InputActions.IControllerLActions instance)
			{
			}

			// Token: 0x060011E4 RID: 4580 RVA: 0x0000593E File Offset: 0x00003B3E
			private void UnregisterCallbacks(InputActions.IControllerLActions instance)
			{
			}

			// Token: 0x060011E5 RID: 4581 RVA: 0x00005940 File Offset: 0x00003B40
			public void RemoveCallbacks(InputActions.IControllerLActions instance)
			{
			}

			// Token: 0x060011E6 RID: 4582 RVA: 0x00005942 File Offset: 0x00003B42
			public void SetCallbacks(InputActions.IControllerLActions instance)
			{
			}

			// Token: 0x04000FDB RID: 4059
			private InputActions m_Wrapper;
		}

		// Token: 0x02000279 RID: 633
		public struct ControllerRActions
		{

			// Token: 0x17000351 RID: 849
			// (get) Token: 0x060011E8 RID: 4584 RVA: 0x00005946 File Offset: 0x00003B46
			public InputAction TrackingState
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000352 RID: 850
			// (get) Token: 0x060011E9 RID: 4585 RVA: 0x00005949 File Offset: 0x00003B49
			public InputAction PalmPose
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000353 RID: 851
			// (get) Token: 0x060011EA RID: 4586 RVA: 0x0000594C File Offset: 0x00003B4C
			public InputAction PointerPose
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000354 RID: 852
			// (get) Token: 0x060011EB RID: 4587 RVA: 0x0000594F File Offset: 0x00003B4F
			public InputAction Velocity
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000355 RID: 853
			// (get) Token: 0x060011EC RID: 4588 RVA: 0x00005952 File Offset: 0x00003B52
			public InputAction AngularVelocity
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000356 RID: 854
			// (get) Token: 0x060011ED RID: 4589 RVA: 0x00005955 File Offset: 0x00003B55
			public InputAction Primary2DAxis
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000357 RID: 855
			// (get) Token: 0x060011EE RID: 4590 RVA: 0x00005958 File Offset: 0x00003B58
			public InputAction Primary2DAxisClick
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000358 RID: 856
			// (get) Token: 0x060011EF RID: 4591 RVA: 0x0000595B File Offset: 0x00003B5B
			public InputAction Primary2DAxisTouch
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000359 RID: 857
			// (get) Token: 0x060011F0 RID: 4592 RVA: 0x0000595E File Offset: 0x00003B5E
			public InputAction Touchpad
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700035A RID: 858
			// (get) Token: 0x060011F1 RID: 4593 RVA: 0x00005961 File Offset: 0x00003B61
			public InputAction TouchpadClick
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700035B RID: 859
			// (get) Token: 0x060011F2 RID: 4594 RVA: 0x00005964 File Offset: 0x00003B64
			public InputAction TouchpadTouch
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700035C RID: 860
			// (get) Token: 0x060011F3 RID: 4595 RVA: 0x00005967 File Offset: 0x00003B67
			public InputAction Trigger
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700035D RID: 861
			// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0000596A File Offset: 0x00003B6A
			public InputAction TriggerPress
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700035E RID: 862
			// (get) Token: 0x060011F5 RID: 4597 RVA: 0x0000596D File Offset: 0x00003B6D
			public InputAction TriggerTouch
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700035F RID: 863
			// (get) Token: 0x060011F6 RID: 4598 RVA: 0x00005970 File Offset: 0x00003B70
			public InputAction Grip
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000360 RID: 864
			// (get) Token: 0x060011F7 RID: 4599 RVA: 0x00005973 File Offset: 0x00003B73
			public InputAction GripPress
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000361 RID: 865
			// (get) Token: 0x060011F8 RID: 4600 RVA: 0x00005976 File Offset: 0x00003B76
			public InputAction GripForce
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000362 RID: 866
			// (get) Token: 0x060011F9 RID: 4601 RVA: 0x00005979 File Offset: 0x00003B79
			public InputAction PrimaryButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000363 RID: 867
			// (get) Token: 0x060011FA RID: 4602 RVA: 0x0000597C File Offset: 0x00003B7C
			public InputAction PrimaryTouch
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000364 RID: 868
			// (get) Token: 0x060011FB RID: 4603 RVA: 0x0000597F File Offset: 0x00003B7F
			public InputAction SecondaryButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000365 RID: 869
			// (get) Token: 0x060011FC RID: 4604 RVA: 0x00005982 File Offset: 0x00003B82
			public InputAction SecondaryTouch
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000366 RID: 870
			// (get) Token: 0x060011FD RID: 4605 RVA: 0x00005985 File Offset: 0x00003B85
			public InputAction Haptic
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000367 RID: 871
			// (get) Token: 0x060011FE RID: 4606 RVA: 0x00005988 File Offset: 0x00003B88
			public InputAction IsTracked
			{
				get
				{
					return null;
				}
			}

			// Token: 0x060011FF RID: 4607 RVA: 0x0000598B File Offset: 0x00003B8B
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x06001200 RID: 4608 RVA: 0x0000598E File Offset: 0x00003B8E
			public void Enable()
			{
			}

			// Token: 0x06001201 RID: 4609 RVA: 0x00005990 File Offset: 0x00003B90
			public void Disable()
			{
			}

			// Token: 0x17000368 RID: 872
			// (get) Token: 0x06001202 RID: 4610 RVA: 0x00005992 File Offset: 0x00003B92
			public bool enabled
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06001203 RID: 4611 RVA: 0x00005995 File Offset: 0x00003B95
			public static implicit operator InputActionMap(InputActions.ControllerRActions set)
			{
				return null;
			}

			// Token: 0x06001204 RID: 4612 RVA: 0x00005998 File Offset: 0x00003B98
			public void AddCallbacks(InputActions.IControllerRActions instance)
			{
			}

			// Token: 0x06001205 RID: 4613 RVA: 0x0000599A File Offset: 0x00003B9A
			private void UnregisterCallbacks(InputActions.IControllerRActions instance)
			{
			}

			// Token: 0x06001206 RID: 4614 RVA: 0x0000599C File Offset: 0x00003B9C
			public void RemoveCallbacks(InputActions.IControllerRActions instance)
			{
			}

			// Token: 0x06001207 RID: 4615 RVA: 0x0000599E File Offset: 0x00003B9E
			public void SetCallbacks(InputActions.IControllerRActions instance)
			{
			}

			// Token: 0x04000FDC RID: 4060
			private InputActions m_Wrapper;
		}

		// Token: 0x0200027A RID: 634
		public struct GamepadActions
		{

			// Token: 0x17000369 RID: 873
			// (get) Token: 0x06001209 RID: 4617 RVA: 0x000059A2 File Offset: 0x00003BA2
			public InputAction LeftJoystick2DAxis
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700036A RID: 874
			// (get) Token: 0x0600120A RID: 4618 RVA: 0x000059A5 File Offset: 0x00003BA5
			public InputAction LeftTrigger1DAxis
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700036B RID: 875
			// (get) Token: 0x0600120B RID: 4619 RVA: 0x000059A8 File Offset: 0x00003BA8
			public InputAction LeftJoystickButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700036C RID: 876
			// (get) Token: 0x0600120C RID: 4620 RVA: 0x000059AB File Offset: 0x00003BAB
			public InputAction LeftShoulderButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700036D RID: 877
			// (get) Token: 0x0600120D RID: 4621 RVA: 0x000059AE File Offset: 0x00003BAE
			public InputAction LeftNorthButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700036E RID: 878
			// (get) Token: 0x0600120E RID: 4622 RVA: 0x000059B1 File Offset: 0x00003BB1
			public InputAction LeftEastButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700036F RID: 879
			// (get) Token: 0x0600120F RID: 4623 RVA: 0x000059B4 File Offset: 0x00003BB4
			public InputAction LeftSouthButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000370 RID: 880
			// (get) Token: 0x06001210 RID: 4624 RVA: 0x000059B7 File Offset: 0x00003BB7
			public InputAction LeftWestButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000371 RID: 881
			// (get) Token: 0x06001211 RID: 4625 RVA: 0x000059BA File Offset: 0x00003BBA
			public InputAction SelectButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000372 RID: 882
			// (get) Token: 0x06001212 RID: 4626 RVA: 0x000059BD File Offset: 0x00003BBD
			public InputAction RightJoystick2DAxis
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000373 RID: 883
			// (get) Token: 0x06001213 RID: 4627 RVA: 0x000059C0 File Offset: 0x00003BC0
			public InputAction RightTrigger1DAxis
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000374 RID: 884
			// (get) Token: 0x06001214 RID: 4628 RVA: 0x000059C3 File Offset: 0x00003BC3
			public InputAction RightJoystickButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000375 RID: 885
			// (get) Token: 0x06001215 RID: 4629 RVA: 0x000059C6 File Offset: 0x00003BC6
			public InputAction RightShoulderButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000376 RID: 886
			// (get) Token: 0x06001216 RID: 4630 RVA: 0x000059C9 File Offset: 0x00003BC9
			public InputAction RightNorthButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000377 RID: 887
			// (get) Token: 0x06001217 RID: 4631 RVA: 0x000059CC File Offset: 0x00003BCC
			public InputAction RightEastButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000378 RID: 888
			// (get) Token: 0x06001218 RID: 4632 RVA: 0x000059CF File Offset: 0x00003BCF
			public InputAction RightSouthButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000379 RID: 889
			// (get) Token: 0x06001219 RID: 4633 RVA: 0x000059D2 File Offset: 0x00003BD2
			public InputAction RightWestButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700037A RID: 890
			// (get) Token: 0x0600121A RID: 4634 RVA: 0x000059D5 File Offset: 0x00003BD5
			public InputAction StartButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x0600121B RID: 4635 RVA: 0x000059D8 File Offset: 0x00003BD8
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x0600121C RID: 4636 RVA: 0x000059DB File Offset: 0x00003BDB
			public void Enable()
			{
			}

			// Token: 0x0600121D RID: 4637 RVA: 0x000059DD File Offset: 0x00003BDD
			public void Disable()
			{
			}

			// Token: 0x1700037B RID: 891
			// (get) Token: 0x0600121E RID: 4638 RVA: 0x000059DF File Offset: 0x00003BDF
			public bool enabled
			{
				get
				{
					return false;
				}
			}

			// Token: 0x0600121F RID: 4639 RVA: 0x000059E2 File Offset: 0x00003BE2
			public static implicit operator InputActionMap(InputActions.GamepadActions set)
			{
				return null;
			}

			// Token: 0x06001220 RID: 4640 RVA: 0x000059E5 File Offset: 0x00003BE5
			public void AddCallbacks(InputActions.IGamepadActions instance)
			{
			}

			// Token: 0x06001221 RID: 4641 RVA: 0x000059E7 File Offset: 0x00003BE7
			private void UnregisterCallbacks(InputActions.IGamepadActions instance)
			{
			}

			// Token: 0x06001222 RID: 4642 RVA: 0x000059E9 File Offset: 0x00003BE9
			public void RemoveCallbacks(InputActions.IGamepadActions instance)
			{
			}

			// Token: 0x06001223 RID: 4643 RVA: 0x000059EB File Offset: 0x00003BEB
			public void SetCallbacks(InputActions.IGamepadActions instance)
			{
			}

			// Token: 0x04000FDD RID: 4061
			private InputActions m_Wrapper;
		}

		// Token: 0x0200027B RID: 635
		public struct MouseActions
		{

			// Token: 0x1700037C RID: 892
			// (get) Token: 0x06001225 RID: 4645 RVA: 0x000059EF File Offset: 0x00003BEF
			public InputAction Mouse_ForwardButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700037D RID: 893
			// (get) Token: 0x06001226 RID: 4646 RVA: 0x000059F2 File Offset: 0x00003BF2
			public InputAction Mouse_BackButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700037E RID: 894
			// (get) Token: 0x06001227 RID: 4647 RVA: 0x000059F5 File Offset: 0x00003BF5
			public InputAction Mouse_RButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700037F RID: 895
			// (get) Token: 0x06001228 RID: 4648 RVA: 0x000059F8 File Offset: 0x00003BF8
			public InputAction Mouse_MButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000380 RID: 896
			// (get) Token: 0x06001229 RID: 4649 RVA: 0x000059FB File Offset: 0x00003BFB
			public InputAction Mouse_LButton
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000381 RID: 897
			// (get) Token: 0x0600122A RID: 4650 RVA: 0x000059FE File Offset: 0x00003BFE
			public InputAction Mouse_Delta
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000382 RID: 898
			// (get) Token: 0x0600122B RID: 4651 RVA: 0x00005A01 File Offset: 0x00003C01
			public InputAction Mouse_Scroll
			{
				get
				{
					return null;
				}
			}

			// Token: 0x0600122C RID: 4652 RVA: 0x00005A04 File Offset: 0x00003C04
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x0600122D RID: 4653 RVA: 0x00005A07 File Offset: 0x00003C07
			public void Enable()
			{
			}

			// Token: 0x0600122E RID: 4654 RVA: 0x00005A09 File Offset: 0x00003C09
			public void Disable()
			{
			}

			// Token: 0x17000383 RID: 899
			// (get) Token: 0x0600122F RID: 4655 RVA: 0x00005A0B File Offset: 0x00003C0B
			public bool enabled
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06001230 RID: 4656 RVA: 0x00005A0E File Offset: 0x00003C0E
			public static implicit operator InputActionMap(InputActions.MouseActions set)
			{
				return null;
			}

			// Token: 0x06001231 RID: 4657 RVA: 0x00005A11 File Offset: 0x00003C11
			public void AddCallbacks(InputActions.IMouseActions instance)
			{
			}

			// Token: 0x06001232 RID: 4658 RVA: 0x00005A13 File Offset: 0x00003C13
			private void UnregisterCallbacks(InputActions.IMouseActions instance)
			{
			}

			// Token: 0x06001233 RID: 4659 RVA: 0x00005A15 File Offset: 0x00003C15
			public void RemoveCallbacks(InputActions.IMouseActions instance)
			{
			}

			// Token: 0x06001234 RID: 4660 RVA: 0x00005A17 File Offset: 0x00003C17
			public void SetCallbacks(InputActions.IMouseActions instance)
			{
			}

			// Token: 0x04000FDE RID: 4062
			private InputActions m_Wrapper;
		}

		// Token: 0x0200027C RID: 636
		public struct PositionalKeyboardActions
		{

			// Token: 0x17000384 RID: 900
			// (get) Token: 0x06001236 RID: 4662 RVA: 0x00005A1B File Offset: 0x00003C1B
			public InputAction Positional_Escape
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000385 RID: 901
			// (get) Token: 0x06001237 RID: 4663 RVA: 0x00005A1E File Offset: 0x00003C1E
			public InputAction Positional_Space
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000386 RID: 902
			// (get) Token: 0x06001238 RID: 4664 RVA: 0x00005A21 File Offset: 0x00003C21
			public InputAction Positional_Enter
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000387 RID: 903
			// (get) Token: 0x06001239 RID: 4665 RVA: 0x00005A24 File Offset: 0x00003C24
			public InputAction Positional_Tab
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000388 RID: 904
			// (get) Token: 0x0600123A RID: 4666 RVA: 0x00005A27 File Offset: 0x00003C27
			public InputAction Positional_Backquote
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000389 RID: 905
			// (get) Token: 0x0600123B RID: 4667 RVA: 0x00005A2A File Offset: 0x00003C2A
			public InputAction Positional_Quote
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700038A RID: 906
			// (get) Token: 0x0600123C RID: 4668 RVA: 0x00005A2D File Offset: 0x00003C2D
			public InputAction Positional_Semicolon
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700038B RID: 907
			// (get) Token: 0x0600123D RID: 4669 RVA: 0x00005A30 File Offset: 0x00003C30
			public InputAction Positional_Comma
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700038C RID: 908
			// (get) Token: 0x0600123E RID: 4670 RVA: 0x00005A33 File Offset: 0x00003C33
			public InputAction Positional_Period
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700038D RID: 909
			// (get) Token: 0x0600123F RID: 4671 RVA: 0x00005A36 File Offset: 0x00003C36
			public InputAction Positional_Slash
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700038E RID: 910
			// (get) Token: 0x06001240 RID: 4672 RVA: 0x00005A39 File Offset: 0x00003C39
			public InputAction Positional_Backslash
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700038F RID: 911
			// (get) Token: 0x06001241 RID: 4673 RVA: 0x00005A3C File Offset: 0x00003C3C
			public InputAction Positional_LeftBracket
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000390 RID: 912
			// (get) Token: 0x06001242 RID: 4674 RVA: 0x00005A3F File Offset: 0x00003C3F
			public InputAction Positional_RightBracket
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000391 RID: 913
			// (get) Token: 0x06001243 RID: 4675 RVA: 0x00005A42 File Offset: 0x00003C42
			public InputAction Positional_Minus
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000392 RID: 914
			// (get) Token: 0x06001244 RID: 4676 RVA: 0x00005A45 File Offset: 0x00003C45
			public InputAction Positional_Equals
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000393 RID: 915
			// (get) Token: 0x06001245 RID: 4677 RVA: 0x00005A48 File Offset: 0x00003C48
			public InputAction Positional_UpArrow
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000394 RID: 916
			// (get) Token: 0x06001246 RID: 4678 RVA: 0x00005A4B File Offset: 0x00003C4B
			public InputAction Positional_DownArrow
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000395 RID: 917
			// (get) Token: 0x06001247 RID: 4679 RVA: 0x00005A4E File Offset: 0x00003C4E
			public InputAction Positional_LeftArrow
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000396 RID: 918
			// (get) Token: 0x06001248 RID: 4680 RVA: 0x00005A51 File Offset: 0x00003C51
			public InputAction Positional_RightArrow
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000397 RID: 919
			// (get) Token: 0x06001249 RID: 4681 RVA: 0x00005A54 File Offset: 0x00003C54
			public InputAction Positional_A
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000398 RID: 920
			// (get) Token: 0x0600124A RID: 4682 RVA: 0x00005A57 File Offset: 0x00003C57
			public InputAction Positional_B
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000399 RID: 921
			// (get) Token: 0x0600124B RID: 4683 RVA: 0x00005A5A File Offset: 0x00003C5A
			public InputAction Positional_C
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700039A RID: 922
			// (get) Token: 0x0600124C RID: 4684 RVA: 0x00005A5D File Offset: 0x00003C5D
			public InputAction Positional_D
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700039B RID: 923
			// (get) Token: 0x0600124D RID: 4685 RVA: 0x00005A60 File Offset: 0x00003C60
			public InputAction Positional_E
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700039C RID: 924
			// (get) Token: 0x0600124E RID: 4686 RVA: 0x00005A63 File Offset: 0x00003C63
			public InputAction Positional_F
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700039D RID: 925
			// (get) Token: 0x0600124F RID: 4687 RVA: 0x00005A66 File Offset: 0x00003C66
			public InputAction Positional_G
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700039E RID: 926
			// (get) Token: 0x06001250 RID: 4688 RVA: 0x00005A69 File Offset: 0x00003C69
			public InputAction Positional_H
			{
				get
				{
					return null;
				}
			}

			// Token: 0x1700039F RID: 927
			// (get) Token: 0x06001251 RID: 4689 RVA: 0x00005A6C File Offset: 0x00003C6C
			public InputAction Positional_I
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003A0 RID: 928
			// (get) Token: 0x06001252 RID: 4690 RVA: 0x00005A6F File Offset: 0x00003C6F
			public InputAction Positional_J
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003A1 RID: 929
			// (get) Token: 0x06001253 RID: 4691 RVA: 0x00005A72 File Offset: 0x00003C72
			public InputAction Positional_K
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003A2 RID: 930
			// (get) Token: 0x06001254 RID: 4692 RVA: 0x00005A75 File Offset: 0x00003C75
			public InputAction Positional_L
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003A3 RID: 931
			// (get) Token: 0x06001255 RID: 4693 RVA: 0x00005A78 File Offset: 0x00003C78
			public InputAction Positional_M
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003A4 RID: 932
			// (get) Token: 0x06001256 RID: 4694 RVA: 0x00005A7B File Offset: 0x00003C7B
			public InputAction Positional_N
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003A5 RID: 933
			// (get) Token: 0x06001257 RID: 4695 RVA: 0x00005A7E File Offset: 0x00003C7E
			public InputAction Positional_O
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003A6 RID: 934
			// (get) Token: 0x06001258 RID: 4696 RVA: 0x00005A81 File Offset: 0x00003C81
			public InputAction Positional_P
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003A7 RID: 935
			// (get) Token: 0x06001259 RID: 4697 RVA: 0x00005A84 File Offset: 0x00003C84
			public InputAction Positional_Q
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003A8 RID: 936
			// (get) Token: 0x0600125A RID: 4698 RVA: 0x00005A87 File Offset: 0x00003C87
			public InputAction Positional_R
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003A9 RID: 937
			// (get) Token: 0x0600125B RID: 4699 RVA: 0x00005A8A File Offset: 0x00003C8A
			public InputAction Positional_S
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003AA RID: 938
			// (get) Token: 0x0600125C RID: 4700 RVA: 0x00005A8D File Offset: 0x00003C8D
			public InputAction Positional_T
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003AB RID: 939
			// (get) Token: 0x0600125D RID: 4701 RVA: 0x00005A90 File Offset: 0x00003C90
			public InputAction Positional_U
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003AC RID: 940
			// (get) Token: 0x0600125E RID: 4702 RVA: 0x00005A93 File Offset: 0x00003C93
			public InputAction Positional_V
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003AD RID: 941
			// (get) Token: 0x0600125F RID: 4703 RVA: 0x00005A96 File Offset: 0x00003C96
			public InputAction Positional_W
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003AE RID: 942
			// (get) Token: 0x06001260 RID: 4704 RVA: 0x00005A99 File Offset: 0x00003C99
			public InputAction Positional_X
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003AF RID: 943
			// (get) Token: 0x06001261 RID: 4705 RVA: 0x00005A9C File Offset: 0x00003C9C
			public InputAction Positional_Y
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003B0 RID: 944
			// (get) Token: 0x06001262 RID: 4706 RVA: 0x00005A9F File Offset: 0x00003C9F
			public InputAction Positional_Z
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003B1 RID: 945
			// (get) Token: 0x06001263 RID: 4707 RVA: 0x00005AA2 File Offset: 0x00003CA2
			public InputAction Positional_1
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003B2 RID: 946
			// (get) Token: 0x06001264 RID: 4708 RVA: 0x00005AA5 File Offset: 0x00003CA5
			public InputAction Positional_2
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003B3 RID: 947
			// (get) Token: 0x06001265 RID: 4709 RVA: 0x00005AA8 File Offset: 0x00003CA8
			public InputAction Positional_3
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003B4 RID: 948
			// (get) Token: 0x06001266 RID: 4710 RVA: 0x00005AAB File Offset: 0x00003CAB
			public InputAction Positional_4
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003B5 RID: 949
			// (get) Token: 0x06001267 RID: 4711 RVA: 0x00005AAE File Offset: 0x00003CAE
			public InputAction Positional_5
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003B6 RID: 950
			// (get) Token: 0x06001268 RID: 4712 RVA: 0x00005AB1 File Offset: 0x00003CB1
			public InputAction Positional_6
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003B7 RID: 951
			// (get) Token: 0x06001269 RID: 4713 RVA: 0x00005AB4 File Offset: 0x00003CB4
			public InputAction Positional_7
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003B8 RID: 952
			// (get) Token: 0x0600126A RID: 4714 RVA: 0x00005AB7 File Offset: 0x00003CB7
			public InputAction Positional_8
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003B9 RID: 953
			// (get) Token: 0x0600126B RID: 4715 RVA: 0x00005ABA File Offset: 0x00003CBA
			public InputAction Positional_9
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003BA RID: 954
			// (get) Token: 0x0600126C RID: 4716 RVA: 0x00005ABD File Offset: 0x00003CBD
			public InputAction Positional_0
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003BB RID: 955
			// (get) Token: 0x0600126D RID: 4717 RVA: 0x00005AC0 File Offset: 0x00003CC0
			public InputAction Positional_LeftShift
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003BC RID: 956
			// (get) Token: 0x0600126E RID: 4718 RVA: 0x00005AC3 File Offset: 0x00003CC3
			public InputAction Positional_RightShift
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003BD RID: 957
			// (get) Token: 0x0600126F RID: 4719 RVA: 0x00005AC6 File Offset: 0x00003CC6
			public InputAction Positional_LeftAlt
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003BE RID: 958
			// (get) Token: 0x06001270 RID: 4720 RVA: 0x00005AC9 File Offset: 0x00003CC9
			public InputAction Positional_RightAlt
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003BF RID: 959
			// (get) Token: 0x06001271 RID: 4721 RVA: 0x00005ACC File Offset: 0x00003CCC
			public InputAction Positional_LeftCtrl
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003C0 RID: 960
			// (get) Token: 0x06001272 RID: 4722 RVA: 0x00005ACF File Offset: 0x00003CCF
			public InputAction Positional_RightCtrl
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003C1 RID: 961
			// (get) Token: 0x06001273 RID: 4723 RVA: 0x00005AD2 File Offset: 0x00003CD2
			public InputAction Positional_LeftMeta
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003C2 RID: 962
			// (get) Token: 0x06001274 RID: 4724 RVA: 0x00005AD5 File Offset: 0x00003CD5
			public InputAction Positional_RightMeta
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003C3 RID: 963
			// (get) Token: 0x06001275 RID: 4725 RVA: 0x00005AD8 File Offset: 0x00003CD8
			public InputAction Positional_ContextMenu
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003C4 RID: 964
			// (get) Token: 0x06001276 RID: 4726 RVA: 0x00005ADB File Offset: 0x00003CDB
			public InputAction Positional_Backspace
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003C5 RID: 965
			// (get) Token: 0x06001277 RID: 4727 RVA: 0x00005ADE File Offset: 0x00003CDE
			public InputAction Positional_PageDown
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003C6 RID: 966
			// (get) Token: 0x06001278 RID: 4728 RVA: 0x00005AE1 File Offset: 0x00003CE1
			public InputAction Positional_PageUp
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003C7 RID: 967
			// (get) Token: 0x06001279 RID: 4729 RVA: 0x00005AE4 File Offset: 0x00003CE4
			public InputAction Positional_Home
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003C8 RID: 968
			// (get) Token: 0x0600127A RID: 4730 RVA: 0x00005AE7 File Offset: 0x00003CE7
			public InputAction Positional_End
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003C9 RID: 969
			// (get) Token: 0x0600127B RID: 4731 RVA: 0x00005AEA File Offset: 0x00003CEA
			public InputAction Positional_Insert
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003CA RID: 970
			// (get) Token: 0x0600127C RID: 4732 RVA: 0x00005AED File Offset: 0x00003CED
			public InputAction Positional_Delete
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003CB RID: 971
			// (get) Token: 0x0600127D RID: 4733 RVA: 0x00005AF0 File Offset: 0x00003CF0
			public InputAction Positional_CapsLock
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003CC RID: 972
			// (get) Token: 0x0600127E RID: 4734 RVA: 0x00005AF3 File Offset: 0x00003CF3
			public InputAction Positional_NumLock
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003CD RID: 973
			// (get) Token: 0x0600127F RID: 4735 RVA: 0x00005AF6 File Offset: 0x00003CF6
			public InputAction Positional_PrintScreen
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003CE RID: 974
			// (get) Token: 0x06001280 RID: 4736 RVA: 0x00005AF9 File Offset: 0x00003CF9
			public InputAction Positional_ScrollLock
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003CF RID: 975
			// (get) Token: 0x06001281 RID: 4737 RVA: 0x00005AFC File Offset: 0x00003CFC
			public InputAction Positional_Pause
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003D0 RID: 976
			// (get) Token: 0x06001282 RID: 4738 RVA: 0x00005AFF File Offset: 0x00003CFF
			public InputAction Positional_NumpadEnter
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003D1 RID: 977
			// (get) Token: 0x06001283 RID: 4739 RVA: 0x00005B02 File Offset: 0x00003D02
			public InputAction Positional_NumpadDivide
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003D2 RID: 978
			// (get) Token: 0x06001284 RID: 4740 RVA: 0x00005B05 File Offset: 0x00003D05
			public InputAction Positional_NumpadMultiply
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003D3 RID: 979
			// (get) Token: 0x06001285 RID: 4741 RVA: 0x00005B08 File Offset: 0x00003D08
			public InputAction Positional_NumpadPlus
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003D4 RID: 980
			// (get) Token: 0x06001286 RID: 4742 RVA: 0x00005B0B File Offset: 0x00003D0B
			public InputAction Positional_NumpadMinus
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003D5 RID: 981
			// (get) Token: 0x06001287 RID: 4743 RVA: 0x00005B0E File Offset: 0x00003D0E
			public InputAction Positional_NumpadPeriod
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003D6 RID: 982
			// (get) Token: 0x06001288 RID: 4744 RVA: 0x00005B11 File Offset: 0x00003D11
			public InputAction Positional_NumpadEquals
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003D7 RID: 983
			// (get) Token: 0x06001289 RID: 4745 RVA: 0x00005B14 File Offset: 0x00003D14
			public InputAction Positional_Numpad1
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003D8 RID: 984
			// (get) Token: 0x0600128A RID: 4746 RVA: 0x00005B17 File Offset: 0x00003D17
			public InputAction Positional_Numpad2
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003D9 RID: 985
			// (get) Token: 0x0600128B RID: 4747 RVA: 0x00005B1A File Offset: 0x00003D1A
			public InputAction Positional_Numpad3
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003DA RID: 986
			// (get) Token: 0x0600128C RID: 4748 RVA: 0x00005B1D File Offset: 0x00003D1D
			public InputAction Positional_Numpad4
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003DB RID: 987
			// (get) Token: 0x0600128D RID: 4749 RVA: 0x00005B20 File Offset: 0x00003D20
			public InputAction Positional_Numpad5
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003DC RID: 988
			// (get) Token: 0x0600128E RID: 4750 RVA: 0x00005B23 File Offset: 0x00003D23
			public InputAction Positional_Numpad6
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003DD RID: 989
			// (get) Token: 0x0600128F RID: 4751 RVA: 0x00005B26 File Offset: 0x00003D26
			public InputAction Positional_Numpad7
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003DE RID: 990
			// (get) Token: 0x06001290 RID: 4752 RVA: 0x00005B29 File Offset: 0x00003D29
			public InputAction Positional_Numpad8
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003DF RID: 991
			// (get) Token: 0x06001291 RID: 4753 RVA: 0x00005B2C File Offset: 0x00003D2C
			public InputAction Positional_Numpad9
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003E0 RID: 992
			// (get) Token: 0x06001292 RID: 4754 RVA: 0x00005B2F File Offset: 0x00003D2F
			public InputAction Positional_Numpad0
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003E1 RID: 993
			// (get) Token: 0x06001293 RID: 4755 RVA: 0x00005B32 File Offset: 0x00003D32
			public InputAction Positional_F1
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003E2 RID: 994
			// (get) Token: 0x06001294 RID: 4756 RVA: 0x00005B35 File Offset: 0x00003D35
			public InputAction Positional_F2
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003E3 RID: 995
			// (get) Token: 0x06001295 RID: 4757 RVA: 0x00005B38 File Offset: 0x00003D38
			public InputAction Positional_F3
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003E4 RID: 996
			// (get) Token: 0x06001296 RID: 4758 RVA: 0x00005B3B File Offset: 0x00003D3B
			public InputAction Positional_F4
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003E5 RID: 997
			// (get) Token: 0x06001297 RID: 4759 RVA: 0x00005B3E File Offset: 0x00003D3E
			public InputAction Positional_F5
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003E6 RID: 998
			// (get) Token: 0x06001298 RID: 4760 RVA: 0x00005B41 File Offset: 0x00003D41
			public InputAction Positional_F6
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003E7 RID: 999
			// (get) Token: 0x06001299 RID: 4761 RVA: 0x00005B44 File Offset: 0x00003D44
			public InputAction Positional_F7
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003E8 RID: 1000
			// (get) Token: 0x0600129A RID: 4762 RVA: 0x00005B47 File Offset: 0x00003D47
			public InputAction Positional_F8
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003E9 RID: 1001
			// (get) Token: 0x0600129B RID: 4763 RVA: 0x00005B4A File Offset: 0x00003D4A
			public InputAction Positional_F9
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003EA RID: 1002
			// (get) Token: 0x0600129C RID: 4764 RVA: 0x00005B4D File Offset: 0x00003D4D
			public InputAction Positional_F10
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003EB RID: 1003
			// (get) Token: 0x0600129D RID: 4765 RVA: 0x00005B50 File Offset: 0x00003D50
			public InputAction Positional_F11
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003EC RID: 1004
			// (get) Token: 0x0600129E RID: 4766 RVA: 0x00005B53 File Offset: 0x00003D53
			public InputAction Positional_F12
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003ED RID: 1005
			// (get) Token: 0x0600129F RID: 4767 RVA: 0x00005B56 File Offset: 0x00003D56
			public InputAction Positional_OEM1
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003EE RID: 1006
			// (get) Token: 0x060012A0 RID: 4768 RVA: 0x00005B59 File Offset: 0x00003D59
			public InputAction Positional_OEM2
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003EF RID: 1007
			// (get) Token: 0x060012A1 RID: 4769 RVA: 0x00005B5C File Offset: 0x00003D5C
			public InputAction Positional_OEM3
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003F0 RID: 1008
			// (get) Token: 0x060012A2 RID: 4770 RVA: 0x00005B5F File Offset: 0x00003D5F
			public InputAction Positional_OEM4
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003F1 RID: 1009
			// (get) Token: 0x060012A3 RID: 4771 RVA: 0x00005B62 File Offset: 0x00003D62
			public InputAction Positional_OEM5
			{
				get
				{
					return null;
				}
			}

			// Token: 0x060012A4 RID: 4772 RVA: 0x00005B65 File Offset: 0x00003D65
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x060012A5 RID: 4773 RVA: 0x00005B68 File Offset: 0x00003D68
			public void Enable()
			{
			}

			// Token: 0x060012A6 RID: 4774 RVA: 0x00005B6A File Offset: 0x00003D6A
			public void Disable()
			{
			}

			// Token: 0x170003F2 RID: 1010
			// (get) Token: 0x060012A7 RID: 4775 RVA: 0x00005B6C File Offset: 0x00003D6C
			public bool enabled
			{
				get
				{
					return false;
				}
			}

			// Token: 0x060012A8 RID: 4776 RVA: 0x00005B6F File Offset: 0x00003D6F
			public static implicit operator InputActionMap(InputActions.PositionalKeyboardActions set)
			{
				return null;
			}

			// Token: 0x060012A9 RID: 4777 RVA: 0x00005B72 File Offset: 0x00003D72
			public void AddCallbacks(InputActions.IPositionalKeyboardActions instance)
			{
			}

			// Token: 0x060012AA RID: 4778 RVA: 0x00005B74 File Offset: 0x00003D74
			private void UnregisterCallbacks(InputActions.IPositionalKeyboardActions instance)
			{
			}

			// Token: 0x060012AB RID: 4779 RVA: 0x00005B76 File Offset: 0x00003D76
			public void RemoveCallbacks(InputActions.IPositionalKeyboardActions instance)
			{
			}

			// Token: 0x060012AC RID: 4780 RVA: 0x00005B78 File Offset: 0x00003D78
			public void SetCallbacks(InputActions.IPositionalKeyboardActions instance)
			{
			}

			// Token: 0x04000FDF RID: 4063
			private InputActions m_Wrapper;
		}

		// Token: 0x0200027D RID: 637
		public struct JoystickActions
		{

			// Token: 0x170003F3 RID: 1011
			// (get) Token: 0x060012AE RID: 4782 RVA: 0x00005B7C File Offset: 0x00003D7C
			public InputAction Stick
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003F4 RID: 1012
			// (get) Token: 0x060012AF RID: 4783 RVA: 0x00005B7F File Offset: 0x00003D7F
			public InputAction Trigger
			{
				get
				{
					return null;
				}
			}

			// Token: 0x060012B0 RID: 4784 RVA: 0x00005B82 File Offset: 0x00003D82
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x060012B1 RID: 4785 RVA: 0x00005B85 File Offset: 0x00003D85
			public void Enable()
			{
			}

			// Token: 0x060012B2 RID: 4786 RVA: 0x00005B87 File Offset: 0x00003D87
			public void Disable()
			{
			}

			// Token: 0x170003F5 RID: 1013
			// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00005B89 File Offset: 0x00003D89
			public bool enabled
			{
				get
				{
					return false;
				}
			}

			// Token: 0x060012B4 RID: 4788 RVA: 0x00005B8C File Offset: 0x00003D8C
			public static implicit operator InputActionMap(InputActions.JoystickActions set)
			{
				return null;
			}

			// Token: 0x060012B5 RID: 4789 RVA: 0x00005B8F File Offset: 0x00003D8F
			public void AddCallbacks(InputActions.IJoystickActions instance)
			{
			}

			// Token: 0x060012B6 RID: 4790 RVA: 0x00005B91 File Offset: 0x00003D91
			private void UnregisterCallbacks(InputActions.IJoystickActions instance)
			{
			}

			// Token: 0x060012B7 RID: 4791 RVA: 0x00005B93 File Offset: 0x00003D93
			public void RemoveCallbacks(InputActions.IJoystickActions instance)
			{
			}

			// Token: 0x060012B8 RID: 4792 RVA: 0x00005B95 File Offset: 0x00003D95
			public void SetCallbacks(InputActions.IJoystickActions instance)
			{
			}

			// Token: 0x04000FE0 RID: 4064
			private InputActions m_Wrapper;
		}

		// Token: 0x0200027E RID: 638
		public struct TrackersActions
		{

			// Token: 0x170003F6 RID: 1014
			// (get) Token: 0x060012BA RID: 4794 RVA: 0x00005B99 File Offset: 0x00003D99
			public InputAction LeftFoot
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003F7 RID: 1015
			// (get) Token: 0x060012BB RID: 4795 RVA: 0x00005B9C File Offset: 0x00003D9C
			public InputAction LeftFootTrackingState
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003F8 RID: 1016
			// (get) Token: 0x060012BC RID: 4796 RVA: 0x00005B9F File Offset: 0x00003D9F
			public InputAction RightFoot
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003F9 RID: 1017
			// (get) Token: 0x060012BD RID: 4797 RVA: 0x00005BA2 File Offset: 0x00003DA2
			public InputAction RightFootTrackingState
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003FA RID: 1018
			// (get) Token: 0x060012BE RID: 4798 RVA: 0x00005BA5 File Offset: 0x00003DA5
			public InputAction LeftShoulder
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003FB RID: 1019
			// (get) Token: 0x060012BF RID: 4799 RVA: 0x00005BA8 File Offset: 0x00003DA8
			public InputAction LeftShoulderTrackingState
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003FC RID: 1020
			// (get) Token: 0x060012C0 RID: 4800 RVA: 0x00005BAB File Offset: 0x00003DAB
			public InputAction RightShoulder
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003FD RID: 1021
			// (get) Token: 0x060012C1 RID: 4801 RVA: 0x00005BAE File Offset: 0x00003DAE
			public InputAction RightShoulderTrackingState
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003FE RID: 1022
			// (get) Token: 0x060012C2 RID: 4802 RVA: 0x00005BB1 File Offset: 0x00003DB1
			public InputAction LeftElbow
			{
				get
				{
					return null;
				}
			}

			// Token: 0x170003FF RID: 1023
			// (get) Token: 0x060012C3 RID: 4803 RVA: 0x00005BB4 File Offset: 0x00003DB4
			public InputAction LeftElbowTrackingState
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000400 RID: 1024
			// (get) Token: 0x060012C4 RID: 4804 RVA: 0x00005BB7 File Offset: 0x00003DB7
			public InputAction RightElbow
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000401 RID: 1025
			// (get) Token: 0x060012C5 RID: 4805 RVA: 0x00005BBA File Offset: 0x00003DBA
			public InputAction RightElbowTrackingState
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000402 RID: 1026
			// (get) Token: 0x060012C6 RID: 4806 RVA: 0x00005BBD File Offset: 0x00003DBD
			public InputAction LeftKnee
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000403 RID: 1027
			// (get) Token: 0x060012C7 RID: 4807 RVA: 0x00005BC0 File Offset: 0x00003DC0
			public InputAction LeftKneeTrackingState
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000404 RID: 1028
			// (get) Token: 0x060012C8 RID: 4808 RVA: 0x00005BC3 File Offset: 0x00003DC3
			public InputAction RightKnee
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000405 RID: 1029
			// (get) Token: 0x060012C9 RID: 4809 RVA: 0x00005BC6 File Offset: 0x00003DC6
			public InputAction RightKneeTrackingState
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000406 RID: 1030
			// (get) Token: 0x060012CA RID: 4810 RVA: 0x00005BC9 File Offset: 0x00003DC9
			public InputAction Waist
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000407 RID: 1031
			// (get) Token: 0x060012CB RID: 4811 RVA: 0x00005BCC File Offset: 0x00003DCC
			public InputAction WaistTrackingState
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000408 RID: 1032
			// (get) Token: 0x060012CC RID: 4812 RVA: 0x00005BCF File Offset: 0x00003DCF
			public InputAction Chest
			{
				get
				{
					return null;
				}
			}

			// Token: 0x17000409 RID: 1033
			// (get) Token: 0x060012CD RID: 4813 RVA: 0x00005BD2 File Offset: 0x00003DD2
			public InputAction ChestTrackingState
			{
				get
				{
					return null;
				}
			}

			// Token: 0x060012CE RID: 4814 RVA: 0x00005BD5 File Offset: 0x00003DD5
			public InputActionMap Get()
			{
				return null;
			}

			// Token: 0x060012CF RID: 4815 RVA: 0x00005BD8 File Offset: 0x00003DD8
			public void Enable()
			{
			}

			// Token: 0x060012D0 RID: 4816 RVA: 0x00005BDA File Offset: 0x00003DDA
			public void Disable()
			{
			}

			// Token: 0x1700040A RID: 1034
			// (get) Token: 0x060012D1 RID: 4817 RVA: 0x00005BDC File Offset: 0x00003DDC
			public bool enabled
			{
				get
				{
					return false;
				}
			}

			// Token: 0x060012D2 RID: 4818 RVA: 0x00005BDF File Offset: 0x00003DDF
			public static implicit operator InputActionMap(InputActions.TrackersActions set)
			{
				return null;
			}

			// Token: 0x060012D3 RID: 4819 RVA: 0x00005BE2 File Offset: 0x00003DE2
			public void AddCallbacks(InputActions.ITrackersActions instance)
			{
			}

			// Token: 0x060012D4 RID: 4820 RVA: 0x00005BE4 File Offset: 0x00003DE4
			private void UnregisterCallbacks(InputActions.ITrackersActions instance)
			{
			}

			// Token: 0x060012D5 RID: 4821 RVA: 0x00005BE6 File Offset: 0x00003DE6
			public void RemoveCallbacks(InputActions.ITrackersActions instance)
			{
			}

			// Token: 0x060012D6 RID: 4822 RVA: 0x00005BE8 File Offset: 0x00003DE8
			public void SetCallbacks(InputActions.ITrackersActions instance)
			{
			}

			// Token: 0x04000FE1 RID: 4065
			private InputActions m_Wrapper;
		}

		// Token: 0x0200027F RID: 639
		public interface IHMDActions
		{
			// Token: 0x060012D7 RID: 4823
			void OnTrackingState(InputAction.CallbackContext context);

			// Token: 0x060012D8 RID: 4824
			void OnPosition(InputAction.CallbackContext context);

			// Token: 0x060012D9 RID: 4825
			void OnRotation(InputAction.CallbackContext context);

			// Token: 0x060012DA RID: 4826
			void OnVelocity(InputAction.CallbackContext context);

			// Token: 0x060012DB RID: 4827
			void OnAngularVelocity(InputAction.CallbackContext context);

			// Token: 0x060012DC RID: 4828
			void OnIsTracked(InputAction.CallbackContext context);
		}

		// Token: 0x02000280 RID: 640
		public interface IControllerLActions
		{
			// Token: 0x060012DD RID: 4829
			void OnTrackingState(InputAction.CallbackContext context);

			// Token: 0x060012DE RID: 4830
			void OnPalmPose(InputAction.CallbackContext context);

			// Token: 0x060012DF RID: 4831
			void OnPointerPose(InputAction.CallbackContext context);

			// Token: 0x060012E0 RID: 4832
			void OnVelocity(InputAction.CallbackContext context);

			// Token: 0x060012E1 RID: 4833
			void OnAngularVelocity(InputAction.CallbackContext context);

			// Token: 0x060012E2 RID: 4834
			void OnPrimary2DAxis(InputAction.CallbackContext context);

			// Token: 0x060012E3 RID: 4835
			void OnPrimary2DAxisClick(InputAction.CallbackContext context);

			// Token: 0x060012E4 RID: 4836
			void OnPrimary2DAxisTouch(InputAction.CallbackContext context);

			// Token: 0x060012E5 RID: 4837
			void OnTouchpad(InputAction.CallbackContext context);

			// Token: 0x060012E6 RID: 4838
			void OnTouchpadClick(InputAction.CallbackContext context);

			// Token: 0x060012E7 RID: 4839
			void OnTouchpadTouch(InputAction.CallbackContext context);

			// Token: 0x060012E8 RID: 4840
			void OnTrigger(InputAction.CallbackContext context);

			// Token: 0x060012E9 RID: 4841
			void OnTriggerPress(InputAction.CallbackContext context);

			// Token: 0x060012EA RID: 4842
			void OnTriggerTouch(InputAction.CallbackContext context);

			// Token: 0x060012EB RID: 4843
			void OnGrip(InputAction.CallbackContext context);

			// Token: 0x060012EC RID: 4844
			void OnGripPress(InputAction.CallbackContext context);

			// Token: 0x060012ED RID: 4845
			void OnGripForce(InputAction.CallbackContext context);

			// Token: 0x060012EE RID: 4846
			void OnPrimaryButton(InputAction.CallbackContext context);

			// Token: 0x060012EF RID: 4847
			void OnPrimaryTouch(InputAction.CallbackContext context);

			// Token: 0x060012F0 RID: 4848
			void OnSecondaryButton(InputAction.CallbackContext context);

			// Token: 0x060012F1 RID: 4849
			void OnSecondaryTouch(InputAction.CallbackContext context);

			// Token: 0x060012F2 RID: 4850
			void OnMenuButton(InputAction.CallbackContext context);

			// Token: 0x060012F3 RID: 4851
			void OnHaptic(InputAction.CallbackContext context);

			// Token: 0x060012F4 RID: 4852
			void OnIsTracked(InputAction.CallbackContext context);
		}

		// Token: 0x02000281 RID: 641
		public interface IControllerRActions
		{
			// Token: 0x060012F5 RID: 4853
			void OnTrackingState(InputAction.CallbackContext context);

			// Token: 0x060012F6 RID: 4854
			void OnPalmPose(InputAction.CallbackContext context);

			// Token: 0x060012F7 RID: 4855
			void OnPointerPose(InputAction.CallbackContext context);

			// Token: 0x060012F8 RID: 4856
			void OnVelocity(InputAction.CallbackContext context);

			// Token: 0x060012F9 RID: 4857
			void OnAngularVelocity(InputAction.CallbackContext context);

			// Token: 0x060012FA RID: 4858
			void OnPrimary2DAxis(InputAction.CallbackContext context);

			// Token: 0x060012FB RID: 4859
			void OnPrimary2DAxisClick(InputAction.CallbackContext context);

			// Token: 0x060012FC RID: 4860
			void OnPrimary2DAxisTouch(InputAction.CallbackContext context);

			// Token: 0x060012FD RID: 4861
			void OnTouchpad(InputAction.CallbackContext context);

			// Token: 0x060012FE RID: 4862
			void OnTouchpadClick(InputAction.CallbackContext context);

			// Token: 0x060012FF RID: 4863
			void OnTouchpadTouch(InputAction.CallbackContext context);

			// Token: 0x06001300 RID: 4864
			void OnTrigger(InputAction.CallbackContext context);

			// Token: 0x06001301 RID: 4865
			void OnTriggerPress(InputAction.CallbackContext context);

			// Token: 0x06001302 RID: 4866
			void OnTriggerTouch(InputAction.CallbackContext context);

			// Token: 0x06001303 RID: 4867
			void OnGrip(InputAction.CallbackContext context);

			// Token: 0x06001304 RID: 4868
			void OnGripPress(InputAction.CallbackContext context);

			// Token: 0x06001305 RID: 4869
			void OnGripForce(InputAction.CallbackContext context);

			// Token: 0x06001306 RID: 4870
			void OnPrimaryButton(InputAction.CallbackContext context);

			// Token: 0x06001307 RID: 4871
			void OnPrimaryTouch(InputAction.CallbackContext context);

			// Token: 0x06001308 RID: 4872
			void OnSecondaryButton(InputAction.CallbackContext context);

			// Token: 0x06001309 RID: 4873
			void OnSecondaryTouch(InputAction.CallbackContext context);

			// Token: 0x0600130A RID: 4874
			void OnHaptic(InputAction.CallbackContext context);

			// Token: 0x0600130B RID: 4875
			void OnIsTracked(InputAction.CallbackContext context);
		}

		// Token: 0x02000282 RID: 642
		public interface IGamepadActions
		{
			// Token: 0x0600130C RID: 4876
			void OnLeftJoystick2DAxis(InputAction.CallbackContext context);

			// Token: 0x0600130D RID: 4877
			void OnLeftTrigger1DAxis(InputAction.CallbackContext context);

			// Token: 0x0600130E RID: 4878
			void OnLeftJoystickButton(InputAction.CallbackContext context);

			// Token: 0x0600130F RID: 4879
			void OnLeftShoulderButton(InputAction.CallbackContext context);

			// Token: 0x06001310 RID: 4880
			void OnLeftNorthButton(InputAction.CallbackContext context);

			// Token: 0x06001311 RID: 4881
			void OnLeftEastButton(InputAction.CallbackContext context);

			// Token: 0x06001312 RID: 4882
			void OnLeftSouthButton(InputAction.CallbackContext context);

			// Token: 0x06001313 RID: 4883
			void OnLeftWestButton(InputAction.CallbackContext context);

			// Token: 0x06001314 RID: 4884
			void OnSelectButton(InputAction.CallbackContext context);

			// Token: 0x06001315 RID: 4885
			void OnRightJoystick2DAxis(InputAction.CallbackContext context);

			// Token: 0x06001316 RID: 4886
			void OnRightTrigger1DAxis(InputAction.CallbackContext context);

			// Token: 0x06001317 RID: 4887
			void OnRightJoystickButton(InputAction.CallbackContext context);

			// Token: 0x06001318 RID: 4888
			void OnRightShoulderButton(InputAction.CallbackContext context);

			// Token: 0x06001319 RID: 4889
			void OnRightNorthButton(InputAction.CallbackContext context);

			// Token: 0x0600131A RID: 4890
			void OnRightEastButton(InputAction.CallbackContext context);

			// Token: 0x0600131B RID: 4891
			void OnRightSouthButton(InputAction.CallbackContext context);

			// Token: 0x0600131C RID: 4892
			void OnRightWestButton(InputAction.CallbackContext context);

			// Token: 0x0600131D RID: 4893
			void OnStartButton(InputAction.CallbackContext context);
		}

		// Token: 0x02000283 RID: 643
		public interface IMouseActions
		{
			// Token: 0x0600131E RID: 4894
			void OnMouse_ForwardButton(InputAction.CallbackContext context);

			// Token: 0x0600131F RID: 4895
			void OnMouse_BackButton(InputAction.CallbackContext context);

			// Token: 0x06001320 RID: 4896
			void OnMouse_RButton(InputAction.CallbackContext context);

			// Token: 0x06001321 RID: 4897
			void OnMouse_MButton(InputAction.CallbackContext context);

			// Token: 0x06001322 RID: 4898
			void OnMouse_LButton(InputAction.CallbackContext context);

			// Token: 0x06001323 RID: 4899
			void OnMouse_Delta(InputAction.CallbackContext context);

			// Token: 0x06001324 RID: 4900
			void OnMouse_Scroll(InputAction.CallbackContext context);
		}

		// Token: 0x02000284 RID: 644
		public interface IPositionalKeyboardActions
		{
			// Token: 0x06001325 RID: 4901
			void OnPositional_Escape(InputAction.CallbackContext context);

			// Token: 0x06001326 RID: 4902
			void OnPositional_Space(InputAction.CallbackContext context);

			// Token: 0x06001327 RID: 4903
			void OnPositional_Enter(InputAction.CallbackContext context);

			// Token: 0x06001328 RID: 4904
			void OnPositional_Tab(InputAction.CallbackContext context);

			// Token: 0x06001329 RID: 4905
			void OnPositional_Backquote(InputAction.CallbackContext context);

			// Token: 0x0600132A RID: 4906
			void OnPositional_Quote(InputAction.CallbackContext context);

			// Token: 0x0600132B RID: 4907
			void OnPositional_Semicolon(InputAction.CallbackContext context);

			// Token: 0x0600132C RID: 4908
			void OnPositional_Comma(InputAction.CallbackContext context);

			// Token: 0x0600132D RID: 4909
			void OnPositional_Period(InputAction.CallbackContext context);

			// Token: 0x0600132E RID: 4910
			void OnPositional_Slash(InputAction.CallbackContext context);

			// Token: 0x0600132F RID: 4911
			void OnPositional_Backslash(InputAction.CallbackContext context);

			// Token: 0x06001330 RID: 4912
			void OnPositional_LeftBracket(InputAction.CallbackContext context);

			// Token: 0x06001331 RID: 4913
			void OnPositional_RightBracket(InputAction.CallbackContext context);

			// Token: 0x06001332 RID: 4914
			void OnPositional_Minus(InputAction.CallbackContext context);

			// Token: 0x06001333 RID: 4915
			void OnPositional_Equals(InputAction.CallbackContext context);

			// Token: 0x06001334 RID: 4916
			void OnPositional_UpArrow(InputAction.CallbackContext context);

			// Token: 0x06001335 RID: 4917
			void OnPositional_DownArrow(InputAction.CallbackContext context);

			// Token: 0x06001336 RID: 4918
			void OnPositional_LeftArrow(InputAction.CallbackContext context);

			// Token: 0x06001337 RID: 4919
			void OnPositional_RightArrow(InputAction.CallbackContext context);

			// Token: 0x06001338 RID: 4920
			void OnPositional_A(InputAction.CallbackContext context);

			// Token: 0x06001339 RID: 4921
			void OnPositional_B(InputAction.CallbackContext context);

			// Token: 0x0600133A RID: 4922
			void OnPositional_C(InputAction.CallbackContext context);

			// Token: 0x0600133B RID: 4923
			void OnPositional_D(InputAction.CallbackContext context);

			// Token: 0x0600133C RID: 4924
			void OnPositional_E(InputAction.CallbackContext context);

			// Token: 0x0600133D RID: 4925
			void OnPositional_F(InputAction.CallbackContext context);

			// Token: 0x0600133E RID: 4926
			void OnPositional_G(InputAction.CallbackContext context);

			// Token: 0x0600133F RID: 4927
			void OnPositional_H(InputAction.CallbackContext context);

			// Token: 0x06001340 RID: 4928
			void OnPositional_I(InputAction.CallbackContext context);

			// Token: 0x06001341 RID: 4929
			void OnPositional_J(InputAction.CallbackContext context);

			// Token: 0x06001342 RID: 4930
			void OnPositional_K(InputAction.CallbackContext context);

			// Token: 0x06001343 RID: 4931
			void OnPositional_L(InputAction.CallbackContext context);

			// Token: 0x06001344 RID: 4932
			void OnPositional_M(InputAction.CallbackContext context);

			// Token: 0x06001345 RID: 4933
			void OnPositional_N(InputAction.CallbackContext context);

			// Token: 0x06001346 RID: 4934
			void OnPositional_O(InputAction.CallbackContext context);

			// Token: 0x06001347 RID: 4935
			void OnPositional_P(InputAction.CallbackContext context);

			// Token: 0x06001348 RID: 4936
			void OnPositional_Q(InputAction.CallbackContext context);

			// Token: 0x06001349 RID: 4937
			void OnPositional_R(InputAction.CallbackContext context);

			// Token: 0x0600134A RID: 4938
			void OnPositional_S(InputAction.CallbackContext context);

			// Token: 0x0600134B RID: 4939
			void OnPositional_T(InputAction.CallbackContext context);

			// Token: 0x0600134C RID: 4940
			void OnPositional_U(InputAction.CallbackContext context);

			// Token: 0x0600134D RID: 4941
			void OnPositional_V(InputAction.CallbackContext context);

			// Token: 0x0600134E RID: 4942
			void OnPositional_W(InputAction.CallbackContext context);

			// Token: 0x0600134F RID: 4943
			void OnPositional_X(InputAction.CallbackContext context);

			// Token: 0x06001350 RID: 4944
			void OnPositional_Y(InputAction.CallbackContext context);

			// Token: 0x06001351 RID: 4945
			void OnPositional_Z(InputAction.CallbackContext context);

			// Token: 0x06001352 RID: 4946
			void OnPositional_1(InputAction.CallbackContext context);

			// Token: 0x06001353 RID: 4947
			void OnPositional_2(InputAction.CallbackContext context);

			// Token: 0x06001354 RID: 4948
			void OnPositional_3(InputAction.CallbackContext context);

			// Token: 0x06001355 RID: 4949
			void OnPositional_4(InputAction.CallbackContext context);

			// Token: 0x06001356 RID: 4950
			void OnPositional_5(InputAction.CallbackContext context);

			// Token: 0x06001357 RID: 4951
			void OnPositional_6(InputAction.CallbackContext context);

			// Token: 0x06001358 RID: 4952
			void OnPositional_7(InputAction.CallbackContext context);

			// Token: 0x06001359 RID: 4953
			void OnPositional_8(InputAction.CallbackContext context);

			// Token: 0x0600135A RID: 4954
			void OnPositional_9(InputAction.CallbackContext context);

			// Token: 0x0600135B RID: 4955
			void OnPositional_0(InputAction.CallbackContext context);

			// Token: 0x0600135C RID: 4956
			void OnPositional_LeftShift(InputAction.CallbackContext context);

			// Token: 0x0600135D RID: 4957
			void OnPositional_RightShift(InputAction.CallbackContext context);

			// Token: 0x0600135E RID: 4958
			void OnPositional_LeftAlt(InputAction.CallbackContext context);

			// Token: 0x0600135F RID: 4959
			void OnPositional_RightAlt(InputAction.CallbackContext context);

			// Token: 0x06001360 RID: 4960
			void OnPositional_LeftCtrl(InputAction.CallbackContext context);

			// Token: 0x06001361 RID: 4961
			void OnPositional_RightCtrl(InputAction.CallbackContext context);

			// Token: 0x06001362 RID: 4962
			void OnPositional_LeftMeta(InputAction.CallbackContext context);

			// Token: 0x06001363 RID: 4963
			void OnPositional_RightMeta(InputAction.CallbackContext context);

			// Token: 0x06001364 RID: 4964
			void OnPositional_ContextMenu(InputAction.CallbackContext context);

			// Token: 0x06001365 RID: 4965
			void OnPositional_Backspace(InputAction.CallbackContext context);

			// Token: 0x06001366 RID: 4966
			void OnPositional_PageDown(InputAction.CallbackContext context);

			// Token: 0x06001367 RID: 4967
			void OnPositional_PageUp(InputAction.CallbackContext context);

			// Token: 0x06001368 RID: 4968
			void OnPositional_Home(InputAction.CallbackContext context);

			// Token: 0x06001369 RID: 4969
			void OnPositional_End(InputAction.CallbackContext context);

			// Token: 0x0600136A RID: 4970
			void OnPositional_Insert(InputAction.CallbackContext context);

			// Token: 0x0600136B RID: 4971
			void OnPositional_Delete(InputAction.CallbackContext context);

			// Token: 0x0600136C RID: 4972
			void OnPositional_CapsLock(InputAction.CallbackContext context);

			// Token: 0x0600136D RID: 4973
			void OnPositional_NumLock(InputAction.CallbackContext context);

			// Token: 0x0600136E RID: 4974
			void OnPositional_PrintScreen(InputAction.CallbackContext context);

			// Token: 0x0600136F RID: 4975
			void OnPositional_ScrollLock(InputAction.CallbackContext context);

			// Token: 0x06001370 RID: 4976
			void OnPositional_Pause(InputAction.CallbackContext context);

			// Token: 0x06001371 RID: 4977
			void OnPositional_NumpadEnter(InputAction.CallbackContext context);

			// Token: 0x06001372 RID: 4978
			void OnPositional_NumpadDivide(InputAction.CallbackContext context);

			// Token: 0x06001373 RID: 4979
			void OnPositional_NumpadMultiply(InputAction.CallbackContext context);

			// Token: 0x06001374 RID: 4980
			void OnPositional_NumpadPlus(InputAction.CallbackContext context);

			// Token: 0x06001375 RID: 4981
			void OnPositional_NumpadMinus(InputAction.CallbackContext context);

			// Token: 0x06001376 RID: 4982
			void OnPositional_NumpadPeriod(InputAction.CallbackContext context);

			// Token: 0x06001377 RID: 4983
			void OnPositional_NumpadEquals(InputAction.CallbackContext context);

			// Token: 0x06001378 RID: 4984
			void OnPositional_Numpad1(InputAction.CallbackContext context);

			// Token: 0x06001379 RID: 4985
			void OnPositional_Numpad2(InputAction.CallbackContext context);

			// Token: 0x0600137A RID: 4986
			void OnPositional_Numpad3(InputAction.CallbackContext context);

			// Token: 0x0600137B RID: 4987
			void OnPositional_Numpad4(InputAction.CallbackContext context);

			// Token: 0x0600137C RID: 4988
			void OnPositional_Numpad5(InputAction.CallbackContext context);

			// Token: 0x0600137D RID: 4989
			void OnPositional_Numpad6(InputAction.CallbackContext context);

			// Token: 0x0600137E RID: 4990
			void OnPositional_Numpad7(InputAction.CallbackContext context);

			// Token: 0x0600137F RID: 4991
			void OnPositional_Numpad8(InputAction.CallbackContext context);

			// Token: 0x06001380 RID: 4992
			void OnPositional_Numpad9(InputAction.CallbackContext context);

			// Token: 0x06001381 RID: 4993
			void OnPositional_Numpad0(InputAction.CallbackContext context);

			// Token: 0x06001382 RID: 4994
			void OnPositional_F1(InputAction.CallbackContext context);

			// Token: 0x06001383 RID: 4995
			void OnPositional_F2(InputAction.CallbackContext context);

			// Token: 0x06001384 RID: 4996
			void OnPositional_F3(InputAction.CallbackContext context);

			// Token: 0x06001385 RID: 4997
			void OnPositional_F4(InputAction.CallbackContext context);

			// Token: 0x06001386 RID: 4998
			void OnPositional_F5(InputAction.CallbackContext context);

			// Token: 0x06001387 RID: 4999
			void OnPositional_F6(InputAction.CallbackContext context);

			// Token: 0x06001388 RID: 5000
			void OnPositional_F7(InputAction.CallbackContext context);

			// Token: 0x06001389 RID: 5001
			void OnPositional_F8(InputAction.CallbackContext context);

			// Token: 0x0600138A RID: 5002
			void OnPositional_F9(InputAction.CallbackContext context);

			// Token: 0x0600138B RID: 5003
			void OnPositional_F10(InputAction.CallbackContext context);

			// Token: 0x0600138C RID: 5004
			void OnPositional_F11(InputAction.CallbackContext context);

			// Token: 0x0600138D RID: 5005
			void OnPositional_F12(InputAction.CallbackContext context);

			// Token: 0x0600138E RID: 5006
			void OnPositional_OEM1(InputAction.CallbackContext context);

			// Token: 0x0600138F RID: 5007
			void OnPositional_OEM2(InputAction.CallbackContext context);

			// Token: 0x06001390 RID: 5008
			void OnPositional_OEM3(InputAction.CallbackContext context);

			// Token: 0x06001391 RID: 5009
			void OnPositional_OEM4(InputAction.CallbackContext context);

			// Token: 0x06001392 RID: 5010
			void OnPositional_OEM5(InputAction.CallbackContext context);
		}

		// Token: 0x02000285 RID: 645
		public interface IJoystickActions
		{
			// Token: 0x06001393 RID: 5011
			void OnStick(InputAction.CallbackContext context);

			// Token: 0x06001394 RID: 5012
			void OnTrigger(InputAction.CallbackContext context);
		}

		// Token: 0x02000286 RID: 646
		public interface ITrackersActions
		{
			// Token: 0x06001395 RID: 5013
			void OnLeftFoot(InputAction.CallbackContext context);

			// Token: 0x06001396 RID: 5014
			void OnLeftFootTrackingState(InputAction.CallbackContext context);

			// Token: 0x06001397 RID: 5015
			void OnRightFoot(InputAction.CallbackContext context);

			// Token: 0x06001398 RID: 5016
			void OnRightFootTrackingState(InputAction.CallbackContext context);

			// Token: 0x06001399 RID: 5017
			void OnLeftShoulder(InputAction.CallbackContext context);

			// Token: 0x0600139A RID: 5018
			void OnLeftShoulderTrackingState(InputAction.CallbackContext context);

			// Token: 0x0600139B RID: 5019
			void OnRightShoulder(InputAction.CallbackContext context);

			// Token: 0x0600139C RID: 5020
			void OnRightShoulderTrackingState(InputAction.CallbackContext context);

			// Token: 0x0600139D RID: 5021
			void OnLeftElbow(InputAction.CallbackContext context);

			// Token: 0x0600139E RID: 5022
			void OnLeftElbowTrackingState(InputAction.CallbackContext context);

			// Token: 0x0600139F RID: 5023
			void OnRightElbow(InputAction.CallbackContext context);

			// Token: 0x060013A0 RID: 5024
			void OnRightElbowTrackingState(InputAction.CallbackContext context);

			// Token: 0x060013A1 RID: 5025
			void OnLeftKnee(InputAction.CallbackContext context);

			// Token: 0x060013A2 RID: 5026
			void OnLeftKneeTrackingState(InputAction.CallbackContext context);

			// Token: 0x060013A3 RID: 5027
			void OnRightKnee(InputAction.CallbackContext context);

			// Token: 0x060013A4 RID: 5028
			void OnRightKneeTrackingState(InputAction.CallbackContext context);

			// Token: 0x060013A5 RID: 5029
			void OnWaist(InputAction.CallbackContext context);

			// Token: 0x060013A6 RID: 5030
			void OnWaistTrackingState(InputAction.CallbackContext context);

			// Token: 0x060013A7 RID: 5031
			void OnChest(InputAction.CallbackContext context);

			// Token: 0x060013A8 RID: 5032
			void OnChestTrackingState(InputAction.CallbackContext context);
		}
	}

	public class ReadOnlyArray<T>
	{
	}

	public class InputControlScheme
	{
	}

	public class InputBinding
	{
	}
	
	public class InputActionAsset
	{
	}

	public class InputActionMap
	{
	}

	public interface IInputActionCollection
	{
	}

	public interface IInputActionCollection2
	{
	}
}
