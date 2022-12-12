using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappearSlow : MonoBehaviour
{
    // Start is called before the first frame update
    private float co;
    public float changingSpeed=0.005f;
    private float timer;
    void Start()
    {
        //StartCoroutine(show());
        timer =1.0f;

    }

    // Update is called once per frame
    void Update()
    {
        if (timer> 0.0f)
        {
            timer = changingSpeed*Time.deltaTime;
            GetComponent<SpriteRenderer>().color -= new Color(0,0,0,timer);
        }
        
    }
   
}
