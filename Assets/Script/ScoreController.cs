using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_TMP;
    [SerializeField] private int max;
    [SerializeField] private GameObject img;

    public int found = 0;

    private void Start()
    {
        m_TMP.text = max.ToString() + " / " + found;
    }

    public void Counter()
    {
        found++;
        m_TMP.text = max.ToString() + " / " + found;
        if (found >= max)
        {
            img.SetActive(true);
        }
    }
}
