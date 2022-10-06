using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject bullet, spawnerBulletPos;
    private Vector2 target;
    private Rigidbody2D rb;
    private Vector2 direction;
    private Vector2 direcao;
    private float speed;

    void Start()
    {
        speed = 5;
        direcao = Vector2.zero;

    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
    

    void move(){
        
    
        direcao = Vector2.zero;
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            direcao += Vector2.up;
        }
        // if (Input.GetKey(KeyCode.DownArrow))
        // {
        //     direcao += Vector2.down;
        // }
        // if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     direcao += Vector2.left;
        // }
        // if (Input.GetKey(KeyCode.RightArrow))
        // {
        //     direcao += Vector2.right;
        // }
        
        transform.Translate(direcao * speed * Time.deltaTime);

        gunShot();
    }

    void gunShot(){
       
        Vector3 mousePos = Input.mousePosition;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        direction = new Vector2(mousePos.x - transform.position.x, mousePos.y - transform.position.y);
        transform.up = direction;

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, spawnerBulletPos.transform.position, this.gameObject.transform.rotation);
        }
    }
    
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Destroy(gameObject);
        }
        
    }
}
