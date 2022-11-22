using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    public float animationSpeed = 1f;
    public bool goodRepeat = false;
    public bool hellRepeat = false;

    GameManager gameManager;
    public GameObject gm;

    public Material good;
    public Material hell;

    public MeshRenderer mR;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        gameManager = gm.GetComponent<GameManager>();
    }

    private void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animationSpeed * Time.deltaTime, 0);

       /* if(gameManager.score % 6 == 0 && gameManager.score != 0)
        {
            if(gameManager.hell == true && goodRepeat == false)
            {
                mR.material = hell;
                goodRepeat = true;
                hellRepeat = false;
            } 
            else if (gameManager.hell == false && hellRepeat == false)
            {
                mR.material = good;
                goodRepeat = false;
                hellRepeat = true;
            }
        }
        */
       
    }
}
