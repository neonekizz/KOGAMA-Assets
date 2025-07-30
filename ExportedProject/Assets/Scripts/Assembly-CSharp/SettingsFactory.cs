using MV.WorldObject;
using UGUI.Desktop.Scripts.EditMode.SettingsBoxes;
using UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Camera;
using UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Costume;
using UGUI.Desktop.Scripts.EditMode.SettingsBoxes.CustomGuns;
using UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Doors;
using UGUI.Desktop.Scripts.EditMode.SettingsBoxes.MeleeWeapons;
using UGUI.Desktop.Scripts.EditMode.SettingsBoxes.Vehicles;
using UnityEngine;

public class SettingsFactory : MonoBehaviour
{
	[SerializeField]
	private bool previewSettingsPopup;

	[SerializeField]
	private WorldObjectType worldObjectType;

	[SerializeField]
	private MaterialsController materialsController;

	[SerializeField]
	private PointLightSettings pointLightSettingsPrefab;

	[SerializeField]
	private SmokeSettings smokeSettingsPrefab;

	[SerializeField]
	private KillLimitSettings killLimitSettingsPrefab;

	[SerializeField]
	private CubeGunSettings cubeGunSettingsPrefab;

	[SerializeField]
	private MessageBoxSettings messageBoxSettingsPrefab;

	[SerializeField]
	private SkyboxSettings skyboxSettingsPrefab;

	[SerializeField]
	private RoundCubeSettings roundCubeSettingsPrefab;

	[SerializeField]
	private TimeTriggerSettings timeTriggerSettingsPrefab;

	[SerializeField]
	private ToggleBoxSettings toggleBoxSettingsPrefab;

	[SerializeField]
	private ObjectEnablerSettings objectEnablerPrefab;

	[SerializeField]
	private PulseBoxSettings pulseBoxPrefab;

	[SerializeField]
	private CountingCubeSettings countingCubeSettingsPrefab;

	[SerializeField]
	private RotatorSettings rotatorSettingsPrefab;

	[SerializeField]
	private WindTurbineSettings windTurbineSettingsPrefab;

	[SerializeField]
	private OculusSettings oculusSettingsPrefab;

	[SerializeField]
	private PressurePlateSettings pressurePlateSettingsPrefab;

	[SerializeField]
	private GameCoinChestSettings gameCoinChestSettingsPrefab;

	[SerializeField]
	private WaterBoxSettings waterBoxSettingsPrefab;

	[SerializeField]
	private CameraBoxSettings cameraBoxSettingsPrefab;

	[SerializeField]
	private MovablesSettings movablesSettingsPrefab;

	[SerializeField]
	private HoverCraftSettings hoverCraftSettingsPrefab;

	[SerializeField]
	private JetpackSettings jetpackSettingsPrefab;

	[SerializeField]
	private HamsterWheelSettings hamsterWheelSettingsPrefab;

	[SerializeField]
	private VehicleEnergySettings vehicleEnergySettingsPrefab;

	[SerializeField]
	private DoorSettings doorSettingsPrefab;

	[SerializeField]
	private MeleeWeaponSettings meleeSettingsPrefab;

	[SerializeField]
	private SoundEmitterSettings soundEmitterSettingsPrefab;

	[SerializeField]
	private GlobalSoundEmitterSettings globalSoundEmitterSettingsPrefab;

	[SerializeField]
	private SoundInventoryController soundInventoryControllerPrefab;

	[SerializeField]
	private SoundInventoryController globalSoundInventoryControllerPrefab;

	[SerializeField]
	private LeverSettings leverSettingsPrefab;

	[SerializeField]
	private ShootablePlateSettings shootablePlateSettingsPrefab;

	[SerializeField]
	private CollectTheItemSettings collectTheItemSettingsPrefab;

	[SerializeField]
	private CollectTheItemDropoffSettings collectTheItemDropoffSettingsPrefab;

	[SerializeField]
	private FireSettings fireSettingsPrefab;

	[SerializeField]
	private TriggerCubeSettings triggerCubeSettingsPrefab;

	[SerializeField]
	private TeamEditorSettings teamEditorSettingsPrefab;

	[SerializeField]
	private GamePointSettings gamePointSettingsPrefab;

	[SerializeField]
	private GamePointMinorRewardSettings gamePointMinorRewardSettingsPrefab;

	[SerializeField]
	private GamePointChestSettings gamePointChestSettingsPrefab;

	[SerializeField]
	private SpawnRoleEditorMenu spawnRoleEditorPrefab;

	[SerializeField]
	private RespawnSettings respawnSettingsPrefab;

	[SerializeField]
	private SpawnPointSettings spawnPointSettingsPrefab;

	[SerializeField]
	private LevelRequirementSettings levelRequirementSettingsPrefab;

	[SerializeField]
	private GameCoinRequirementSettings gameCoinRequirementSettingsPrefab;

	[SerializeField]
	private StarsRequirementSettings starsRequirementSettingsPrefab;

	[SerializeField]
	private TeamRequirementSettings teamRequirementSettingsPrefab;

	[SerializeField]
	private GameRankRequirementSettings gameRankRequirementSettingsPrefab;

	[SerializeField]
	private RewardedAdRequirementSettings rewardedAdRequirementSettingsPrefab;

	[SerializeField]
	private CostumeSettings costumeSettingsPrefab;

	[SerializeField]
	private CustomGunSettings customGunSettingsPrefab;

	[SerializeField]
	private ObjectTransparencySettings objectTransparencySettingsPrefab;

	[SerializeField]
	private CubeModelPopup changeScaleSettingsPrefab;

	public void CreateSettingsDialog(int woID)
	{
	}

	public void CreateSettingsDialog(int woID, UseRequirementType requirementType)
	{
	}

	public void CreateSettingsDialog(int woID, WorldObjectType worldObjectType)
	{
	}

	public void CreateSoundsInventory(int woID)
	{
	}

	public void CreateGlobalSoundsInventory(int woID)
	{
	}

	public void CreateGamePointsSettings(int woID)
	{
	}

	public void CreateGamePointsMinorRewardSettings(int woID)
	{
	}

	public void CreateRespawnSetting(int woID)
	{
	}

	public void CreateChangeScaleSettings(int woID)
	{
	}

	private void CreateBlueprintSettings(int woID)
	{
	}

	private void CreateRotatorSettings(int woID)
	{
	}

	private void CreateMovablesSettings(int woID)
	{
	}

	private void CreateEditablePickupItemsSettings(int woID)
	{
	}

	private void OnValidate()
	{
	}
}
