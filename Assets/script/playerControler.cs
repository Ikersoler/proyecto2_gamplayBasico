using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    private float speed = 10f;
    private float horizontalInput;


    //limites de pantalla
    private float xRange = 15f;



    [SerializeField] private GameObject foodprefab;



    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");



        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);



        //limites de pantalla

        PlayerInBounds();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootFood();
        }
       
    }

    private void PlayerInBounds()
    {
        Vector3 pos = transform.position;

        if (pos.x < -xRange)
        {
            Debug.Log(message: "hola");
            transform.position = new Vector3(-xRange, pos.y, pos.z);
        }
        else if (pos.x > xRange)
        {
            Debug.Log(message: "adios");

            transform.position = new Vector3(xRange, pos.y, pos.z);
        }
        
    }

    private void ShootFood()
    {
        Instantiate(foodprefab, transform.position, Quaternion.identity);
    }

}
