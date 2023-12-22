using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class PlayerCNTRL : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;
    private int w;
    private int score = 0;
    public TMP_Text scoreText;
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
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "sign")
        {
            score++;
            Destroy(other.gameObject);
            scoreText.text = "Score: " + score;
        }
    }
}