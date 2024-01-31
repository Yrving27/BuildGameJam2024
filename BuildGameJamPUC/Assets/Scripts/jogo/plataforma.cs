using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    public GameObject[] lugares;
    public bool andando = false;
    public int indice = 1;
    public int tamanho;
    public float velocidade;
    public Vector3 direcao;
    public int tempo_de_espera;
    public bool esperar;
    public Material mat;

    public void Start()
    {
        tamanho = lugares.Length;
    }
    void Update()
    {
        direcao = transform.position - lugares[indice].transform.position;
        direcao.Normalize();
        if (andando)
        {
            this.gameObject.GetComponent<Renderer>().material = mat;
            if(esperar == false)
            {
                transform.Translate(-direcao * velocidade * Time.deltaTime);
            }
        }


        float distance = Vector3.Distance(transform.position, lugares[indice].transform.position);
        if(distance < 0.1 && esperar == false)
        {
            esperar = true;
            if(indice == tamanho -1)
            {
                indice = 0;
            }
            else
            {
                indice++;
            }
            Invoke("PodeIr", tempo_de_espera);
        }
    }
    public void PodeIr()
    {
        esperar = false;
    }
}
