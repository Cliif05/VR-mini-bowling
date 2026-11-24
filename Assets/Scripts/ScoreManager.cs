using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreText;
    public Transform[] pins;

    private int score = 0;

    private Vector3[] startPositions;
    private Quaternion[] startRotations;

    void Start()
    {
        startPositions = new Vector3[pins.Length];
        startRotations = new Quaternion[pins.Length];

        for (int i = 0; i < pins.Length; i++)
        {
            startPositions[i] = pins[i].position;
            startRotations[i] = pins[i].rotation;
        }

        UpdateScore();
    }

    public void AddPoint()
    {
        score++;
        UpdateScore();
    }

    public void ResetGame()
    {
        score = 0;
        UpdateScore();

        for (int i = 0; i < pins.Length; i++)
        {
            Rigidbody rb = pins[i].GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.linearVelocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }

            pins[i].position = startPositions[i];
            pins[i].rotation = startRotations[i];

            PinFallDetector detector =
                pins[i].GetComponent<PinFallDetector>();

            if (detector != null)
            {
                detector.ResetPin();
            }
        }
    }

    void UpdateScore()
    {
        scoreText.text = "Pins Knocked Down: " + score + " / 6";
    }
}