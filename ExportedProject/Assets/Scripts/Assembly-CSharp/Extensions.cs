using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

public static class Extensions
{
	private static ObscuredString obscuredString;

	public static string ToSerializeString(this Vector3 vec)
	{
		return null;
	}

	public static Vector3 ToVector3FromSerializeString(this string text)
	{
		return default(Vector3);
	}

	private static float ConvertToSingle(string s)
	{
		return 0f;
	}

	public static void Log<T>(this IEnumerable<T> collection, string prependInfo = null, bool eachEntryNewLine = true)
	{
	}

	public static void LogWarning<T>(this IEnumerable<T> collection, string prependInfo = null, bool eachEntryNewLine = true)
	{
	}

	public static void LogError<T>(this IEnumerable<T> collection, string prependInfo = null, bool eachEntryNewLine = true)
	{
	}

	private static void Log<T>(this IEnumerable<T> collection, Action<string> logFunc, string prependInfo = null, bool eachEntryNewLine = true)
	{
	}

	public static string BuildString<T>(this IEnumerable<T> collection)
	{
		return null;
	}

	public static string BuildString<T>(this IEnumerable<T> collection, bool eachEntryNewLine)
	{
		return null;
	}

	public static string BuildString<T>(this IEnumerable<T> collection, string prependInfo)
	{
		return null;
	}

	public static string BuildString<T>(this IEnumerable<T> collection, string prependInfo, bool eachEntryNewLine)
	{
		return null;
	}

	public static void LogRecursive(this IEnumerable collection, string prependInfo = null, bool eachEntryNewLine = true)
	{
	}

	public static void LogWarningRecursive(this IEnumerable collection, string prependInfo = null, bool eachEntryNewLine = true)
	{
	}

	public static void LogErrorRecursive(this IEnumerable collection, string prependInfo = null, bool eachEntryNewLine = true)
	{
	}

	private static void LogRecursive(this IEnumerable collection, Action<string> logFunc, string prependInfo = null, bool eachEntryNewLine = true)
	{
	}

	public static string BuildStringRecursive(this IEnumerable collection, string prependInfo = null, bool eachEntryNewLine = true)
	{
		return null;
	}

	public static void AppendRecursive(this StringBuilder sb, IEnumerable collection, int depth = 0, bool eachEntryNewLine = true)
	{
	}

	public static void Log<TKey, TValue>(this Dictionary<TKey, TValue> collection, string prependInfo = "")
	{
	}

	private static string GenerateDictionaryString<TKey, TValue>(Dictionary<TKey, TValue> collection, string prependInfo = "")
	{
		return null;
	}

	public static object GetObscuredType(this Dictionary<object, object> hashtable, string key)
	{
		return null;
	}

	public static void SetObscuredType<T>(this Dictionary<object, object> hashtable, string key, T value)
	{
	}

	public static bool ContainsObscuredKey(this Dictionary<object, object> hashtable, string key)
	{
		return false;
	}

	public static bool RemoveObscuredKey(this Dictionary<object, object> hashtable, string key)
	{
		return false;
	}

	public static int GetClampedInt(this Dictionary<object, object> hashtable, string key, int min, int max, int defaultValue)
	{
		return 0;
	}

	public static float GetClampedFloat(this Dictionary<object, object> hashtable, string key, float min, float max, float defaultValue)
	{
		return 0f;
	}

	public static bool GetBool(this Dictionary<object, object> hashtable, string key, bool defaultValue)
	{
		return false;
	}

	public static void ScaleBounds(this GameObject gameObject, float targetSize)
	{
	}

	public static Transform FindChildRecursively(this Transform transform, string child)
	{
		return null;
	}

	public static T GetValueOrDefault<T>(this Dictionary<object, object> hashtable, string key, T defaultValue = default(T))
	{
		return default(T);
	}

	public static V GetTypedValueOrDefault<K, V>(this Dictionary<K, V> hashtable, K key, V defaultValue = default(V))
	{
		return default(V);
	}

	public static Color GetColor(this Dictionary<object, object> hashtable, string colorKey)
	{
		return default(Color);
	}

	public static Color GetColorOrDefault(this Dictionary<object, object> hashtable, string colorKey, Color defaultColor = default(Color))
	{
		return default(Color);
	}

	public static Vector3 GetVector3(this Dictionary<object, object> hashtable, string vectorKey)
	{
		return default(Vector3);
	}

	public static Vector3 GetVector3OrDefault(this Dictionary<object, object> hashtable, string vectorKey, Vector3 defaultValue = default(Vector3))
	{
		return default(Vector3);
	}

	public static void SetColor(this Dictionary<object, object> hashtable, string colorKey, Color color)
	{
	}

	public static string AddSpacesToSentence(this string text)
	{
		return null;
	}
}
