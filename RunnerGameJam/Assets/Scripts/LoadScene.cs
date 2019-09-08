using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void SceneChange(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}