using System.Runtime.CompilerServices;
using UnityEngine;

namespace RTG
{
	public class ColorTransition
	{
		public enum State
		{
			CompleteFadeIn = 0,
			CompleteFadeOut = 1,
			FadingIn = 2,
			FadingOut = 3,
			Ready = 4
		}

		public delegate void ColorTransitionBeginHandler(ColorTransition colorTransition);

		public delegate void ColorTransitionEndHandler(ColorTransition colorTransition);

		private ColorRef _colorRef;

		private Color _fadeInColor;

		private Color _fadeOutColor;

		private State _state;

		private float _durationInSeconds;

		private float _elapsedTimeInSeconds;

		private bool _isActive;

		public State TransitionState => default(State);

		public Color FadeInColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color FadeOutColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public float DurationInSeconds
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool IsActive => false;

		public event ColorTransitionBeginHandler TransitionBegin
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

		public event ColorTransitionEndHandler TransitionEnd
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

		public ColorTransition(ColorRef colorRef)
		{
		}

		public void BeginFadeIn(bool startFromCurrentColor)
		{
		}

		public void BeginFadeOut(bool startFromCurrentColor)
		{
		}

		public void Update(float elapsedTime)
		{
		}

		private void End()
		{
		}
	}
}
