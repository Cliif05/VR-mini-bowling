
using UnityEngine;

public class PinFallDetector : MonoBehaviour
{
    public ScoreManager scoreManager;

    private bool hasScored = false;

    void Update()
    {
        float angle = Vector3.Angle(transform.up, Vector3.up);

        if (angle > 45f && !hasScored)
        {
            hasScored = true;
            scoreManager.AddPoint();
        }
    }
public void ResetPin()
{
    hasScored = false;
}
}
