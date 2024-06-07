using System.Collections.Generic;
using SLZ.Marrow.Utilities;
using UnityEngine;

namespace SLZ.Interaction
{
	public class AlignPlug : Plug
	{
		private float _speed;

		private float _perc;

		private float _exitTime;

		private bool _isActive;

		private bool _isLocked;

		private bool _isEnterTransition;

		private bool _isExitTransition;

		private bool _isPhysicsGrip;

		private bool _isStageTwoAnimation;

		private bool _isExitComplete;

		public Grip proxyGrip;

		[Range(30f, 90f)]
		public float minSwingAngle;

		private float _minSwingAngleCos;

		private List<Socket> _sockets;

		protected Socket _lastSocket;

		private ConfigurableJoint _joint;

		private int _handAttachedCount;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private SimpleTransform CalcPlugInsertPosition()
		{
			return default(SimpleTransform);
		}

		private void Update()
		{
		}

		private void OnHandAttached(InteractableHost host, Hand hand)
		{
		}

		private void OnHandDetached(InteractableHost host, Hand hand)
		{
		}

		public void OnHandFixedUpdate()
		{
		}

		private void InsertPlug(Socket socket)
		{
		}

		public void ForceInSocket(Socket socket)
		{
		}

		public void ClearFromSocket()
		{
		}

		public void EjectPlug()
		{
		}

		public override void OnPlugHoverBegin(Socket socket)
		{
		}

		public override void OnPlugHoverEnd(Socket socket)
		{
		}

		protected virtual void OnPlugExitComplete()
		{
		}

		private void CompletePlugInsert(SimpleTransform hostInPlug)
		{
		}

		protected virtual void OnPlugInsertComplete()
		{
		}

		private void OnProxyGrab(Hand hand)
		{
		}

		private void OnProxyRelease(Hand hand)
		{
		}

		private void OnHostGrab(InteractableHost host, Hand hand)
		{
		}

		private void OnHostRelease(InteractableHost host, Hand hand)
		{
		}

		public override void OnDespawn()
		{
		}
	}
}
