using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Vector2 targetPos;
    public int Xincrement;             //2
    public float speed;                  //20
    public int maxLen;                 //2
    public int minLen;                 //-2
    public int health = 1;
    public GameObject gameOver;
    public GameObject scoreManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
            Destroy(scoreManager);
        }

        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > minLen)
        {
            targetPos = new Vector2(transform.position.x - Xincrement, transform.position.y);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < maxLen)
        {
            targetPos = new Vector2(transform.position.x + Xincrement, transform.position.y);
        }

        if (transform.position.x < minLen)
        {
            targetPos = new Vector2(-2, 0);
        }
        if (transform.position.x > maxLen)
        {
            targetPos = new Vector2(2, 0);
        }
    }
}
