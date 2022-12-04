using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangScanColor : MonoBehaviour
{
    public int lyingChance;
    private Color co;
    public GameObject scanPanel;
    // Start is called before the first frame update
    void Start()
    {
        co=this.GetComponent<Image>().color;
    }

    // Update is called once per frame
    void Update()
    {
        co.r=lyingChance/100.0f;
        this.GetComponent<Image>().color = co;
    }

    public void ChangeLyingTo(int lie)
    {
        lyingChance=lie;
        scanPanel.SetActive(false);
        Debug.Log ("ChangingPage");
    }

    public void ChangeScan()
    {
        scanPanel.SetActive(!scanPanel.activeSelf);
    }

}
