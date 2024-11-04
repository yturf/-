using TMPro;
using UnityEngine;

public class CountorView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Counter _countor;

    private void Start()
    {
        _text.text = "";
    }

    private void OnEnable()
    {
        _countor.Account += DisplayCountor;
    }

    private void OnDisable()
    {
        _countor.Account -= DisplayCountor;
    }

    private void DisplayCountor(int score)
    {
        _text.text = score.ToString();
    }
}
