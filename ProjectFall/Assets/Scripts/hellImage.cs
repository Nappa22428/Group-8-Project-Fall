using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class hellImage : MonoBehaviour
{
    // Start is called before the first frame update

    public Image i;
    public Sprite good;
    public Sprite hell;
    public Sprite start;
 
    GameManager gameManager;

    // Start is called before the first frame update

    private void Start()
    {
        i.sprite = start;
    }
    private void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.hell == true)
        {
            i.sprite = hell;
        }
        else if (gameManager.hell == false)
        {
            i.sprite = good;
        }
    }
}

