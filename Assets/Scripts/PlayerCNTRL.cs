using UnityEngine;

public class PlayerCNTRL : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    private int w;
    private void Start()
    {
        w = Screen.width/2;
    }
    private void Update()
    {
        if (Input.GetMouseButton(0)) 
        {
            transform.Translate(Input.mousePosition.x >w ? _speed * Time.deltaTime:-_speed * Time.deltaTime, 0, 0);
        }
    }
}