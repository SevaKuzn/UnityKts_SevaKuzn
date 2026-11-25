using System.Collections;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float speedThreshold = 1.5f;
    [SerializeField] private float bounceSpeed = 7.5f;

    [SerializeField] private Color slowColor = Color.red;

    private Rigidbody rb;
    private Renderer ballRenderer;
    private Color originalColor;
    private bool isTrackingSlowTime = false;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        ballRenderer = GetComponent<Renderer>();

        originalColor = ballRenderer.material.color;
    }

    private void FixedUpdate()
    {
        float currentSpeed = rb.linearVelocity.magnitude;

        if (currentSpeed < speedThreshold && !isTrackingSlowTime)
        {
            StartCoroutine(TrackLowSpeedCoroutine());
        }
    }

    private IEnumerator TrackLowSpeedCoroutine()
    {
        isTrackingSlowTime = true;
        ballRenderer.material.color = slowColor;

        float elapsedTime = 0f;
        do
        {
            yield return new WaitForFixedUpdate();
            elapsedTime += Time.fixedDeltaTime;

        } while (rb.linearVelocity.magnitude < speedThreshold);

        ballRenderer.material.color = originalColor;
        Debug.Log($"Скорость мяча была ниже порога в течение: {elapsedTime:F3} сек.");

        isTrackingSlowTime = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Vector3 vel = rb.linearVelocity;
        if (vel.y > 0)
        {
            vel.y = bounceSpeed;
            rb.linearVelocity = vel;
        }
    }
}
