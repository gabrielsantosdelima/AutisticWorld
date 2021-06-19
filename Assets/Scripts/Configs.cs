using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Configs : MonoBehaviour
{
    public int i;

   public void GoToLevelSelector()
    {
        if(i == 1){
            UnityEngine.SceneManagement.SceneManager.LoadScene("LevelSelector");
        }else{
            UnityEngine.SceneManagement.SceneManager.LoadScene("LevelSelector2");
        }
    }
}
