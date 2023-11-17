using UnityEngine;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject image;

    void Start()
    {
        CheckOrientation();
        Application.targetFrameRate = 60;
    }

    void Update()
    {
        CheckOrientation();
    }

    private void CheckOrientation()
    {
        if (Screen.width > Screen.height)
        {
            // Landscape orientation
            image.SetActive(false);

        }
        else
        {
            // Portrait orientation
            image.SetActive(true);
        }
    }
}