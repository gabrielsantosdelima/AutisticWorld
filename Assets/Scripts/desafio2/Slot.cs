using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    public int indice;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Objeto.indice == this.indice)
        {
            Objeto.slot = gameObject;
        }
      
    }
    private void OnExitTrigger2D(Collider2D collision)
    {
        Objeto.slot = null;
    }
}
