using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportRunGuide : MonoBehaviour
{
    public GameObject[] runGuides;

    private TeleportController teleportController;
    public GameObject playerObj = null;
    public GameObject pedestrian = null;

    private int runGuideCounter = 0;

    void Start()
    {
        teleportController = GameObject.Find("RightHand").GetComponent<TeleportController>();
    }

    void Update()
    {
        if ((teleportController.hasTeleported && !pedestrian.activeSelf && runGuideCounter < 6) || (runGuideCounter > 0 && runGuideCounter < 6))
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
