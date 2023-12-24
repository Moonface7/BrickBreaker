using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMusic : MonoBehaviour
{
    static bool isMusicPlay;
    void Start()
    {
        if (!isMusicPlay)
        {
            GameObject.DontDestroyOnLoad(this.gameObject);
            isMusicPlay = true;
        }else
        {
            Destroy(gameObject);
        }
    }
}
