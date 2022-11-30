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
    public GameObject instruction2;
    public GameObject instruction3;
    public GameObject instruction4;
    public GameObject instruction5;
    public GameObject instruction6;
    public GameObject instruction7;
    public GameObject instruction8;

    public void playButton(){
        audio.PlayOneShot(clip);
        instruction2.SetActive(true);
        canvas.transform.localScale = new Vector3(0, 0, 0);
        cube.SetActive(true);
        StartCoroutine(waiter());
    }

    IEnumerator waiter() {
        yield return new WaitForSeconds(23.3f);
        instruction2.SetActive(false);
        instruction3.SetActive(true);
        yield return new WaitForSeconds(11.7f);
        instruction3.SetActive(false);
        pedestrian.SetActive(false);
        instruction4.SetActive(true);
        instruction5.SetActive(true);
        instruction6.SetActive(true);
        instruction7.SetActive(true);
        instruction8.SetActive(true);
    }
}