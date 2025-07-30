namespace RTG
{
	public class RTInputDevice : MonoSingleton<RTInputDevice>
	{
		private IInputDevice _inputDevice;

		public IInputDevice Device => null;

		public InputDeviceType DeviceType => default(InputDeviceType);

		public void Update_SystemCall()
		{
		}

		private void Awake()
		{
		}
	}
}
