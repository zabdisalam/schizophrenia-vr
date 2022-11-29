using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCanvas : MonoBehaviour
{
    public GameObject canvas;
    public GameObject playerObj;
    public bool alreadyDone = false;

    void Start(){
        canvas.SetActive(false);
    }

    void Update(){
        
        if ((playerObj.transform.position.x <= -58)){// && (alreadyDone == false)){
            canvas.SetActive(true);
            alreadyDone = true; //Only want to do this once. If the pedestrian finds himself past -58 we don't want the box coming back
        }

        Debug.Log(alreadyDone);
    }
}