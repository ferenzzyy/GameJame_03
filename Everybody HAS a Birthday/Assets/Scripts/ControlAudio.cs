using UnityEngine;

public class ControlAudio : MonoBehaviour
{
    AudioSource _audioSource;
    AudioClip _audioClip;
    float _volume;

    // Update is called once per frame
    void Update()
    {
        if (!_audioSource.isPlaying)
        {
            Destroy(gameObject);
        }
    }

    public void StartAudio()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.clip = _audioClip;
        _audioSource.volume = _volume;
        _audioSource.Play();

    }

    public void SetVolume(float vol)
    {
        _volume = vol;
    }

    public float GetVolume()
    {
        return _volume;
    }

    public AudioClip GetAudioClip() 
    {
        return _audioClip;
    }

    public void SetAudioClip(AudioClip audioC) 
    {
        _audioClip = audioC;
    }
}
