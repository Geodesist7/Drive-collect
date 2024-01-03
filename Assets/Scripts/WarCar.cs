using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarCar : MonoBehaviour
{
    [SerializeField] private float _signSpeed;
    private void FixedUpdate()
    {

        transform.Translate(_signSpeed * Time.fixedDeltaTime, 0, 0);
    }
}
