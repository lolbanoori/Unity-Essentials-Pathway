using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of one full day in seconds.")]
    [SerializeField] private float dayDurationInSeconds = 120f;

    private void Update()
    {
        if (dayDurationInSeconds <= 0f) return;

        float rotationSpeed = 360f / dayDurationInSeconds; // degrees per second
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
