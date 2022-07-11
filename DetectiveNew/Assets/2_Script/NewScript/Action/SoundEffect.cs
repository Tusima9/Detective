using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SE
{
public class SoundEffect : MonoBehaviour
{
    AudioSource _AudioSource;
    public AudioClip sound1;
    void Start()
    {
        _AudioSource = GetComponent<AudioSource>();
    }
    public void Clap()
	{
        _AudioSource.pitch = 1.5f;
        _AudioSource.PlayOneShot(sound1);
	}
    public void Pitchdown()
	{
        _AudioSource.pitch = 1f;
        _AudioSource.PlayOneShot(sound1);
    }
}

}
