using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    

     void Awake()
    {
     if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }   
     else
        {
            DestroyImmediate(gameObject);
        }
    }
    public void PlaySFX(AudioClip effect, float volume =1f, float pitch=1f)
    {
        AudioSource source = CreateNewSource(string.Format("SFX[0]", effect.name));
        source.clip = effect;
        source.volume = volume;
        source.pitch = pitch;
        source.Play();

        Destroy(source.gameObject, effect.length);
    }
    public AudioSource CreateNewSource( string _name)
    {
        AudioSource newSource = new GameObject(_name).AddComponent<AudioSource>();
        newSource.transform.SetParent(instance.transform);
        return newSource;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
