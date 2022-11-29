using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportRunGuide : MonoBehaviour
{
    public GameObject[] runGuides;

    private TeleportController teleportController;
    private GameObject playerObj = null;
    private GameObject pedestrian = null;

    private int runGuideCounter = 0;

    void Start()
    {
        if (playerObj == null)
        {
            teleportController = GameObject.Find("RightHand").GetComponent<TeleportController>();
            playerObj = GameObject.Find("XR Origin");
            pedestrian = GameObject.Find("Remy (1)");
        }
    }

    void Update()
    {
        Debug.Log("hasTeleported: " +teleportController.hasTeleported + "\nPedestrian is Activated: " + pedestrian.activeSelf);
        if (teleportController.hasTeleported && !pedestrian.activeSelf && runGuideCounter <= 6)
        {
            runGuides[runGuideCounter].SetActive(true);

            if ((int)playerObj.transform.position.x == (int)runGuides[runGuideCounter].transform.position.x
                && (int)playerObj.transform.position.y == (int)runGuides[runGuideCounter].transform.position.y)
            {
                runGuides[runGuideCounter].SetActive(false);
                runGuideCounter += 1;
            }
        }
    }
}
