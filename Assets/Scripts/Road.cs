using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        DestroyRoad();
    }
    private void FixedUpdate()
    {
        MoveRoad();
    }
    private void MoveRoad() 
    {
        transform.Translate(-transform.forward * _speed * Time.fixedDeltaTime);
    }
    private void DestroyRoad()
    {
        if (transform.position.z < -60f) 
        {
            Destroy(gameObject);
        }
    }
}
