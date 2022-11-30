using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckPedestrianGone : MonoBehaviour
{

    public GameObject pedestrian;
    public GameObject endReticle;
    public GameObject XROrigin;
    public AudioClip clip;
    public new AudioSource audio;
    public GameObject cube;
    public bool alreadyDone = false;

    // Update is called once per frame
    void Update()
    {
        if ((int)XROrigin.transform.position.x == (int)endReticle.transform.position.x
            && (int)XROrigin.transform.position.y == (int)endReticle.transform.position.y 
            && (int)XROrigin.transform.position.z == (int)endReticle.transform.position.z)
        {
            XROrigin.SetActive(false);
            SceneManager.LoadScene("Finale");
        }
        if (!pedestrian.activeInHierarchy && cube.activeInHierarchy && !alreadyDone)
        {
            audio.PlayOneShot(clip);
            StartCoroutine(waiter());
            alreadyDone = true;
        }
        
    }
    IEnumerator waiter()
    {
        RenderSettings.fog = true;
        yield return new WaitForSeconds(64.73f);
        XROrigin.SetActive(false);
        SceneManager.LoadScene("Finale");
    }
}
