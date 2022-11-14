using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject balaPrefab;
    public float velocidad;
    public int vida;
    public int dañoBala;
    public int cantidadBalas;
    public Transform cañon;





    Rigidbody2D rb2D;
    Vector2 movimiento;
    bool estaVivo;
    GameObject[] balas;


    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        balas = new GameObject[cantidadBalas];

        for(int i = 0; i< balas.Length; i++)
        {
            balas[i] = (GameObject)Instantiate(balaPrefab);
            balas[i].SetActive(false);
        }
    }



    void Update()
    {
        estaVivo = vida > 0;

        if (!estaVivo) return;

        movimiento = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        if (Input.GetButtonDown("Fire1")) ;
        {
            Disparar();
        }
    }



    void FixedUpdate()
    {
        transform.Translate(movimiento * velocidad);

        LimitarMovimiento();
    }



    void LimitarMovimiento()
    {
        Vector2 posicionLimitada = transform.position;

        posicionLimitada.x = Mathf.Clamp(posicionLimitada.x, -1.9f, 1.12f);
        posicionLimitada.y = Mathf.Clamp(posicionLimitada.y, -0.006f, 6.15f);

        transform.position = posicionLimitada;
    }

    void Disparar()
    {
        for(int i = 0; i< balas.Length; i++)
        {
            if (!balas[i].activeInHierarchy)
            {
                balas[i].SetActive(true);
                balas[i].transform.position = cañon.position;
                break;
            }
        }
    }


}
