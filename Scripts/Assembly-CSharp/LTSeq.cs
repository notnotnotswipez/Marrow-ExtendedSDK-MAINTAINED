using System;
using UnityEngine;

public class LTSeq
{
	public LTSeq previous;

	public LTSeq current;

	public LTDescr tween;

	public float totalDelay;

	public float timeScale;

	private int debugIter;

	public uint counter;

	public bool toggle;

	private uint _id;

	public int id => 0;

	public void reset()
	{
	}

	public void init(uint id, uint global_counter)
	{
	}

	private LTSeq addOn()
	{
		return null;
	}

	private float addPreviousDelays()
	{
		return 0f;
	}

	public LTSeq append(float delay)
	{
		return null;
	}

	public LTSeq append(Action callback)
	{
		return null;
	}

	public LTSeq append(Action<object> callback, object obj)
	{
		return null;
	}

	public LTSeq append(GameObject gameObject, Action callback)
	{
		return null;
	}

	public LTSeq append(GameObject gameObject, Action<object> callback, object obj)
	{
		return null;
	}

	public LTSeq append(LTDescr tween)
	{
		return null;
	}

	public LTSeq insert(LTDescr tween)
	{
		return null;
	}

	public LTSeq setScale(float timeScale)
	{
		return null;
	}

	private void setScaleRecursive(LTSeq seq, float timeScale, int count)
	{
	}

	public LTSeq reverse()
	{
		return null;
	}
}
