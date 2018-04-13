using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health1A : MonoBehaviour {

    public Button H1A;
    public Slider S1A;

	void Start ()
    {
        Button btn = H1A.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}
	
	void TaskOnClick ()
    {
        S1A.value += 0.1f;
    }
}
