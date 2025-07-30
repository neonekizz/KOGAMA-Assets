using System;
using System.Collections.Generic;
using UnityEngine;

namespace RTG
{
	[Serializable]
	public class Hotkeys
	{
		private static List<KeyCode> _availableKeys;

		private static List<string> _availableKeyNames;

		private const int _maxNumberOfKeys = 2;

		[SerializeField]
		private bool _isEnabled;

		[SerializeField]
		private KeyCode _key;

		[SerializeField]
		private bool _lCtrl;

		[SerializeField]
		private bool _lCmd;

		[SerializeField]
		private bool _lAlt;

		[SerializeField]
		private bool _lShift;

		[SerializeField]
		private bool _useStrictModifierCheck;

		[SerializeField]
		private bool _lMouseBtn;

		[SerializeField]
		private bool _rMouseBtn;

		[SerializeField]
		private bool _mMouseBtn;

		[SerializeField]
		private bool _useStrictMouseCheck;

		[SerializeField]
		private string _name;

		[NonSerialized]
		private List<Hotkeys> _potentialOverlaps;

		[SerializeField]
		private HotkeysStaticData _staticData;

		public static List<KeyCode> AvailableKeys => null;

		public static List<string> AvailableKeyNames => null;

		public bool IsEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string Name => null;

		public KeyCode Key
		{
			get
			{
				return default(KeyCode);
			}
			set
			{
			}
		}

		public bool LCtrl
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool LCmd
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool LAlt
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool LShift
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool LMouseButton
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool RMouseButton
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool MMouseButton
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseStrictMouseCheck
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UseStrictModifierCheck
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		static Hotkeys()
		{
		}

		public Hotkeys(string name)
		{
		}

		public Hotkeys(string name, HotkeysStaticData staticData)
		{
		}

		public static void EstablishPotentialOverlaps(List<Hotkeys> hotkeysCollection)
		{
		}

		public int GetNumModifiers()
		{
			return 0;
		}

		public int GetNumMouseButtons()
		{
			return 0;
		}

		public List<MouseButton> GetAllUsedMouseButtons()
		{
			return null;
		}

		public bool UsesMouseButtons(List<MouseButton> buttons)
		{
			return false;
		}

		public List<KeyCode> GetAllUsedModifiers()
		{
			return null;
		}

		public bool UsesModifiers(List<KeyCode> modifiers)
		{
			return false;
		}

		public void AddPotentialOverlap(Hotkeys hotkeys)
		{
		}

		public bool ContainsPotentialOverlap(Hotkeys hotkeys)
		{
			return false;
		}

		public bool IsOverlappedBy(Hotkeys hotkeys)
		{
			return false;
		}

		public bool IsActive(bool checkForOverlaps = true)
		{
			return false;
		}

		public bool IsActiveInFrame(bool checkForOverlaps = true)
		{
			return false;
		}

		public bool HasNoKeys()
		{
			return false;
		}

		public bool HasNoModifiers()
		{
			return false;
		}

		public bool HasNoMouseButtons()
		{
			return false;
		}

		public bool IsEmpty()
		{
			return false;
		}

		private bool IsAnyModifierKeyPressed()
		{
			return false;
		}

		private bool IsAnyMouseButtonPressed()
		{
			return false;
		}
	}
}
