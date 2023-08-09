using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainControl : MonoBehaviour
{
    public static MainControl _ins;

    private GameObject[] allPages;

    void Awake()
    {
        _ins = this;
        allPages = GameObject.FindGameObjectsWithTag("UI_pages");
        // allPages[UI_all]
    }
    private void Start()
    {
        switchUIPages("UI_MainMenu");
    }

    public void switchUIPages(string pageName)
    {
        Debug.Log(pageName);
        foreach (GameObject page in allPages)
        {
            if(pageName == page.name)
            {
                page.GetComponent<Canvas>().enabled = true;
            }
            else
            {
                page.GetComponent<Canvas>().enabled = false;
            }
        }
    }
}
