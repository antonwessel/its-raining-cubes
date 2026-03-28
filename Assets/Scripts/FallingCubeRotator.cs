using UnityEngine;

public class FallingCubeRotator : MonoBehaviour
{
    private void Update()
    {
        transform.Rotate(90f * Time.deltaTime, 120f * Time.deltaTime, 60f * Time.deltaTime);
    }
}
