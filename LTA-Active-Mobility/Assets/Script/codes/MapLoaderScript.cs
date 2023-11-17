using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MapLoaderScript : MonoBehaviour
{
    public GameObject loadingScreen;
    public GameObject PlayBtn;

    IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        PlayBtn.SetActive(false);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            yield return null;
        }
    }
    public void LoadScene(int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

}
