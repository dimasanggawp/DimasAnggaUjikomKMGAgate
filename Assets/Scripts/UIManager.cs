using UnityEngine;
using System;
using System.Collections;
using TMPro;

public class UIManager : MonoBehaviour
{
    public int score = 0;
    public int timer;
    public int maxTimer = 60;
    public event Action<int, int> OnTimerChanged;
    public MisileBehaviour misil;
    public TMP_Text ScoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        misil.OnScoreChanged += OnScoreChanged;
    }
    
    void Start()
    {
        timer = 60;
        StartCoroutine(CountTimer());
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Score : " + score);
    }

    IEnumerator CountTimer()
    {
        while(timer <= maxTimer)
        {
            OnTimerChanged?.Invoke(timer, maxTimer);
            timer--;
            yield return new WaitForSeconds(1f);
        }
    }

    void OnScoreChanged(int addScore)
    {
        score += addScore;
        ScoreText.text = "Score : " + score;
    }
}
