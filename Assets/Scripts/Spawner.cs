using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] sign;
    [SerializeField] private float timer = 10f;


    private void Start()
    {
        InvokeRepeating("Spawn", 0, timer);
    }
    private void Spawn() 
    {
        var s = Instantiate(sign[Random.Range(0,sign.Length)]);
        s.transform.position = new Vector3(Random.Range(-6.5f, 7.5f), 2, 100);
    }
    
    
}
