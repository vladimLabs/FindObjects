using UnityEngine;

public class SettingsButton : MonoBehaviour
{
    [SerializeField] private GameObject image;
    [SerializeField] private GameObject settings;

    public void OnClick()
    {
        image.SetActive(false);
        settings.SetActive(true);
    }
}
