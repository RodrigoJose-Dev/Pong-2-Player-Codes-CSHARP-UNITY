using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 5f;
    public bool isRight;

    private void Update()
    {
        
        if (!isRight)//se a plataforma for direita, pega 1 controle, se for a esquerda, pega outro
        {
            transform.Translate(0f, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0f);
        }
        else
        {
            transform.Translate(0f, Input.GetAxis("Vertical2") * speed * Time.deltaTime, 0f);
        }

    }

}
