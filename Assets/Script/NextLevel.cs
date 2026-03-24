using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{
    [SerializeField] private Button _btn;
    [SerializeField] private string scene;

    private void Awake()
    {
        //_btn = GetComponent<Button>();
        _btn.onClick.AddListener(NextScene);
    }

    private void NextScene()
    {
        SceneManager.LoadScene(scene);
    }
}
