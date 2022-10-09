using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigueJugador : MonoBehaviour
{

    public GameObject MarioLittleSheet_0;
    private Vector3 posicionRelativa;

    // Use this for initialization
    void Start()
    {

        posicionRelativa = transform.position - MarioLittleSheet_0.transform.position;

    }

    // Update is called once per frame
    void LateUpdate()
    {

        transform.position = MarioLittleSheet_0.transform.position + posicionRelativa;

    }
}