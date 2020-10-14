using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public float horizontalSpeed, horizontalBoundary, direction;
    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(horizontalSpeed * direction * Time.deltaTime, 0.0f, 0.0f);

    }

    private void _CheckBounds()
    {
        //check right bound
        if(transform.position.x >= horizontalBoundary)
        {
            direction = -1.0f;
        }
        //check left bound
        if (transform.position.x <= -horizontalBoundary)
        {
            direction = 1.0f;
        }
    }
}
