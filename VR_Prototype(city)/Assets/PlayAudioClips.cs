using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudioClips : MonoBehaviour
{

    public AudioSource audio;
    public AudioClip clip;
    public GameObject canvas;

    public void playButton(){
        audio.PlayOneShot(clip);
        canvas.transform.localScale = new Vector3(0, 0, 0);
    }
}
