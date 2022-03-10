using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Look_up : MonoBehaviour
{

    float clamp;
    public float MouseSpeed = 50.0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // float LookVertical = -Input.GetAxisRaw("Controller Y") / 12;
        float LookVertical = Input.GetAxis("Mouse Y") * MouseSpeed * Time.deltaTime;
        clamp += LookVertical;
        clamp = Mathf.Clamp(clamp, -15.0f, 5.0f);

        transform.localRotation = Quaternion.Euler(clamp, 0.0f, 0.0f);
    }
}
