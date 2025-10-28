using UnityEngine;

public class SunFollow : MonoBehaviour
{
    [Header("Follow Settings")]
    public Transform PlayerPosition;
    public float smoothSpeed = 5f;
    public Vector3 offset = new Vector3(0f, 0f, 0f);



    void  LateUpdate()
    {
        if (PlayerPosition == null) return;

        Vector3 desiredPosition = PlayerPosition.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
