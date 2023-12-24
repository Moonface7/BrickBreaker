using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text score;

    void Start()
    {
        score.text = "Puanýnýz: " + GameObject.FindAnyObjectByType<Score>().GetComponent<Score>().GetScore();
    }

    public void mainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
