using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destryoutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound = 30f;
    [SerializeField] private float bottomBound = -10f;

    private void Update()
    {

        //proyectiles
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }


        //animales

        if (transform.position.z < bottomBound)
        {
            Destroy(gameObject);
            Debug.Log(message:"GAME OVER");
            Time.timeScale = 0f;
        }
    }
}
