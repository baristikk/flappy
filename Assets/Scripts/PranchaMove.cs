﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PranchaMove : MonoBehaviour {

    public float velocidade;
    public float limite;
    public float retorno;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 velocidadeVetorial = Vector3.left * velocidade;
        transform.position = transform.position + velocidadeVetorial * Time.deltaTime;

        if (transform.position.x <= limite)
        {
            transform.position = new Vector3(retorno, transform.position.y, transform.position.z);
        }
	}
}
