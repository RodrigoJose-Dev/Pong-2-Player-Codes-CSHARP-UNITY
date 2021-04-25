using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public float speed = 5;

    private void Start()
    {
        //se o valor for = 0, ele pega e joga -1, senão ele recebe 1 
        float speedX = Random.Range(0, 2) == 0 ? -1 : 1;
        float speedY = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * speedX, speed * speedY, 0f);

    }

}
