using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rgb;
    public bool isDead;
    void Awake()
    {
        rgb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            isDead= true;
            Destroy(gameObject);           
            GameManager.instance.ResetLevel();
        }
    }

}
