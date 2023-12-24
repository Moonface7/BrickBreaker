using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{

    public void nextScene(string levelName)
    {
        Block.totalBlockCount = 0;
        GameObject.FindAnyObjectByType<Score>().GetComponent<Score>().ResetScore();
        SceneManager.LoadScene(levelName);
    }
}
