using UnityEngine;
using UnityTools.ScriptableVariables;
using System.Collections;

public class IntroManager : MonoBehaviour
{
    [SerializeField]
    private GenericBool introDone;
    [SerializeField]
    private GameObject videoStuff;
    [SerializeField]
    private AudioSource menuAudio;

    void Start()
    {
        introDone.var = true;
        if (introDone.var)
        {
            videoStuff.SetActive(false);
            menuAudio.Play();
        }
        else
        {
            StartCoroutine(QuitVideo());
        }
    }

    IEnumerator QuitVideo()
    {
        yield return new WaitForSeconds(10.0f);
        CloseVideo();
    }

    public void CloseVideo()
    {
        introDone.var = true;
        videoStuff.SetActive(false);
        menuAudio.Play();
    }
}
