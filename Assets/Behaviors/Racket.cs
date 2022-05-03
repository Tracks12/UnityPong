using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public float limitYMin = -400.0f;
    public float limitYMax = 400.0f;

    public Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float midShape = transform.localScale.y/2;
        
        this.position = transform.position;

        position.y = position.y+midShape > this.limitYMax ? position.y - 1 : position.y;
        position.y = position.y-midShape < this.limitYMin ? position.y + 1 : position.y;

        transform.position = position;
    }
}
