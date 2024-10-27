using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueCount : MonoBehaviour
{
    TMPro.TextMeshProUGUI text;

    void Awake()
    {
        text = GetComponent<TMPro.TextMeshProUGUI>();
    }

    void Update()
    {
        text.text = BlueCollectable.blueCount.ToString();
    }
}
