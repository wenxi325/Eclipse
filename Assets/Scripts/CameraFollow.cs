using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // public GameObject target;
    public float speed = 0.75f;

    private Vector3 targetPosition;
    [SerializeField] private GameObject target;

    // void Awake()
    // {
    //     this.target.transform.position = this.transform.position;
    // }

    void Start()
    {
        this.targetPosition = this.transform.position;
    }
    
    void FixedUpdate()
    {
        // var transPos = player.transform.position;
        // if (this.target)
        // {
        //     var from = new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z);
        //     var to = new Vector3(this.target.transform.position.x, this.transform.position.y, this.transform.position.z);
        //     transform.position = Vector3.Lerp(from, to, this.speed);
        // }
    }
}