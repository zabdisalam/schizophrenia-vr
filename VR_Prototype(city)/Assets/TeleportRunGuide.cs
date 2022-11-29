using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportRunGuide : MonoBehaviour
{
    public GameObject runGuides;

    private TeleportController teleportController;
    public GameObject playerObj = null;
    public GameObject pedestrian = null;

    // private int runGuideCounter = 0;

    void Start()
    {
        teleportController = GameObject.Find("RightHand").GetComponent<TeleportController>();
    }

    void Update()
    {
        if (teleportController.hasTeleported && !pedestrian.activeSelf)
        {
            runGuides.SetActive(true);
        }
    }
}
