using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UITimer : MonoBehaviour
{
    public TextMeshProUGUI minsUI;
    public TextMeshProUGUI secsUI;
    public float sec = 0;
    public int min = 0;

    public void Update()
    {
        sec = sec + Time.deltaTime;

        if (sec >= 60)
        {
            min = min + 1;
            sec = sec - 60;
        }

        minsUI.text = min.ToString();
        secsUI.text = ((int)sec).ToString();
    }
}
