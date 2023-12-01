using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryController : MonoBehaviour
{
    public GameObject panel;
    public GameObject toolbarPanel;
    public bool isPause = false;

    private void Awake()
    {
        panel.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            panel.SetActive(!panel.activeInHierarchy);
            toolbarPanel.SetActive(!toolbarPanel.activeInHierarchy);

            if (isPause == false)
            {
                Time.timeScale = 0f;
                isPause = true;
                return;
            }
            if (isPause == true)
            {
                Time.timeScale = 1f;
                isPause = false;
                return;
            }
        }
    }
}
