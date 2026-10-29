using UnityEngine;
using System;
using System.Collections;

public class UIManager : MonoBehaviour
{
    public int timer;
    public int maxTimer = 60;
    public event Action<int, int> OnTimerChanged;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 60;
        StartCoroutine(CountTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
