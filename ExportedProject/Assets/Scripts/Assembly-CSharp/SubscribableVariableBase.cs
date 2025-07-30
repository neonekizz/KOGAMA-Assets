using System;
using System.Runtime.CompilerServices;

public abstract class SubscribableVariableBase<T>
{
	protected T value;

	public T Value => default(T);

	public event Action<T> OnChange
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	protected SubscribableVariableBase(T value)
	{
	}

	public static implicit operator T(SubscribableVariableBase<T> s)
	{
		return default(T);
	}

	public bool Equals(SubscribableVariableBase<T> other)
	{
		return false;
	}

	public static bool operator ==(SubscribableVariableBase<T> a, SubscribableVariableBase<T> b)
	{
		return false;
	}

	public static bool operator !=(SubscribableVariableBase<T> a, SubscribableVariableBase<T> b)
	{
		return false;
	}

	public static bool operator !=(SubscribableVariableBase<T> a, T b)
	{
		return false;
	}

	public static bool operator ==(SubscribableVariableBase<T> a, T b)
	{
		return false;
	}

	public static bool operator !=(T b, SubscribableVariableBase<T> a)
	{
		return false;
	}

	public static bool operator ==(T b, SubscribableVariableBase<T> a)
	{
		return false;
	}

	protected void Notify()
	{
	}
}
