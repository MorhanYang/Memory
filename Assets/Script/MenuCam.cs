using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuCam : MonoBehaviour
{
    private float movingH;
    private Vector3 YValue;
    private Vector3 mPrevPos;

    public float movingSpeed;
    public float YMax;
    public float YMin;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
if (Input.GetAxis("Mouse ScrollWheel") != 0)
　　{

　　　　Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 12.0f, 15.0f);
　　　　Camera.main.fieldOfView = Camera.main.fieldOfView - Input.GetAxis("Mouse ScrollWheel") * movingSpeed;

　　}


    if (Input.GetMouseButton(0))
    {
        transform.Translate(Vector3.down * Input.GetAxis("Mouse Y") * movingSpeed);
        transform.position=new Vector3(transform.position.x,Mathf.Clamp(transform.position.y,YMin,YMax),transform.position.z);
    }
        
    }

    


}
