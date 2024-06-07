using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class LTDescr
{
	public delegate Vector3 EaseTypeDelegate();

	public delegate void ActionMethodDelegate();

	public bool toggle;

	public bool useEstimatedTime;

	public bool useFrames;

	public bool useManualTime;

	public bool usesNormalDt;

	public bool hasInitiliazed;

	public bool hasExtraOnCompletes;

	public bool hasPhysics;

	public bool onCompleteOnRepeat;

	public bool onCompleteOnStart;

	public bool useRecursion;

	public float ratioPassed;

	public float passed;

	public float delay;

	public float time;

	public float speed;

	public float lastVal;

	private uint _id;

	public int loopCount;

	public uint counter;

	public float direction;

	public float directionLast;

	public float overshoot;

	public float period;

	public float scale;

	public bool destroyOnComplete;

	public Transform trans;

	internal Vector3 fromInternal;

	internal Vector3 toInternal;

	internal Vector3 diff;

	internal Vector3 diffDiv2;

	public TweenAction type;

	private LeanTweenType easeType;

	public LeanTweenType loopType;

	public bool hasUpdateCallback;

	public EaseTypeDelegate easeMethod;

	public SpriteRenderer spriteRen;

	public RectTransform rectTransform;

	public Text uiText;

	public Image uiImage;

	public RawImage rawImage;

	public Sprite[] sprites;

	public LTDescrOptional _optional;

	public static float val;

	public static float dt;

	public static Vector3 newVect;

	public Vector3 from
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 to
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public ActionMethodDelegate easeInternal
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public ActionMethodDelegate initInternal
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Transform toTrans => null;

	public int uniqueId => 0;

	public int id => 0;

	public LTDescrOptional optional
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override string ToString()
	{
		return null;
	}

	[Obsolete("Use 'LeanTween.cancel( id )' instead")]
	public LTDescr cancel(GameObject gameObject)
	{
		return null;
	}

	public void reset()
	{
	}

	public LTDescr setFollow()
	{
		return null;
	}

	public LTDescr setMoveX()
	{
		return null;
	}

	public LTDescr setMoveY()
	{
		return null;
	}

	public LTDescr setMoveZ()
	{
		return null;
	}

	public LTDescr setMoveLocalX()
	{
		return null;
	}

	public LTDescr setMoveLocalY()
	{
		return null;
	}

	public LTDescr setMoveLocalZ()
	{
		return null;
	}

	private void initFromInternal()
	{
	}

	public LTDescr setOffset(Vector3 offset)
	{
		return null;
	}

	public LTDescr setMoveCurved()
	{
		return null;
	}

	public LTDescr setMoveCurvedLocal()
	{
		return null;
	}

	public LTDescr setMoveSpline()
	{
		return null;
	}

	public LTDescr setMoveSplineLocal()
	{
		return null;
	}

	public LTDescr setScaleX()
	{
		return null;
	}

	public LTDescr setScaleY()
	{
		return null;
	}

	public LTDescr setScaleZ()
	{
		return null;
	}

	public LTDescr setRotateX()
	{
		return null;
	}

	public LTDescr setRotateY()
	{
		return null;
	}

	public LTDescr setRotateZ()
	{
		return null;
	}

	public LTDescr setRotateAround()
	{
		return null;
	}

	public LTDescr setRotateAroundLocal()
	{
		return null;
	}

	public LTDescr setAlpha()
	{
		return null;
	}

	public LTDescr setTextAlpha()
	{
		return null;
	}

	public LTDescr setAlphaVertex()
	{
		return null;
	}

	public LTDescr setColor()
	{
		return null;
	}

	public LTDescr setCallbackColor()
	{
		return null;
	}

	public LTDescr setTextColor()
	{
		return null;
	}

	public LTDescr setCanvasAlpha()
	{
		return null;
	}

	public LTDescr setCanvasGroupAlpha()
	{
		return null;
	}

	public LTDescr setCanvasColor()
	{
		return null;
	}

	public LTDescr setCanvasMoveX()
	{
		return null;
	}

	public LTDescr setCanvasMoveY()
	{
		return null;
	}

	public LTDescr setCanvasMoveZ()
	{
		return null;
	}

	private void initCanvasRotateAround()
	{
	}

	public LTDescr setCanvasRotateAround()
	{
		return null;
	}

	public LTDescr setCanvasRotateAroundLocal()
	{
		return null;
	}

	public LTDescr setCanvasPlaySprite()
	{
		return null;
	}

	public LTDescr setCanvasMove()
	{
		return null;
	}

	public LTDescr setCanvasScale()
	{
		return null;
	}

	public LTDescr setCanvasSizeDelta()
	{
		return null;
	}

	private void callback()
	{
	}

	public LTDescr setCallback()
	{
		return null;
	}

	public LTDescr setValue3()
	{
		return null;
	}

	public LTDescr setMove()
	{
		return null;
	}

	public LTDescr setMoveLocal()
	{
		return null;
	}

	public LTDescr setMoveToTransform()
	{
		return null;
	}

	public LTDescr setRotate()
	{
		return null;
	}

	public LTDescr setRotateLocal()
	{
		return null;
	}

	public LTDescr setScale()
	{
		return null;
	}

	public LTDescr setGUIMove()
	{
		return null;
	}

	public LTDescr setGUIMoveMargin()
	{
		return null;
	}

	public LTDescr setGUIScale()
	{
		return null;
	}

	public LTDescr setGUIAlpha()
	{
		return null;
	}

	public LTDescr setGUIRotate()
	{
		return null;
	}

	public LTDescr setDelayedSound()
	{
		return null;
	}

	public LTDescr setTarget(Transform trans)
	{
		return null;
	}

	private void init()
	{
	}

	private void initSpeed()
	{
	}

	public LTDescr updateNow()
	{
		return null;
	}

	public bool updateInternal()
	{
		return false;
	}

	public void callOnCompletes()
	{
	}

	public LTDescr setFromColor(Color col)
	{
		return null;
	}

	private static void alphaRecursive(Transform transform, float val, bool useRecursion = true)
	{
	}

	private static void colorRecursive(Transform transform, Color toColor, bool useRecursion = true)
	{
	}

	private static void alphaRecursive(RectTransform rectTransform, float val, int recursiveLevel = 0)
	{
	}

	private static void alphaRecursiveSprite(Transform transform, float val)
	{
	}

	private static void colorRecursiveSprite(Transform transform, Color toColor)
	{
	}

	private static void colorRecursive(RectTransform rectTransform, Color toColor)
	{
	}

	private static void textAlphaChildrenRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	private static void textAlphaRecursive(Transform trans, float val, bool useRecursion = true)
	{
	}

	private static void textColorRecursive(Transform trans, Color toColor)
	{
	}

	private static Color tweenColor(LTDescr tween, float val)
	{
		return default(Color);
	}

	public LTDescr pause()
	{
		return null;
	}

	public LTDescr resume()
	{
		return null;
	}

	public LTDescr setAxis(Vector3 axis)
	{
		return null;
	}

	public LTDescr setDelay(float delay)
	{
		return null;
	}

	public LTDescr setEase(LeanTweenType easeType)
	{
		return null;
	}

	public LTDescr setEaseLinear()
	{
		return null;
	}

	public LTDescr setEaseSpring()
	{
		return null;
	}

	public LTDescr setEaseInQuad()
	{
		return null;
	}

	public LTDescr setEaseOutQuad()
	{
		return null;
	}

	public LTDescr setEaseInOutQuad()
	{
		return null;
	}

	public LTDescr setEaseInCubic()
	{
		return null;
	}

	public LTDescr setEaseOutCubic()
	{
		return null;
	}

	public LTDescr setEaseInOutCubic()
	{
		return null;
	}

	public LTDescr setEaseInQuart()
	{
		return null;
	}

	public LTDescr setEaseOutQuart()
	{
		return null;
	}

	public LTDescr setEaseInOutQuart()
	{
		return null;
	}

	public LTDescr setEaseInQuint()
	{
		return null;
	}

	public LTDescr setEaseOutQuint()
	{
		return null;
	}

	public LTDescr setEaseInOutQuint()
	{
		return null;
	}

	public LTDescr setEaseInSine()
	{
		return null;
	}

	public LTDescr setEaseOutSine()
	{
		return null;
	}

	public LTDescr setEaseInOutSine()
	{
		return null;
	}

	public LTDescr setEaseInExpo()
	{
		return null;
	}

	public LTDescr setEaseOutExpo()
	{
		return null;
	}

	public LTDescr setEaseInOutExpo()
	{
		return null;
	}

	public LTDescr setEaseInCirc()
	{
		return null;
	}

	public LTDescr setEaseOutCirc()
	{
		return null;
	}

	public LTDescr setEaseInOutCirc()
	{
		return null;
	}

	public LTDescr setEaseInBounce()
	{
		return null;
	}

	public LTDescr setEaseOutBounce()
	{
		return null;
	}

	public LTDescr setEaseInOutBounce()
	{
		return null;
	}

	public LTDescr setEaseInBack()
	{
		return null;
	}

	public LTDescr setEaseOutBack()
	{
		return null;
	}

	public LTDescr setEaseInOutBack()
	{
		return null;
	}

	public LTDescr setEaseInElastic()
	{
		return null;
	}

	public LTDescr setEaseOutElastic()
	{
		return null;
	}

	public LTDescr setEaseInOutElastic()
	{
		return null;
	}

	public LTDescr setEasePunch()
	{
		return null;
	}

	public LTDescr setEaseShake()
	{
		return null;
	}

	private Vector3 tweenOnCurve()
	{
		return default(Vector3);
	}

	private Vector3 easeInOutQuad()
	{
		return default(Vector3);
	}

	private Vector3 easeInQuad()
	{
		return default(Vector3);
	}

	private Vector3 easeOutQuad()
	{
		return default(Vector3);
	}

	private Vector3 easeLinear()
	{
		return default(Vector3);
	}

	private Vector3 easeSpring()
	{
		return default(Vector3);
	}

	private Vector3 easeInCubic()
	{
		return default(Vector3);
	}

	private Vector3 easeOutCubic()
	{
		return default(Vector3);
	}

	private Vector3 easeInOutCubic()
	{
		return default(Vector3);
	}

	private Vector3 easeInQuart()
	{
		return default(Vector3);
	}

	private Vector3 easeOutQuart()
	{
		return default(Vector3);
	}

	private Vector3 easeInOutQuart()
	{
		return default(Vector3);
	}

	private Vector3 easeInQuint()
	{
		return default(Vector3);
	}

	private Vector3 easeOutQuint()
	{
		return default(Vector3);
	}

	private Vector3 easeInOutQuint()
	{
		return default(Vector3);
	}

	private Vector3 easeInSine()
	{
		return default(Vector3);
	}

	private Vector3 easeOutSine()
	{
		return default(Vector3);
	}

	private Vector3 easeInOutSine()
	{
		return default(Vector3);
	}

	private Vector3 easeInExpo()
	{
		return default(Vector3);
	}

	private Vector3 easeOutExpo()
	{
		return default(Vector3);
	}

	private Vector3 easeInOutExpo()
	{
		return default(Vector3);
	}

	private Vector3 easeInCirc()
	{
		return default(Vector3);
	}

	private Vector3 easeOutCirc()
	{
		return default(Vector3);
	}

	private Vector3 easeInOutCirc()
	{
		return default(Vector3);
	}

	private Vector3 easeInBounce()
	{
		return default(Vector3);
	}

	private Vector3 easeOutBounce()
	{
		return default(Vector3);
	}

	private Vector3 easeInOutBounce()
	{
		return default(Vector3);
	}

	private Vector3 easeInBack()
	{
		return default(Vector3);
	}

	private Vector3 easeOutBack()
	{
		return default(Vector3);
	}

	private Vector3 easeInOutBack()
	{
		return default(Vector3);
	}

	private Vector3 easeInElastic()
	{
		return default(Vector3);
	}

	private Vector3 easeOutElastic()
	{
		return default(Vector3);
	}

	private Vector3 easeInOutElastic()
	{
		return default(Vector3);
	}

	public LTDescr setOvershoot(float overshoot)
	{
		return null;
	}

	public LTDescr setPeriod(float period)
	{
		return null;
	}

	public LTDescr setScale(float scale)
	{
		return null;
	}

	public LTDescr setEase(AnimationCurve easeCurve)
	{
		return null;
	}

	public LTDescr setTo(Vector3 to)
	{
		return null;
	}

	public LTDescr setTo(Transform to)
	{
		return null;
	}

	public LTDescr setFrom(Vector3 from)
	{
		return null;
	}

	public LTDescr setFrom(float from)
	{
		return null;
	}

	public LTDescr setDiff(Vector3 diff)
	{
		return null;
	}

	public LTDescr setHasInitialized(bool has)
	{
		return null;
	}

	public LTDescr setId(uint id, uint global_counter)
	{
		return null;
	}

	public LTDescr setPassed(float passed)
	{
		return null;
	}

	public LTDescr setTime(float time)
	{
		return null;
	}

	public LTDescr setSpeed(float speed)
	{
		return null;
	}

	public LTDescr setRepeat(int repeat)
	{
		return null;
	}

	public LTDescr setLoopType(LeanTweenType loopType)
	{
		return null;
	}

	public LTDescr setUseEstimatedTime(bool useEstimatedTime)
	{
		return null;
	}

	public LTDescr setIgnoreTimeScale(bool useUnScaledTime)
	{
		return null;
	}

	public LTDescr setUseFrames(bool useFrames)
	{
		return null;
	}

	public LTDescr setUseManualTime(bool useManualTime)
	{
		return null;
	}

	public LTDescr setLoopCount(int loopCount)
	{
		return null;
	}

	public LTDescr setLoopOnce()
	{
		return null;
	}

	public LTDescr setLoopClamp()
	{
		return null;
	}

	public LTDescr setLoopClamp(int loops)
	{
		return null;
	}

	public LTDescr setLoopPingPong()
	{
		return null;
	}

	public LTDescr setLoopPingPong(int loops)
	{
		return null;
	}

	public LTDescr setOnComplete(Action onComplete)
	{
		return null;
	}

	public LTDescr setOnComplete(Action<object> onComplete)
	{
		return null;
	}

	public LTDescr setOnComplete(Action<object> onComplete, object onCompleteParam)
	{
		return null;
	}

	public LTDescr setOnCompleteParam(object onCompleteParam)
	{
		return null;
	}

	public LTDescr setOnUpdate(Action<float> onUpdate)
	{
		return null;
	}

	public LTDescr setOnUpdateRatio(Action<float, float> onUpdate)
	{
		return null;
	}

	public LTDescr setOnUpdateObject(Action<float, object> onUpdate)
	{
		return null;
	}

	public LTDescr setOnUpdateVector2(Action<Vector2> onUpdate)
	{
		return null;
	}

	public LTDescr setOnUpdateVector3(Action<Vector3> onUpdate)
	{
		return null;
	}

	public LTDescr setOnUpdateColor(Action<Color> onUpdate)
	{
		return null;
	}

	public LTDescr setOnUpdateColor(Action<Color, object> onUpdate)
	{
		return null;
	}

	public LTDescr setOnUpdate(Action<Color> onUpdate)
	{
		return null;
	}

	public LTDescr setOnUpdate(Action<Color, object> onUpdate)
	{
		return null;
	}

	public LTDescr setOnUpdate(Action<float, object> onUpdate, object onUpdateParam = null)
	{
		return null;
	}

	public LTDescr setOnUpdate(Action<Vector3, object> onUpdate, object onUpdateParam = null)
	{
		return null;
	}

	public LTDescr setOnUpdate(Action<Vector2> onUpdate, object onUpdateParam = null)
	{
		return null;
	}

	public LTDescr setOnUpdate(Action<Vector3> onUpdate, object onUpdateParam = null)
	{
		return null;
	}

	public LTDescr setOnUpdateParam(object onUpdateParam)
	{
		return null;
	}

	public LTDescr setOrientToPath(bool doesOrient)
	{
		return null;
	}

	public LTDescr setOrientToPath2d(bool doesOrient2d)
	{
		return null;
	}

	public LTDescr setRect(LTRect rect)
	{
		return null;
	}

	public LTDescr setRect(Rect rect)
	{
		return null;
	}

	public LTDescr setPath(LTBezierPath path)
	{
		return null;
	}

	public LTDescr setPoint(Vector3 point)
	{
		return null;
	}

	public LTDescr setDestroyOnComplete(bool doesDestroy)
	{
		return null;
	}

	public LTDescr setAudio(object audio)
	{
		return null;
	}

	public LTDescr setOnCompleteOnRepeat(bool isOn)
	{
		return null;
	}

	public LTDescr setOnCompleteOnStart(bool isOn)
	{
		return null;
	}

	public LTDescr setRect(RectTransform rect)
	{
		return null;
	}

	public LTDescr setSprites(Sprite[] sprites)
	{
		return null;
	}

	public LTDescr setFrameRate(float frameRate)
	{
		return null;
	}

	public LTDescr setOnStart(Action onStart)
	{
		return null;
	}

	public LTDescr setDirection(float direction)
	{
		return null;
	}

	public LTDescr setRecursive(bool useRecursion)
	{
		return null;
	}
}
