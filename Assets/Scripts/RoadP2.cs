using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadP2 : MonoBehaviour
{
    private float _offSet;
    private void Update()
    {
        _offSet += 0.01f;
        GetComponent<Renderer>().material.mainTextureOffset = new Vector2(_offSet,0);
    }
}
