using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public void LoadSceneOnClick(int sceneNo)
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(sceneNo);
    }

    public void Exit()
    {
        Application.Quit();
    }

}
