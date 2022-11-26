using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelinePlayer : MonoBehaviour
{

    private PlayableDirector director;
    public GameObject controlPanel;
    // public GameObject playerObj = null;
    // private GameObject pedestrian = null;
    // private TeleportController teleportController;

    void Awake()
    {
        // pedestrian = GameObject.Find("Pedestrian");
        // playerObj = GameObject.Find("XR Origin");
        director = GetComponent<PlayableDirector>();
        director.played += Director_Played;
        director.stopped += Director_Stopped;
    }

    private void Director_Played(PlayableDirector obj)
    {
        controlPanel.SetActive(false);
    }

    private void Director_Stopped(PlayableDirector obj)
    {
        controlPanel.SetActive(true);
    }

    public void StartTimeline()
    {
        director.Play();
    }
}