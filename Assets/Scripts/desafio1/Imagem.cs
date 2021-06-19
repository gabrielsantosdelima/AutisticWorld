using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Imagem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	Transform t;
	Vector3 posicaoInicial;
	public static GameObject sombra;
	public static int indice;
	public GameObject img;
	public int i,total;
	private static int[] acertou;

	public void Start(){
		acertou = new int[15];
	}


	public void OnBeginDrag(PointerEventData eventData){
		t = GetComponent<Transform>();
		sombra = null;
		indice = i;	
		posicaoInicial = t.position;
	}


	public void OnDrag(PointerEventData eventData){
		if (acertou [indice] == 0) {
			t.position = eventData.position;
		}
	}


	public void OnEndDrag(PointerEventData eventData){

		if(sombra){
			t.position = sombra.transform.position;
			acertou [indice] = 1;
			int cont = 0;
			for (int x = 0; x < total; x++) {

				if (acertou [x] == 1) 
					cont++;
				
			}

			if (cont == total) {
				img.SetActive(true);
				AplicationController.addMaxLevelCompleted();
				AplicationController.addCoins(25);
				// Debug.Log(PlayerPrefs.GetInt("coins"));
			}

		}else{
			t.position = posicaoInicial;
		}
	}
}
