using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelinePlayer : MonoBehaviour
{

    private PlayableDirector director;
    public bool isTimelineDone = false;

    void Awake()
    {
        director = GetComponent<PlayableDirector>();
    }
    void Update() {
        if(director.duration - director.time < 0.2)
            isTimelineDone = true;
    }
    public void StartTimeline()
    {
        director.Play();

    }
}
