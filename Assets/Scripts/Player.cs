using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    int cameraSpeed = 300;
    float jumpForce = 4.0f;
    private Rigidbody Physics;  
    [SerializeField]
    int speedPlayer = 3;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotationY = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0,rotationY * cameraSpeed * Time.deltaTime,0));

       if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speedPlayer * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speedPlayer * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speedPlayer * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speedPlayer * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.AddForce(new Vector3(0,jumpForce,0), ForceMode.Impulse);
        }

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "ObstaculoP")
        {
            Destroy(gameObject);
        }
    }
    
}
