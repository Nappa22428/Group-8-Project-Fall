using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hellFont : MonoBehaviour
{
    public Text t;
    public Font good;
    public Font hell;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.hell == true)
        {
            t.font = hell;
        }
        else if (gameManager.hell == false)
        {
            t.font = good;
        }
    }
}
