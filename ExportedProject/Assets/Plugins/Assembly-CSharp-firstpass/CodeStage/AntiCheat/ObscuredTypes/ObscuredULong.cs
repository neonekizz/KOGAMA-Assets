using System;
using UnityEngine;

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredULong : IEquatable<ObscuredULong>, IFormattable
	{
		private static ulong cryptoKey;

		[SerializeField]
		private ulong currentCryptoKey;

		[SerializeField]
		private ulong hiddenValue;

		[SerializeField]
		private ulong fakeValue;

		[SerializeField]
		private bool inited;

		private ObscuredULong(ulong value)
		{
			currentCryptoKey = 0uL;
			hiddenValue = 0uL;
			fakeValue = 0uL;
			inited = false;
		}

		public static void SetNewCryptoKey(ulong newKey)
		{
		}

		public static ulong Encrypt(ulong value)
		{
			return 0uL;
		}

		public static ulong Decrypt(ulong value)
		{
			return 0uL;
		}

		public static ulong Encrypt(ulong value, ulong key)
		{
			return 0uL;
		}

		public static ulong Decrypt(ulong value, ulong key)
		{
			return 0uL;
		}

		public void ApplyNewCryptoKey()
		{
		}

		public void RandomizeCryptoKey()
		{
		}

		public ulong GetEncrypted()
		{
			return 0uL;
		}

		public void SetEncrypted(ulong encrypted)
		{
		}

		public ulong GetDecrypted()
		{
			return 0uL;
		}

		private ulong InternalDecrypt()
		{
			return 0uL;
		}

		public static implicit operator ObscuredULong(ulong value)
		{
			return default(ObscuredULong);
		}

		public static implicit operator ulong(ObscuredULong value)
		{
			return 0uL;
		}

		public static ObscuredULong operator ++(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		public static ObscuredULong operator --(ObscuredULong input)
		{
			return default(ObscuredULong);
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(ObscuredULong obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(string format)
		{
			return null;
		}

		public string ToString(IFormatProvider provider)
		{
			return null;
		}

		public string ToString(string format, IFormatProvider provider)
		{
			return null;
		}
	}
}
