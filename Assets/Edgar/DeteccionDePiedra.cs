using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeteccionDePiedra : MonoBehaviour
{
    /*public GameObject camaraPrincipal;
    public GameObject camaraPiedra;*/
    
    
    private Transform _posInicial;
    private Transform paloCatapulta;
    // Start is called before the first frame update
    void Start()
    {
       // _posInicial = this.gameObject.transform;
    }

    void Update()
    {
   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag== "material")
        {
            Debug.Log("entro");
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "material")
        {
            /*camaraPrincipal.SetActive(false);
            camaraPiedra.SetActive(true);*/
            Debug.Log("ya se fue");
            StartCoroutine(VolverAposicion());
        }
    }

    public IEnumerator VolverAposicion() 
    {
        Debug.Log("inicia conteo");
        yield return new WaitForSeconds(4);
        Debug.Log("se regresa a la posicion normal");
        gameObject.transform.position = Vector3.zero;
        gameObject.transform.rotation = Quaternion.identity;
        
    }
}
