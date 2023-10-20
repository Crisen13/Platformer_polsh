using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{

    [SerializeField] float Speed;
    [SerializeField] Transform PointA;
    [SerializeField] Transform PointB;
    [SerializeField] bool isArrive;

   
    void Update()
    {
        if (isArrive)
        {
            transform.position = Vector2.MoveTowards(transform.position, PointB.position, Speed * Time.deltaTime);

            if (transform.position.x == PointB.position.x)
            {
                isArrive = !isArrive;
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, PointA.position, Speed * Time.deltaTime);

            if (transform.position.x == PointA.position.x)
            {
                isArrive = !isArrive;
            }
        }
    }
}
