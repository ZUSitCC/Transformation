using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.Rotate(_speed *  Time.deltaTime * Vector3.up);
    }
}
