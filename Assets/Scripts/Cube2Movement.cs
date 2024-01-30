using UnityEngine;

public class Cube2Movement : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed = 1f;
    [SerializeField] private float _scaleSpeed = 1f;
    [SerializeField] private float _speed = 1f;

    private void Update()
    {
        transform.localScale += _scaleSpeed * Time.deltaTime * Vector3.one;
        transform.Rotate(_rotateSpeed * Time.deltaTime * Vector3.up);
        transform.Translate(_speed * Time.deltaTime * Vector3.forward);
    }
}