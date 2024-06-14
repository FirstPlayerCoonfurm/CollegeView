using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Usercontroller : MonoBehaviour
{
    public GameObject gameObject;
    public bool Up = false;
    public bool Down = false;
    public void Up_up()
    {
        Up = false;
    }
    public void Up_down()
    {
        Up = true;
    }

    public void Down_up()
    {
        Down = false;
    }
    public void Down_down()
    {
        Down= true;
    }

    public void Update()
    {
        if (Up == true)
        {
            gameObject.transform.Translate(Vector3.up * Time.deltaTime);
        }
        else
        {
            Up = false;
        }

        if (Down == true)
        {
            gameObject.transform.Translate(Vector3.down * Time.deltaTime);
        }
        else
        {
            Down = false;
        }
    }
}
