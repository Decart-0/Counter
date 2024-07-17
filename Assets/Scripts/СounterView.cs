using TMPro;
using UnityEngine;

public class —ounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private TextMeshProUGUI _textCounter;

    public void Disply—ounte()
    {
        _textCounter.text = (_counter.CurrentValue).ToString("");
    }
}