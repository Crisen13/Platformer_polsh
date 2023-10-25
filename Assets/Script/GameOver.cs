using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public bool dead = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "physic collide")
        {
            dead = true;
            SceneManager.LoadScene("DIES", LoadSceneMode.Single);
        }

        if (collision.gameObject.name == "physic collide1")
        {
            dead = true;
            SceneManager.LoadScene("level_1", LoadSceneMode.Single);
        }

        if (collision.gameObject.name == "physic collide2")
        {
            dead = true;
            SceneManager.LoadScene("level_2", LoadSceneMode.Single);
        }

        if (collision.gameObject.name == "physic collide3")
        {
            dead = true;
            SceneManager.LoadScene("level_3", LoadSceneMode.Single);
        }

        if (collision.gameObject.name == "physic collide4")
        {
            dead = true;
            SceneManager.LoadScene("level_4", LoadSceneMode.Single);
        }
    }

  
}
