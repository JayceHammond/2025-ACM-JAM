using UnityEngine;

public class radar : MonoBehaviour
{
    public GameObject target;
    public float smoothSpeed = 0.125f;
    public Rawimage radarDisplay;

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 targetPosition = target.transform.position;
            Vector3 currentPosition =  transform.position;
            Vector3 smoothedPosition = Vector3.Lerp(currentPosition, targetPosition, smoothSpeed);
            transform.position = smoothedPosition;
        }
    }
}
