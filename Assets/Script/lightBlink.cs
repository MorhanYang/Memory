using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightBlink : MonoBehaviour
{
    // Start is called before the first frame update
    public int BlinkChanceInt;
    public float blinkTIme;
    private bool flag;

    private int a;

    void Start()
    {
        a = Random.Range(0, 10);
        flag=true;
    }

    // Update is called once per frame
    void Update()
    {
        a = Random.Range(0, 10);
        if (flag&a<=BlinkChanceInt)
        {
            StartCoroutine(Blink());
        }
        
    }

    IEnumerator Blink()
    {
        flag =false; 
         GetComponent<SpriteRenderer>().enabled= true;
         yield return new WaitForSeconds(blinkTIme);
         GetComponent<SpriteRenderer>().enabled= false;
         flag =true;   
    }

}
