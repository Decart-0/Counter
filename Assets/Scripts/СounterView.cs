using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private TextMeshProUGUI _textCounter;

    public void DisplyCounte()
    {
        _textCounter.text = (_counter.CurrentValue).ToString();
    }
}