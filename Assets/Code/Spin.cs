using UnityEngine;

public class Spin : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(100f * Time.deltaTime, 0f, 0f); // หมุนแกน X อย่างต่อเนื่อง
    }
}