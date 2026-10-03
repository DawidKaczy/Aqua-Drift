using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerEndTrigger : MonoBehaviour
{
    public Timer timer;        
    public AudioSource music;  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            timer.StopTimer();

            GameData.finalTime = timer.GetTime();

            if (music != null)
                music.Play();

            StartCoroutine(LoadEndScene());
        }
    }

    private System.Collections.IEnumerator LoadEndScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("SceneEnd");
    }
}