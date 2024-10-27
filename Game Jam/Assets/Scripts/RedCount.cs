using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCount : MonoBehaviour
{
    TMPro.TextMeshProUGUI text;

    private void Awake()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
    }

    private void Update()
    {
        text.text =  RedCollectable.redCount.ToString();
    }
}
