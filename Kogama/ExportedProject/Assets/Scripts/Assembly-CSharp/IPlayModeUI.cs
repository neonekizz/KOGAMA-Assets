public interface IPlayModeUI
{
	bool IsInPauseMenu { get; set; }

	bool IsInLobby { get; set; }

	bool IsDying { get; set; }

	void ShowEUseIcon(ShowUseOption option, int woId = 0);

	void HideEUseIcon();

	IGUICrossHair GetCrossHair();
}
