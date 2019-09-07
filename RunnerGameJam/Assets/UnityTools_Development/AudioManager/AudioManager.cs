using UnityEngine;
using UnityTools.ScriptableVariables;

public class AudioManager : MonoBehaviour
{
    public GenericBool sfxActive;
    public GenericBool musicActive;

    private AudioSource aSourceMusic;
    private AudioSource aSourceSFX;

    private void Start()
    {
        aSourceMusic = GameObject.FindWithTag("Audio/Music").GetComponent<AudioSource>();
        aSourceMusic.enabled = musicActive.var;

        aSourceSFX = GameObject.FindWithTag("Audio/SFX").GetComponent<AudioSource>();
        aSourceSFX.enabled = sfxActive.var;
    }

    public void MusicToggle()
    {
        musicActive.var = !musicActive.var;
        aSourceMusic.enabled = musicActive.var;
    }

    public void SFX_Toggle()
    {
        sfxActive.var = !sfxActive.var;
        aSourceSFX.enabled = sfxActive.var;
    }
}
