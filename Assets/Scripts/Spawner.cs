using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject sign;

    private void Start()
    {
        InvokeRepeating("Spawn", 0, 5f);
    }
    private void Spawn() 
    {
        Instantiate(sign);
        sign.transform.position = new Vector3(Random.Range(05, 10), -1, 100);
    }
}
