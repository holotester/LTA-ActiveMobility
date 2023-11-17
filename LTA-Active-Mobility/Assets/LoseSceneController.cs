using UnityEngine;
using UnityEngine.UI;

public class LoseSceneController : MonoBehaviour
{
    public GameObject confetti;
    public GameObject bandaid;
    public GameObject balloon;

    void Start()
    {
        // Check the flag to enable the image
        int enableImageFlag = PlayerPrefs.GetInt("enableImageInLoseScene");
        Debug.Log("hello" + enableImageFlag);
        if (enableImageFlag == 1)
        {
            confetti.SetActive(true);
            balloon.SetActive(true);
            bandaid.SetActive(false);
        }
        else
        {
            balloon.SetActive(false);
            confetti.SetActive(false);
            bandaid.SetActive(true);
        }
    }
}
