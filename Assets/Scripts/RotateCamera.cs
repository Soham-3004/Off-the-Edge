using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotateSpeed = 100f;
    private float horizontalInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.down * horizontalInput * Time.deltaTime * rotateSpeed );
    }
}
