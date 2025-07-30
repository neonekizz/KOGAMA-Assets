using System;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CustomItemAudioPlayer : MonoBehaviour
{
	[Serializable]
	private struct CustomItemAudioClip
	{
		public AudioClip clip;

		public float pitchVariation;

		public bool isLooped;
	}

	[SerializeField]
	private CustomItemAudioClip[] audioClips;

	private AudioSource audioSource;

	private float baseVolume;

	private string[] clipNames;

	private int index;

	public bool IsPlaying => false;

	public float ClipLength => 0f;

	public void Initialize(string[] clipNames)
	{
	}

	private void SetAudioSourceSettings(int index)
	{
	}

	public void PlayClip(int index, bool useAudioManager = true, Vector3 position = default(Vector3))
	{
	}

	public void PlayClipFraction(int index, float length)
	{
	}

	public void Stop()
	{
	}

	public void SetVolume(float volume)
	{
	}

	public void SetPitch(float pitch)
	{
	}

	public bool IsClipLooped(int index)
	{
		return false;
	}
}
