using UnityEngine;

public class CameraMove : MonoBehaviour
{
    private bool _moveRight, _moveLeft;

    public void MoverR(bool moveRight)
    {
        _moveRight = moveRight;
    }
    
    public void MoverL(bool moveLeft)
    {
        _moveLeft = moveLeft;
    }
    private void Update()
    {
        if (_moveRight) transform.Translate(0.05f, 0, 0);
        if (_moveLeft) transform.Translate(-0.05f, 0, 0);
    }
}