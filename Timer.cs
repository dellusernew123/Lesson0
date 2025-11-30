using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private float _time = 20f;

    private bool _isStopped = false;
    public bool TimeIsUp { get; private set; } = false;

    private void Update()
    {
        if (_time <= 0 || _isStopped == true)
            return;     

        Debug.Log($"Оставшееся время:{_time}");

        _time -= Time.deltaTime;

        if (_time <= 0)
            TimeIsUp = true;
    }

    public void Stop()
    {
        _isStopped = true;
    }
}
