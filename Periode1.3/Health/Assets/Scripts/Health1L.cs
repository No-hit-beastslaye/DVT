using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health1L : MonoBehaviour {

    public Button H1L;
    public Slider S1L;

    void Start()
    {
        Button btn = H1L.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        S1L.value -= 0.1f;
    }
}