using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 8.5f;
    private float Movex;
    private float Movey;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movex = Input.GetAxisRaw("Horizontal");
        Movey = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(Movex, Movey);
        transform.position += direction * speed * Time.deltaTime;
    }
}
