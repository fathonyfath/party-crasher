﻿using UnityEngine;
using System.Collections;

public class Persistent : MonoBehaviour
{

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.Save();
    }
}
