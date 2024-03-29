﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarHandler : MonoBehaviour
{
    public GameObject healthCanvas;
    public Image healthBar;

    void LateUpdate()
    {
        if (healthBar.fillAmount < 1 && healthBar.fillAmount > 0)
        {
            healthCanvas.SetActive(true);
            healthCanvas.transform.LookAt(Camera.main.transform);
            healthCanvas.transform.Rotate(0, 180, 0);
        }
        else
        {
            healthCanvas.SetActive(false);
        }
    }
}
