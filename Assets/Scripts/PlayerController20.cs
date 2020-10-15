using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController20 : MonoBehaviour
{
    float speed = 10.0f;
    float maxLimit = 4.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * Time.deltaTime * verticalInput * speed);
        transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);

        if(transform.position.z < -maxLimit)
        {
            
        }
    }
}
