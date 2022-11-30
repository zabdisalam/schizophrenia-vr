using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideDialogue : MonoBehaviour
{
    public GameObject canvas;
    public GameObject playerObj;
    public bool alreadyDone = false;
    public GameObject cube;
    public GameObject instruction0;
    public GameObject instruction1;
    public GameObject instruction2;
    public GameObject instruction3;
    public GameObject instruction4;
    public GameObject instruction5;
    public GameObject instruction6;
    public GameObject instruction7;
    public GameObject instruction8;

    void Start(){
        canvas.SetActive(false);
        cube.SetActive(false);
        instruction0.SetActive(true);
        instruction1.SetActive(true);
        instruction2.SetActive(false);
        instruction3.SetActive(false);
        instruction4.SetActive(false);
        instruction5.SetActive(false);
        instruction6.SetActive(false);
        instruction7.SetActive(false);
        instruction8.SetActive(false);
    }

    void Update(){
        if ((playerObj.transform.position.x <= -287) && (alreadyDone == false)){
            StartCoroutine(waiter());
            instruction0.SetActive(false);
            instruction1.SetActive(false);
            alreadyDone = true;
        }
    }

    IEnumerator waiter() {
        yield return new WaitForSeconds(5);
        canvas.SetActive(true);
    }
}

