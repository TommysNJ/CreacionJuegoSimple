using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion3 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public float wallRotation = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, wallRotation * Time.deltaTime);
    }
}
