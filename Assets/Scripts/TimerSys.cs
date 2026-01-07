using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerSys : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI timertext;
    [SerializeField]private Fight fight;
    void Start()
    {
        timertext.text = "Осталось 5 минут";
        Invoke("Timertoend", 300);
        Invoke("TimerVisual4", 60);
    }
    private void TimerVisual4()
    {
        timertext.text = "Осталось 4 минуты";
        Invoke("TimerVisual3", 60);
    }
    private void TimerVisual3()
    {
        timertext.text = "Осталось 3 минуты";
        Invoke("TimerVisual2", 60);
    }
    private void TimerVisual2()
    {
        timertext.text = "Осталось 2 минуты";
        Invoke("TimerVisual1", 60);
    }
    private void TimerVisual1()
    {
        timertext.text = "Осталось 1 минута";
        Invoke("TimerVisualEnd", 60);
    }
    private void TimerVisualEnd()
    {
        timertext.text = "Время вышло!";
    }
    private void Timertoend()
    {
        if (fight.kills >= 3)
        {
            SceneManager.LoadScene("GoodEnding");
        }
        else if (fight.kills < 3)
        {
            SceneManager.LoadScene("BadEnding");
        }
    }
}