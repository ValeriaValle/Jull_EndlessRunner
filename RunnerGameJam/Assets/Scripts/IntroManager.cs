using UnityEngine;
using UnityTools.ScriptableVariables;
using System.Collections;

public class IntroManager : MonoBehaviour
{
    [SerializeField]
    private GenericBool introDone;
    [SerializeField]
    private GameObject[] videoStuff;

    void Start()
    {
        if (introDone.var)
        {
            foreach (GameObject item in videoStuff)
            {
                item.SetActive(false);
            }
        }
        else
        {
            StartCoroutine(QuitVideo());
        }
    }

    IEnumerator QuitVideo()
    {
        yield return new WaitForSeconds(10.0f);
        foreach (GameObject item in videoStuff)
        {
            introDone.var = true;
            item.SetActive(false);
        }
    }
}
