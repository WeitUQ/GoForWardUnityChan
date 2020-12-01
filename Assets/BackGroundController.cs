using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundController : MonoBehaviour
{
    private float scrollSpeed = -1;
    private float deadLine = -17.2f;
    private float startLine = 15.8f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(this.scrollSpeed * Time.deltaTime, 0, 0);
            if (this.transform.position.x < this.deadLine)
        {
            this.transform.position = new Vector2(this.startLine, 0);
        }
    }
}
