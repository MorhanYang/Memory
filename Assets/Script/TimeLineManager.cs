using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class TimeLineManager : MonoBehaviour
{
    public float endingtime;
    private PlayableDirector director = null;
    //private TimelineUnit helper = null;
    //private ModelBase_test modelbase

    private float[] timeBlock_1;//存放暂停时间的数组
    private float[] currentTimeBlock;
    private int currentIndex;
    private int maxIndex;//timeline的最大分段数

    private void Awake()
    {
        timeBlock_1 = new float[] { 1.5f, 3.5f,5.0f, 8.5f };//暂停时间
        director = GetComponent<PlayableDirector>();

        
    }
    void Update()
    {
        if(director.time >= endingtime)
        {
            SceneManager.LoadScene(1);


        }
        
    }
}