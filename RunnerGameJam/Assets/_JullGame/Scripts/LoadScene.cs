using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void SceneChange(string scene)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(scene);
    }
}