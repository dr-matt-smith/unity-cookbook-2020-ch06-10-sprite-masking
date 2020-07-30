using UnityEngine;

public class MoveBird : MonoBehaviour
{
    public float speed = 1f;

    void Update()
    {
        transform.Translate(speed * Vector3.right * Time.deltaTime);
    }
}
