using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarraControl : MonoBehaviour
{
    public GameObject NarraPanel;
    public GameObject DiaPanel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Na()
    {
        NarraPanel.SetActive(true);
        DiaPanel.SetActive(false);
    }
    public void Dia()
    {
        NarraPanel.SetActive(false);
        DiaPanel.SetActive(true);
    }
}
