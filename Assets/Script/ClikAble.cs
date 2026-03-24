using UnityEngine;
using UnityEngine.UI;

public class ClikAble : MonoBehaviour
{
    [SerializeField] private Image img;
    [SerializeField] private Button bttn;
    [SerializeField] private ScoreController scoreController;

    public void OnClick()
    {
        img.color = Color.yellow;
        bttn.interactable = false;
        scoreController.Counter();
    }


    //button.GetComponent<Image>().color = new Color(30f, 150f, 200f);
}
