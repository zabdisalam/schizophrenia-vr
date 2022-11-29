using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideDialogue : MonoBehaviour
{
    public GameObject canvas;
    public GameObject playerObj;
    public bool alreadyDone = false;
    public GameObject cube;

    void Start(){
        canvas.SetActive(false);
        cube.SetActive(false);
    }

    void Update(){
        if ((playerObj.transform.position.x <= -287) && (alreadyDone == false)){
            StartCoroutine(waiter());
            alreadyDone = true;
        }
    }

    IEnumerator waiter() {
        yield return new WaitForSeconds(5);
        canvas.SetActive(true);
    }
}