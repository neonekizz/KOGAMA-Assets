using UnityEngine;

namespace RTG
{
	public class SphereTreeNode<T>
	{
		private SphereTreeNode<T> _stackTop;

		private SphereTreeNode<T> _stackPrevious;

		private Sphere _sphere;

		private T _data;

		private SphereTreeNode<T> _parent;

		private SphereTreeNode<T>[] _children;

		private int _numChildren;

		public SphereTreeNode<T>[] Children => null;

		public int NumChildren => 0;

		public bool IsLeaf => false;

		public Sphere Sphere
		{
			get
			{
				return default(Sphere);
			}
			set
			{
			}
		}

		public Vector3 Center
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public float Radius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public SphereTreeNode<T> Parent => null;

		public T Data
		{
			get
			{
				return default(T);
			}
			set
			{
			}
		}

		public SphereTreeNode<T> StackTop => null;

		public SphereTreeNode()
		{
		}

		public SphereTreeNode(T data, Sphere sphere)
		{
		}

		public void StackPush(SphereTreeNode<T> node)
		{
		}

		public SphereTreeNode<T> StackPop()
		{
			return null;
		}

		public bool IsOutsideParent()
		{
			return false;
		}

		public SphereTreeNode<T> ClosestChild(SphereTreeNode<T> node)
		{
			return null;
		}

		public void SetParent(SphereTreeNode<T> newParent)
		{
		}

		public void EncapsulateChildrenBottomUp()
		{
		}

		public void DebugDraw()
		{
		}
	}
}
