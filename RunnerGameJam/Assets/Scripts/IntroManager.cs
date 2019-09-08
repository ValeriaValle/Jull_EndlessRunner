using UnityEngine;
using UnityTools.ScriptableVariables;
using System.Collections;

public class IntroManager : MonoBehaviour
{
    [SerializeField]
    private GenericBool introDone;
    [SerializeField]
    private GameObject videoStuff;

    void Start()
    {
        if (introDone.var)
        {
            videoStuff.SetActive(false);
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
    }
}
