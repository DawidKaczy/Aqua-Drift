using UnityEngine;
using UnityEngine.UI;

public class VolumeController : MonoBehaviour
{
    public AudioSource musicSource;
    public Slider volumeSlider;

    private const string VolumeKey = "MusicVolume";

    private void Start()
    {
        float savedVolume = PlayerPrefs.GetFloat(VolumeKey, 0.5f);

        volumeSlider.value = savedVolume;
        musicSource.volume = savedVolume;

        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float value)
    {
        musicSource.volume = value;

        PlayerPrefs.SetFloat(VolumeKey, value);
        PlayerPrefs.Save();
    }
}
