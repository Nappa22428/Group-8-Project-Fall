using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hellSprite : MonoBehaviour
{


    GameManager gameManager;
   // public GameObject gm;

    public Sprite good;
    public Sprite hell;

    public SpriteRenderer sR;

    // Start is called before the first frame update

    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameManager.hell == true)
        {
            sR.sprite = hell;
        }
        else if(gameManager.hell == false)
        {
            sR.sprite = good;
        }
    }
}
