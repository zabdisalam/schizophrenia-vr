using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPedestrianGone : MonoBehaviour
{

    public GameObject pedestrian;
    public AudioClip clip;
    public new AudioSource audio;
    public GameObject cube;
    public bool alreadyDone = false;

    // Update is called once per frame
    void Update()
    {
        if (!pedestrian.activeInHierarchy && cube.activeInHierarchy && !alreadyDone){
            audio.PlayOneShot(clip);
            StartCoroutine(waiter());
            alreadyDone = true;
        }   
    }
        IEnumerator waiter() {
        RenderSettings.fog = true;
        yield return new WaitForSeconds(64.73f);
        SceneManager.LoadScene("Finale");
    }
}
