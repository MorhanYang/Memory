using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightBlink : MonoBehaviour
{
    // Start is called before the first frame update
    private bool flag;

    void Start()
    {
        int a = Random.Range(0, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void blink()
    {
       // GetComponent<SpriteRenderer>().enable= true;

    }
}
