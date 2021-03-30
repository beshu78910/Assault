using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Controller : MonoBehaviour
{
    [Range (10,20)][SerializeField] private float speed = 20f;
    
    [SerializeField] private float xRange = 7f;

    [SerializeField] private float yRange = 7f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float xOffSet = horizontal * speed * Time.deltaTime;
        float yOffSet = vertical * speed * Time.deltaTime;
        float rOffx = transform.localPosition.x + xOffSet;
        float rOffy = transform.localPosition.y + yOffSet;
        float clampPosx = Mathf.Clamp(rOffx, -xRange, xRange);
        float clampPosy = Mathf.Clamp(rOffy, -yRange, yRange);
        
        transform.localPosition = new Vector3
            (clampPosx ,
            clampPosy, 
            transform.localPosition.z);
    }
}
