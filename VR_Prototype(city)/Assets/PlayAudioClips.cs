using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class PlayAudioClips : MonoBehaviour
{

    public new AudioSource audio;
    public AudioClip clip;
    public GameObject canvas;
    public GameObject pedestrian;
    public GameObject cube;

    public void playButton(){
        audio.PlayOneShot(clip);
        canvas.transform.localScale = new Vector3(0, 0, 0);
        cube.SetActive(true);
        StartCoroutine(waiter());
    }

    IEnumerator waiter() {
        yield return new WaitForSeconds(35);
        pedestrian.SetActive(false);
    }
}