using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piedra : MonoBehaviour
{
   
    public Camera camP;


    private void Start()
    {
        

        
    }

    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "suelo")
        {
            
            Globals.estaEnSuelo = true;
            Debug.Log("ya esta en el suelo");
            StartCoroutine(ActivarCamaraPrincipal());
            
            
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "catapulta")
        {
            General.hayPiedra = true;
            camP.enabled = true;
            Globals.activarBTNpiedra = false;

        }
    }

    IEnumerator ActivarCamaraPrincipal()
    {
        
        camP.enabled = true;
        yield return new WaitForSeconds(1);
        camP.enabled = false;
        Globals.seGeneroPiedra = 0;
        Globals.estaEnSuelo = false;
        Globals.activarBTNpiedra = true;
        Globals.seApretoBoton = false;
        yield return new WaitForSeconds(0.2f);
        Destroy(this.gameObject);
        
       



    }
}
