using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Move()
    {
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movimento * Time.deltaTime * velocidade;
    }
}
