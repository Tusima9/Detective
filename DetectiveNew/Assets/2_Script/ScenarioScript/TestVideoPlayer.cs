using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class TestVideoPlayer : MonoBehaviour
{

    public VideoClip clip;
    public RawImage renderer;

    private void Start()
    {
        VideoPlayer video = gameObject.AddComponent<VideoPlayer>();
        video.source = VideoSource.VideoClip;
        video.clip = clip;
        video.isLooping = true;

        RenderTexture Tex = new RenderTexture(Mathf.RoundToInt(clip.width), Mathf.RoundToInt(clip.height), 0);
        video.targetTexture = Tex;

        renderer.texture = Tex;


        video.SetDirectAudioMute(0, true);


    }
}
