using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    public Image timerBar;
    public UIManager uiManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uiManager.OnTimerChanged += OnTimerChanged;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTimerChanged(int timer, int maxTimer)
    {
        float normalizedTime = (float) timer / maxTimer;
        timerBar.fillAmount = normalizedTime;
    }
}
