using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioTesting : MonoBehaviour
{
    public AudioMixer audioMixer;
    public float volume, pitch;
    public AudioClip[] clips;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            AudioManager.instance.PlaySFX(clips[Random.Range(0, clips.Length)], volume, pitch);
        }
    }
}
