using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public void chamarDesafio(int indice)
    {
        if (indice == 1){
            UnityEngine.SceneManagement.SceneManager.LoadScene("levelSelector");
        }else{
            UnityEngine.SceneManagement.SceneManager.LoadScene("levelSelector2");
        }
    }
    public void goHome() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Tutorial");
    }
}
