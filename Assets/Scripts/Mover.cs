// Ashley Maynez
// 09/22/2019
// CS 3410

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = RandomMove(-1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private Vector3 RandomMove(float a, float b)
    {
        var temp1 = Random.Range(a, b);
        var temp2 = Random.Range(a, b);
        var temp3 = Random.Range(a, b);
        return new Vector3(temp1, temp2, temp3);
    }
}
