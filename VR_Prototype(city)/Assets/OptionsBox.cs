using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsBox : MonoBehaviour
{

    public GameObject canvas;
    public GameObject playerObj;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (playerObj.transform.position.x < -235){
            canvas.SetActive(true);
        }

    }
}