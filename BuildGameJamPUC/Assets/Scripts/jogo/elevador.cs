using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevador : MonoBehaviour
{
    public GameObject[] objetos_iluminados;
    public Material material_normal, material_emission;
    public bool colidindo = false;
    public plataforma plat;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("entrou");
            colidindo = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("saiu");
            colidindo = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && colidindo)
        {
            for (int i = 0; i < objetos_iluminados.Length; i++)
            {
                
                objetos_iluminados[i].GetComponent<Renderer>().material = material_emission;
                plat.andando = true;
            }
        }
    }
}
