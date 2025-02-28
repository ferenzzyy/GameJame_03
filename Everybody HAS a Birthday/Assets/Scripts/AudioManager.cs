using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public enum SoundFXs
    {
        WRAPPING,
        CREATING_GIFT,
        TRASH,
        MONEY_CHA_CHING,
        INVALID,
        FOOTSTEPS,
        HOLD_ITEM,
        RELEASE_ITEM,
        COMPONENT_POP
    }

    [SerializeField] GameObject audioObject;
    [SerializeField] AudioClip[] wrappingAudio;
    [SerializeField] AudioClip[] creatingGiftAudio;
    [SerializeField] AudioClip[] trashAudio;
    [SerializeField] AudioClip[] moneyChingAudio;
    [SerializeField] AudioClip[] invaliAudio;
    [SerializeField] AudioClip[] footstepsAudio;
    [SerializeField] AudioClip[] holdItemAudio;
    [SerializeField] AudioClip[] releaseItemAudio;
    [SerializeField] AudioClip[] componentPopAudio;

    public void AudioTrigger(SoundFXs sound, Vector3 audioPosition, float volume)
    {
        GameObject newAudio = GameObject.Instantiate(audioObject, audioPosition, Quaternion.identity);
        ControlAudio ca = newAudio.GetComponent<ControlAudio>();

        switch (sound) 
        {
            case SoundFXs.WRAPPING:
                ca.SetAudioClip( wrappingAudio[ Random.Range(0, wrappingAudio.Length) ] );
                break;
            case SoundFXs.CREATING_GIFT:
                ca.SetAudioClip(creatingGiftAudio[Random.Range(0, creatingGiftAudio.Length)]);
                break;
            case SoundFXs.TRASH:
                ca.SetAudioClip(trashAudio[Random.Range(0, trashAudio.Length)]);
                break;
            case SoundFXs.MONEY_CHA_CHING:
                ca.SetAudioClip(moneyChingAudio[Random.Range(0, moneyChingAudio.Length)]);
                break;
            case SoundFXs.INVALID:
                ca.SetAudioClip(invaliAudio[Random.Range(0, invaliAudio.Length)]);
                break;
            case SoundFXs.FOOTSTEPS:
                ca.SetAudioClip(footstepsAudio[Random.Range(0, footstepsAudio.Length)]);
                break;
            case SoundFXs.HOLD_ITEM:
                ca.SetAudioClip(holdItemAudio[Random.Range(0, holdItemAudio.Length)]);
                break;
            case SoundFXs.RELEASE_ITEM:
                ca.SetAudioClip(releaseItemAudio[Random.Range(0, releaseItemAudio.Length)]);
                break;
            case SoundFXs.COMPONENT_POP:
                ca.SetAudioClip(componentPopAudio[Random.Range(0, componentPopAudio.Length)]);
                break;

        }

        ca.SetVolume(volume);
        ca.StartAudio();
    }

}
