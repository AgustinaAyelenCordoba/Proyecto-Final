using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioSource sfxAudioSource;
    [SerializeField] private Slider _slider;
    public static AudioManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        { 
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }


    void Start()
    {
        _slider.value = PlayerPrefs.GetFloat("VolumenSfx");
    }

    public void PlaySoundEffect(AudioClip audioClip ) 

    {
    sfxAudioSource.PlayOneShot(audioClip, _slider.value);

    }

    public void SetVolumenSfx()
    {
        PlayerPrefs.SetFloat("VolumenSfx", _slider.value);
    }

}

