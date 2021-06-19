using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelectController : MonoBehaviour {

	

	public void goToLevel(int levelID){
		if (AplicationController.canAcessLevel (levelID)) {
			AplicationController.currentLevel = levelID;
			UnityEngine.SceneManagement.SceneManager.LoadScene("fase"+levelID);
			
		}
	}

	public void goToLevell(int levelID){
		if (AplicationController.canAcessLevell(levelID)){
			AplicationController.currentLevell = levelID;
			UnityEngine.SceneManagement.SceneManager.LoadScene("fase0" + levelID);
			
		}
	}

}
