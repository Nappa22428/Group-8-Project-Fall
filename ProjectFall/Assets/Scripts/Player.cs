using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public Sprite[] hellSprites;
    private int spriteIndex;
    private new Rigidbody2D rigidbody2D;

    GameManager gameManager;
    public GameObject gm;

    private Vector3 direction;

    public float gravity = -9.81f;
    public float strength = 5f;


    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        gameManager = gm.GetComponent<GameManager>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        InvokeRepeating(nameof(AnimateSprite), 0.15f, 0.15f);
    }

    private void OnEnable()
    {
        Vector3 position = transform.position;
        position.y = 0f;
        transform.position = position;
        direction = Vector3.zero;
    }

    // Function to switch gravity
    private void GravitySwitch()
    {
        if (transform.position.y < -0.5)
        {
            //rigidbody2D.gravityScale = -1;
            gravity = 9.81f;
        } else if (transform.position.y > 0.5)
        {
            //rigidbody2D.gravityScale = 1;
            gravity = -9.81f;
        } else {
            //rigidbody2D.gravityScale = 0;
            gravity = 0f;
        }
    }

    void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength;
        }
        
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }
        }
        */

        // Dual direction controls
        if (Input.GetKeyDown(KeyCode.W))
        {
            direction = Vector3.up * strength;
        } else if (Input.GetKeyDown(KeyCode.S))
        {
            direction = Vector3.down * strength;
        }
        
        GravitySwitch();
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }

    private void AnimateSprite()
    {
        spriteIndex++;

        if (spriteIndex >= sprites.Length)
        {
            spriteIndex = 0;
        }

        if (spriteIndex < sprites.Length && spriteIndex >= 0)
        {
            if(gameManager.hell == true)
            {
                spriteRenderer.sprite = hellSprites[spriteIndex];
            }
            else if(gameManager.hell == false)
            {
                spriteRenderer.sprite = sprites[spriteIndex];
            }
           
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        else if (other.gameObject.CompareTag("Scoring"))
        {
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }

}
