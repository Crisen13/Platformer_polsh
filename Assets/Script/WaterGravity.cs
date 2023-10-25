using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGravity : MonoBehaviour
{

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
}
