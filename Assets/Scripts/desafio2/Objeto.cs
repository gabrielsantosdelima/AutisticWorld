using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Objeto : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

    Transform t;
    public static GameObject slot;
    public static int indice;
    public int i;
    public GameObject obj;
    Vector3 posInicial;

    public void OnBeginDrag(PointerEventData eventData){
        t = GetComponent<Transform>();
        slot = null;
        posInicial = t.position;
        indice = i;
    }

    public void OnDrag(PointerEventData eventData){
        t.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData){
        if (slot){
            t.position = slot.transform.position;
            AplicationController.addMaxLevellCompleted();
            AplicationController.addCoins(25);
            // Debug.Log(PlayerPrefs.GetInt("coins"));
            Debug.Log(PlayerPrefs.GetInt("maxLevellCompleted"));
            
            obj.SetActive(true);
        }else{
            t.position = posInicial;
        }
    }
}
