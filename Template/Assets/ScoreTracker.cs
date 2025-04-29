using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;

public class ScoreTracker : MonoBehaviour
{

    public int scoreTracker;

    public PlayerMovement myPlayer;

    public static ScoreTracker Instance;
    public TextMeshProUGUI score;


    void Awake()
    {
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (myPlayer == null)
        {
            myPlayer = FindObjectOfType<PlayerMovement>();
        }

        score = GameObject.FindGameObjectWithTag("ScoreTracker")?.GetComponent<TextMeshProUGUI>();
        scoreTracker = myPlayer.score;
        score.text = "Score: " + scoreTracker;
    }
}