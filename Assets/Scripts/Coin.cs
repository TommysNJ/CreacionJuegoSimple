using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    

    [SerializeField]
    AudioSource audioCoin;

    public float animationTime = 0.1f;
    public float coinRotation = 150f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, coinRotation * Time.deltaTime);
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            audioCoin.Play();
            Destroy(gameObject);
        }
    }
}
