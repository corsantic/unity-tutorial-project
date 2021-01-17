using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Debug.Log(horizontal);
        float horizontalSpeed = 3.0f;
        float verticalSpeed = 3.0f;
        Debug.Log(vertical);
        Vector2 position = transform.position;
        position.x = position.x + horizontalSpeed * horizontal * Time.deltaTime;
        position.y = position.y + verticalSpeed * vertical * Time.deltaTime;
        transform.position = position;
    }
}
