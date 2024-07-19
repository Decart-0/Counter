using UnityEngine;
using System.Collections;
using TMPro;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _currentValue;
    [SerializeField] private float _timeStep;
    [SerializeField] private float _incrementStep;
    [SerializeField] private CounterView _counterView;

    private bool _isCounting = false;
    private Coroutine _countingCoroutine;

    public float CurrentValue => _currentValue;

    private void Update() 
    {
        if (Input.GetMouseButtonDown(0))
             ClickMouse();
    }

    private void ClickMouse()
    {
        if (_isCounting)
            StopCoroutine(_countingCoroutine);

        _isCounting = !_isCounting;

        if (_isCounting)
            _countingCoroutine = StartCoroutine(CounteUp(_timeStep, _incrementStep));
    }

    private void Increase(float incrementStep)
    {
        _currentValue += incrementStep;
    }

    private IEnumerator CounteUp(float timeStep, float incrementStep)
    {
        var wait = new WaitForSecondsRealtime(timeStep);

        while (_isCounting)
        {
            Increase(incrementStep);
            _counterView.DisplyCounte();

            yield return wait;
        }
    }
}