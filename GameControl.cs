using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameControl : MonoBehaviour
{
    GameObject Score;
    public void nextScene()
    {
        SceneManager.LoadScene("levels");
    }
}
