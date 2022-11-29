using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideDialogue : MonoBehaviour
{
    public GameObject canvas;
    public GameObject playerObj;
    public bool alreadyDone = false;

    void Start(){
        canvas.SetActive(false);
    }

    void Update(){
        // Debug.Log(playerObj.transform.position.x);
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