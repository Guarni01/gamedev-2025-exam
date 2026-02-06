using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    private float rotateCamera = 180f;
    private Vector3 rotateAxis = Vector3.forward;
    public bool isRotated;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
  
        isRotated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && !isRotated)
        {
            transform.Rotate(rotateCamera * rotateAxis);
            isRotated = true;
        }

        if (isRotated && Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(rotateCamera * rotateAxis);
            isRotated = false;
        }


    }
}
