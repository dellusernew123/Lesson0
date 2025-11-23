using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _time = 20f;

    private bool _gameHasStopped = false;
    public bool TimeIsUp { get; private set; } = false;

    private void Update()
    {
        if (_time <= 0 || _gameHasStopped == true)
            return;     

        Debug.Log($"Оставшееся время:{_time}");

        _time -= Time.deltaTime;

        if (_time <= 0)
            TimeIsUp = true;
    }

    public void StopTheGame()
    {
        _gameHasStopped = true;
    }
}
