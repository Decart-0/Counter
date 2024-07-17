using UnityEngine;
using System.Collections;
using TMPro;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _currentValue;
    [SerializeField] private float _timeStep;
    [SerializeField] private float _incrementStep;
    [SerializeField] private —ounterView _counterView;

    private bool _isCounting = false;
    private Coroutine _countingCoroutine;

    public float CurrentValue => _currentValue;

    private void Increase(float incrementStep)
    {
        _currentValue += incrementStep;
    }

    public void ClickButton()
    {
        if (_isCounting)
            StopCoroutine(_countingCoroutine);

        _isCounting = !_isCounting;

        if (_isCounting)
            _countingCoroutine = StartCoroutine(—ounteUp(_timeStep, _incrementStep));
    }

    private IEnumerator —ounteUp(float timeStep, float incrementStep)
    {
        var wait = new WaitForSecondsRealtime(timeStep);

        while (_isCounting)
        {
            Increase(incrementStep);
            _counterView.Disply—ounte();

            yield return wait;
        }
    }
}