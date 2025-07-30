using MV.Common;
using UnityEngine;
using UnityEngine.UI;

internal class LocationIndicator : MonoBehaviour
{
	private static readonly Vector3 AvatarPosOffset;

	private const float ZThreshold = 0.75f;

	[SerializeField]
	private LayoutGroup layoutGroup;

	[SerializeField]
	private RectTransform textRectTransform;

	[SerializeField]
	private Text nameText;

	[SerializeField]
	private Text ownershipText;

	[SerializeField]
	private Text distanceText;

	[SerializeField]
	private RectTransform arrow;

	private MVPlayer player;

	private MVWorldObjectClient avatar;

	private RectTransform rectTransform;

	private float width;

	private float height;

	private Vector2 Padding => default(Vector2);

	private Vector2 Min => default(Vector2);

	private Vector2 Max => default(Vector2);

	public void Awake()
	{
	}

	public void Initialize(MVPlayer player)
	{
	}

	public void SetOwnership(PlanetOwnershipType ownershipType)
	{
	}

	private void SetTextRectSize()
	{
	}

	private void Update()
	{
	}

	private Vector3 GetAvatarScreenPoint(Vector3 avatarPos, float distance)
	{
		return default(Vector3);
	}

	private Vector3 FlipScreenPoint(Vector3 screenPoint)
	{
		return default(Vector3);
	}

	private Vector3 CompensateSideTargetAccuracy(Vector3 screenPoint, float sideMeasurement)
	{
		return default(Vector3);
	}

	private void SetVisibility(bool isVisible)
	{
	}

	private bool SetIndicatorPosition(Vector3 screenPoint)
	{
		return false;
	}

	private void SetArrowVisibilityAndRotation(Vector3 screenPoint)
	{
	}

	private void SetAlignments(Vector3 screenPoint)
	{
	}

	private void SetDistanceText(float distance)
	{
	}
}
