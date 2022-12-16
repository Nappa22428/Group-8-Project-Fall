using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private Player player;
    private Spawner spawner;

    public AudioSource song1;
    public AudioSource pointSound;
    //public AudioSource song2;

    public string nScene;

   

    public Text scoreText;

    public GameObject playButton;
    public GameObject gameOver;
    public GameObject startUp;
    
    public bool endless = false;
    public bool hell = false;
    public int score { get; private set; }
    public int scoreWin;

    private void Start()
    {
        song1.Play();
       // song2.Play();
       // song2.Pause();

    }
    private void Awake()
    {
        Application.targetFrameRate = 60;

        player = FindObjectOfType<Player>();
        spawner = FindObjectOfType<Spawner>();
       // song2.Pause();
        Pause();
    }

    public void Play()
    {
        score = 0;
        player.Hp = 3;
        scoreText.text = score.ToString();
        song1.UnPause();

        playButton.SetActive(false);
        gameOver.SetActive(false);
        startUp.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;

        Pipes[] pipes = FindObjectsOfType<Pipes>();

        for (int i = 0; i < pipes.Length; i++)
        {
            Destroy(pipes[i].gameObject);
        }
        spawner.s = true;
    }

    public void Update()
    {
        if (score == scoreWin && endless == false)
        {
            SceneManager.LoadScene(nScene);
        }
    }

    public void GameOver()
    {
        playButton.SetActive(true);
        gameOver.SetActive(true);
        song1.Pause();
        Pause();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void IncreaseScore()
    {
        score++;
        scoreText.text = score.ToString();
        pointSound.Play();

        /*
        if(score%6 == 0 && hell == false)
        {
            hell = true;
            //song1.Pause();

           // song2.UnPause();
        }
        else if(score % 6 == 0 && hell == true)
        {
            hell = false;
           // song1.UnPause();
           // song2.Pause();
        }
        */
    }
}
