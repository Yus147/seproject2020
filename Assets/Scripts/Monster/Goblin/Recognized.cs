﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recognized : MonoBehaviour
{
    public bool recognized = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        recognized = true;
    }
}
