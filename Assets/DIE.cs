using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DIE : MonoBehaviour
{
    public GameObject laser;
    public float thrust;
    private Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.name == "Beam")
        {
            Vector3 movement = new Vector3(10, 10, 0);
            rb.AddForce(movement);
        }
    }

}
