using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void LoadAndDestroyAllObjects(string sceneName)
    {
        Destroy(Player.instance.gameObject);
        Destroy(MusicController.instance.gameObject);
        SceneManager.LoadScene(sceneName);
        
    }

    public void CloseGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
