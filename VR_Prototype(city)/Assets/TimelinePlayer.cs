using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelinePlayer : MonoBehaviour
{

    private PlayableDirector director;
    public GameObject controlPanel;
    public bool isTimelineDone = false;

    void Awake()
    {
        director = GetComponent<PlayableDirector>();
        director.played += Director_Played;
        director.stopped += Director_Stopped;
    }
    void Update() {
        if(director.duration - director.time < 0.2)
            isTimelineDone = true;
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
