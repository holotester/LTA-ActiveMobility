using UnityEngine;
using TMPro;

public class PlatformTextSwitcher : MonoBehaviour
{
    public TextMeshProUGUI pcText;
    public TextMeshProUGUI mobileText;

    void Start()
    {
        if (SystemInfo.deviceType == DeviceType.Desktop)
        {
            pcText.gameObject.SetActive(true);
            mobileText.gameObject.SetActive(false);
        }
        else
        {
            pcText.gameObject.SetActive(false);
            mobileText.gameObject.SetActive(true);
        }
    }
}
