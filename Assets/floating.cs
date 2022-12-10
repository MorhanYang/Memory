using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floating : MonoBehaviour
{
   //public AnimationCurve floatingCurve;
   public float animationSpeed;

   
    // Start is called before the first frame update

    private float timer;
    private Vector3 pos;
    private bool status;
    void Start()
    {
        timer=0;
        pos = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer<2.0f& timer>=0.0f)
        {
            this.transform.position= pos+Vector3.up*timer;
            timer += Time.deltaTime*animationSpeed;
        }
        else if (timer>= 2.0f) timer=0.0f;
        Debug.Log(timer);
    }

   
}
