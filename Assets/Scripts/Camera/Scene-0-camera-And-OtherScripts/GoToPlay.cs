﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToPlay : MonoBehaviour
{
    public GameObject canvasOut;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            Time.timeScale = 0f;
            canvasOut.SetActive(true);
        }
    }
}
