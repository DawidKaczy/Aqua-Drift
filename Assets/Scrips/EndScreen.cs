using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    public TextMeshProUGUI finalTimeText;

    void Start()
    {
        float time = GameData.finalTime;

        int minutes = Mathf.FloorToInt(time / 60);
        int seconds = Mathf.FloorToInt(time % 60);
        int milliseconds = Mathf.FloorToInt((time * 100) % 100);

        finalTimeText.text = $"{minutes:00}:{seconds:00}:{milliseconds:00}";
    }
}