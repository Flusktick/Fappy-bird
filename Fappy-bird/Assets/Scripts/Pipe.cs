using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private float speed = 2;
    [SerializeField] private float timefordestroy =5 ;
    
    private void Start()
    {
        Destroy(gameObject , timefordestroy);
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Translate(-transform.right * speed * Time.deltaTime);
    }
}
