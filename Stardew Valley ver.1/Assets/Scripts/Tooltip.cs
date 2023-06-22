using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tooltip : MonoBehaviour
{
    public TextMeshProUGUI nameTxt;
    public TextMeshProUGUI descriptionTxt;

    public void SetupTooltip(string name, string des)
    {
        nameTxt.text = name;
        descriptionTxt.text = des;
    }

    private void Update()
    {
        transform.position = Input.mousePosition;
    }

}
