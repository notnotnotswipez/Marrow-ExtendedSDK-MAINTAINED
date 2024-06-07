using SLZ.Bonelab.Obsolete;
using UnityEngine;

public class MonomatItemSwapper : MonoBehaviour
{
	[SerializeField]
	private Control_MonoMat controlMono;

	[SerializeField]
	private MonomatItem itemA;

	[SerializeField]
	private MonomatItem itemB;

	[SerializeField]
	private MonomatItem itemC;

	private void Awake()
	{
	}

	public void SwapGroup(int item)
	{
	}
}
