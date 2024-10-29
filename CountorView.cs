using TMPro;
using UnityEngine;

public class CountorView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Countor _countor;

    private void Start()
    {
        _text.text = "";
    }

    private void OnEnable()
    {
        _countor.CoroutineEvent += DisplayCountor;
    }

    private void OnDisable()
    {
        _countor.CoroutineEvent -= DisplayCountor;
    }

    private void DisplayCountor(int score)
    {
        _text.text = score.ToString();
    }
}
