using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Items ko rotate karne ke liye taaki wo attractive lagein
    void Update()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
