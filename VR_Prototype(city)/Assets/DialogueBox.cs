using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System;

public class DialogueBox : MonoBehaviour
{
    // Start is called before the first frame update

    public AudioSource source;
    public AudioClip clip;
    public float time;
    private float timeStore;
    public GameObject playerObj = null;
    private GameObject pedestrian = null;
    public GameObject teleportReticle = null;

    void Start()
    {
        if (playerObj == null)
        {
            playerObj = GameObject.Find("XR Origin");
            teleportReticle = GameObject.Find("SimpleTeleportTarget_circle_3");
            pedestrian = GameObject.Find("Pedestrian");
            pedestrian.SetActive(false);

        }
    }

    // Update is called once per frame
    void Update()
    {   
        source.PlayOneShot(clip);

        DateTimeOffset now = DateTimeOffset.UtcNow;
        long unixTimeMilliseconds = now.ToUnixTimeMilliseconds();

        while((((DateTimeOffset.UtcNow).ToUnixTimeMilliseconds()) - unixTimeMilliseconds) < (800/(1.0f / Time.deltaTime))){
            //do nothing
        }
        
        Debug.Log("Player Position: X = " + playerObj.transform.position.x + " --- Y = " + playerObj.transform.position.y + " --- Z = " +
         playerObj.transform.position.z);

        if ((playerObj.transform.position.x >= -290.4 && -288.4 >= playerObj.transform.position.x) && (playerObj.transform.position.y >= 68.86 && 70.86 >= playerObj.transform.position.y))
        {  
            // DateTimeOffset now = DateTimeOffset.UtcNow;
            // long unixTimeMilliseconds = now.ToUnixTimeMilliseconds();

            // while((((DateTimeOffset.UtcNow).ToUnixTimeMilliseconds()) - unixTimeMilliseconds) < (800/(1.0f / Time.deltaTime))){
            //     //do nothing
            // }
            source.PlayOneShot(clip);

        }
    }
}
