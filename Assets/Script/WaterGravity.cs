using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WaterGravity : MonoBehaviour
{
    public float speed = 4f;

    public GameObject heart1, heart2, heart3;
    private int life = 3;
    public bool isHurt = false;

    bool m_FacingRight = true;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Physics2D.gravity = new Vector2(0, 9.8f);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            Physics2D.gravity = new Vector2(0, -9.8f);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            Physics2D.gravity = new Vector2(-9.8f, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            Physics2D.gravity = new Vector2(9.8f, 0);
        }
    }

    void FixedUpdate()
    {
        if (speed > 0 && !m_FacingRight)
        {
            Flip();
        }
        else if (speed < 0 && m_FacingRight)
        {
            Flip();
        }
    }

    void Flip()
    {
        m_FacingRight = !m_FacingRight;

        transform.Rotate(0f, 180f, 0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            life--;
            Life();
            isHurt = true;

        }
    }

    void Life()
    {
        if (life == 3)
        {
            heart3.SetActive(true);
            heart2.SetActive(true);
            heart1.SetActive(true);
        }

        if (life == 2)
        {
            heart3.SetActive(false);
            heart2.SetActive(true);
            heart1.SetActive(true);
        }

        if (life == 1)
        {
            heart3.SetActive(false);
            heart2.SetActive(false);
            heart1.SetActive(true);
        }

        if (life < 1)
        {
            heart3.SetActive(false);
            heart2.SetActive(false);
            heart1.SetActive(false);

            SceneManager.LoadScene("level_5", LoadSceneMode.Single);
        }
    }
}