using System;
using UnityEngine;

[Serializable]
public class LTRect
{
	public Rect _rect;

	public float alpha;

	public float rotation;

	public Vector2 pivot;

	public Vector2 margin;

	public Rect relativeRect;

	public bool rotateEnabled;

	[HideInInspector]
	public bool rotateFinished;

	public bool alphaEnabled;

	public string labelStr;

	public LTGUI.Element_Type type;

	public GUIStyle style;

	public bool useColor;

	public Color color;

	public bool fontScaleToFit;

	public bool useSimpleScale;

	public bool sizeByHeight;

	public Texture texture;

	private int _id;

	[HideInInspector]
	public int counter;

	public static bool colorTouched;

	public bool hasInitiliazed => false;

	public int id => 0;

	public float x
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float y
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float width
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float height
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public Rect rect
	{
		get
		{
			return default(Rect);
		}
		set
		{
		}
	}

	public LTRect()
	{
	}

	public LTRect(Rect rect)
	{
	}

	public LTRect(float x, float y, float width, float height)
	{
	}

	public LTRect(float x, float y, float width, float height, float alpha)
	{
	}

	public LTRect(float x, float y, float width, float height, float alpha, float rotation)
	{
	}

	public void setId(int id, int counter)
	{
	}

	public void reset()
	{
	}

	public void resetForRotation()
	{
	}

	public LTRect setStyle(GUIStyle style)
	{
		return null;
	}

	public LTRect setFontScaleToFit(bool fontScaleToFit)
	{
		return null;
	}

	public LTRect setColor(Color color)
	{
		return null;
	}

	public LTRect setAlpha(float alpha)
	{
		return null;
	}

	public LTRect setLabel(string str)
	{
		return null;
	}

	public LTRect setUseSimpleScale(bool useSimpleScale, Rect relativeRect)
	{
		return null;
	}

	public LTRect setUseSimpleScale(bool useSimpleScale)
	{
		return null;
	}

	public LTRect setSizeByHeight(bool sizeByHeight)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
