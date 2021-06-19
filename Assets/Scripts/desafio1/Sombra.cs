using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sombra: MonoBehaviour {

	public int indice;

	private void OnTriggerEnter2D(Collider2D collision){
		//Debug.Log("ENTRANDO");
		if(Imagem.indice == this.indice){
			Imagem.sombra = gameObject;
		}
	}
	private void OnExitTrigger2D(Collider2D collision){
		//Debug.Log("SAINDO");
		Imagem.sombra = null;
	}
}
