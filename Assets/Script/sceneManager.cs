using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour,IPointerClickHandler
{
    public int LoadTo;
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("clicked!");
        SceneManager.LoadScene(LoadTo);
    }
}
