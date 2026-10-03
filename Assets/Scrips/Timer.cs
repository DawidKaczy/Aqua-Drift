using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public float time = 0f;
    private bool isTiming = false;
    private bool hasStarted = false;

    void Update()
    {
        if (isTiming)
        {
            time += Time.deltaTime;

            int minutes = Mathf.FloorToInt(time / 60);
            int seconds = Mathf.FloorToInt(time % 60);
            int milliseconds = Mathf.FloorToInt((time * 100) % 100);

            timerText.text = $"{minutes:00}:{seconds:00}:{milliseconds:00}";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hasStarted && other.CompareTag("Player"))
        {
            isTiming = true;
            hasStarted = true;
        }
    }

    public float GetTime()
    {
        return time;
    }

    public void StopTimer()
    {
        isTiming = false;
    }
}
