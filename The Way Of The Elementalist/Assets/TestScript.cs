﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    //
    public string startText;
    public string updateText;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(startText);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(updateText);
    }
}
