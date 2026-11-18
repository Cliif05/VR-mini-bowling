using UnityEngine;

public class ReticleRotate : MonoBehaviour
{
   //public float Speed = 90f;
   


    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 3, 0, Space.World);
    }
}
