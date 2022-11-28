using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObject : MonoBehaviour
{
    public GameObject canvas;
    public GameObject playerObj;

    void Start(){
        canvas.SetActive(false);
    }

    void Update(){
        Debug.Log(playerObj.transform.position.x);
        if (playerObj.transform.position.x <= -58){
            canvas.SetActive(true);
        }
        
    }
}
