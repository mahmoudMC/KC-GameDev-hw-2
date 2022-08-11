using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballcollision : MonoBehaviour
{
    public Text scoretext;
    int bluescore = 0;
    int redscore = 0;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(8, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bluegoal")
        {
            redscore++;
            scoretext.text = bluescore + " - " + redscore;
            transform.position = new Vector3(0, 0, 0);
        }
        else if (collision.gameObject.name == "redgoal")
        {
            bluescore++;
            scoretext.text = bluescore + " - " + redscore;
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
