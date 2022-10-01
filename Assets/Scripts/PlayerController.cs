using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float xRange = 25f;
    public float zUp = 20f;
    public float zDown = 0f;
    public float speed = 1f;
  
    public GameObject prefabProjectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < -xRange){
                transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > xRange){
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.z > zUp){
                transform.position = new Vector3(transform.position.x, transform.position.y, zUp);
        }
        else if (transform.position.z < 0){
            transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        }

     horizontalInput = Input.GetAxis("Horizontal");
     transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed );

     verticalInput = Input.GetAxis("Vertical");
     transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed );

    if(Input.GetKeyDown(KeyCode.Space)){
        Instantiate(prefabProjectile, transform.position, prefabProjectile.transform.rotation);
    }


    }
}
