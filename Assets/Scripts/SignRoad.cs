using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignRoad : MonoBehaviour
{
    private float _signSpeed;
    private void Update()
    {
        _signSpeed += 0.003f;
        transform.Translate(_signSpeed, 0, 0);
    }
}
