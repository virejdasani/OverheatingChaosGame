using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{

    public static TextMeshProUGUI text;
    public static float time;

    // Start is called before the first frame update
    void Start()
    {
        time = 0.000f;
        text = GetComponent<TextMeshProUGUI>();

    }

    // Update is called once per frame
    void Update()
    {
        text.text = "time: " + time.ToString();
        time ++;
    }
}
