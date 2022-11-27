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
        
        if (playerObj.transform.position.x <= 45){
            canvas.SetActive(true);
        }
        
    }
}
