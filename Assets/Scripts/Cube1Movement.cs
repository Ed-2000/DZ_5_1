using UnityEngine;

public class Cube1Movement : MonoBehaviour
{
    [SerializeField] private float _speed = 1f;

    private void Update()
    {
        transform.Rotate(_speed * Time.deltaTime * Vector3.up);
    }
}