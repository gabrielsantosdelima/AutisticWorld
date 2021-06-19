using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AplicationController : MonoBehaviour {

	public static AplicationController instance;
	public static int currentLevel, currentLevell;

	void Start () {

		instance = this;

		DontDestroyOnLoad (gameObject);

		

		if (PlayerPrefs.GetInt("itWasSetup") != 1) {
			PlayerPrefs.SetInt("maxLevelCompleted", 0);
			PlayerPrefs.SetInt("maxLevellCompleted", 0);
			PlayerPrefs.SetInt("coins",300);
			PlayerPrefs.SetInt ("itWasSetup", 1);
		}
		UnityEngine.SceneManagement.SceneManager.LoadScene("Tutorial");
	}
	
	public static bool canAcessLevel(int levelID){
		return PlayerPrefs.GetInt("maxLevelCompleted")>=levelID-1;
	}

	public static void addMaxLevelCompleted(){
		if(AplicationController.currentLevel>PlayerPrefs.GetInt("maxLevelCompleted")){
			PlayerPrefs.SetInt("maxLevelCompleted",AplicationController.currentLevel);
		}
	}

	public static bool canAcessLevell(int levelID)
	{
		return PlayerPrefs.GetInt("maxLevellCompleted") >= levelID - 1;
	}

	public static void addMaxLevellCompleted()
	{
		if (AplicationController.currentLevell > PlayerPrefs.GetInt("maxLevellCompleted")) ;
		{
			PlayerPrefs.SetInt("maxLevellCompleted", AplicationController.currentLevell);
		}
	}

	public static void addCoins(int value)
    {
		int total = value + PlayerPrefs.GetInt("coins");
		PlayerPrefs.SetInt("coins", total);
    }
}
