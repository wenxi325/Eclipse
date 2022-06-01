using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// using Captain.Command;

public class PlayerController : MonoBehaviour
{

    private float horizontal;
    private float vertical;
    private float MoveSpeed = 1000;

    private int curHealth;

    Rigidbody2D rigidbody; 

    Vector2 Player_Move;
    // Start is called before the first frame update
    void Start()
    {
    
        Application.targetFrameRate = 60;
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + MoveSpeed * h * Time.deltaTime;
        position.y = position.y + MoveSpeed * v * Time.deltaTime;
        rigidbody.MovePosition(position); 
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        // if(collision.tag == "start_door")
        // {
        //     Debug.Log("here");
        //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // }
        // else if(collision.tag == "lobby_door_up_left")
        // {
        //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        // }
    }
}