using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float velocidadX = 2;
    private float velocidadY = -1.2f;
    private float velocidadDisparo = -2;
    [SerializeField] Transform prefabDisparo = null;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(
           velocidadX * Time.deltaTime,
           velocidadY * Time.deltaTime,
           0);

        if ((transform.position.x < -4)
                || (transform.position.x > 4))
            velocidadX = -velocidadX;
        if ((transform.position.y < -2.5)
                || (transform.position.y > 2.5))
            velocidadY = -velocidadY;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MarioLittleSheet_0")
        {
            this.enabled = false;
            gameObject.tag = "Untagged";
            Destroy(gameObject, 1);
            collision.GetComponentInParent<Rigidbody2D>().AddForce(new Vector2(0, 300));
        }
    }
}