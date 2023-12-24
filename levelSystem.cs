using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class levelSystem : MonoBehaviour
{
    public Button[] levels;
    void Start()
    {
        for (int i = 0; i < levels.Length; i++)
        {
            string levelName = levels[i].name;
            //print (levels [i]);
            if (PlayerPrefs.GetInt(levelName) == 1)
                levels[i].interactable = true;
            else
                levels[i].interactable = false;
        }
        levels[0].interactable = true;
    }

}
