using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health2L : MonoBehaviour
{

    public int life = 4;

    public Button H2L;
    public Button H2A;
    public GameObject I1;
    public GameObject I2;
    public GameObject I3;


    void Start()
    {
        Button btn1 = H2L.GetComponent<Button>();
        btn1.onClick.AddListener(TaskOnClick);

        Button btn2 = H2A.GetComponent<Button>();
        btn2.onClick.AddListener(TaskClickOn);
    }

    void TaskOnClick()
    {
        life--;
        Removelife();
    }

    void TaskClickOn()
    {
        life++;
        Addlife();
    }

    public void Removelife()
    {
        if (life == 3)
        {
            I3.SetActive(false);
            life = 2;
        }

        else if (life == 2)
        {
            I2.SetActive(false);
            life = 1;
        }

        else if (life == 1 || life == -1)
        {
            I1.SetActive(false);
            life = 0;
        }
    }

    public void Addlife()
    {
        if (life == 1)
        {
            I1.SetActive(true);
            life = 2;
        }

        else if (life == 2)
        {
            I2.SetActive(true);
            life = 3;
        }

        else if (life == 3 || life == 5)
        {
            I3.SetActive(true);
            life = 4;
        }
    }
}