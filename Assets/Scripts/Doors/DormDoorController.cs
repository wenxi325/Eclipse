using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DormDoorController : MonoBehaviour
{
    [SerializeField] private GameObject door;
    [SerializeField] private GameObject player;
    private bool door_clicked = false;
    void OnMouseDown()
    {
        Debug.Log("dorm_door click!");
        // var door_pos = dorm_door.transform.position;
        // Debug.Log(door_pos);
        Debug.Log(door.tag);
        if(door.tag == "Start_door") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(door.tag == "Lobby_door_up_left") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        else if(door.tag == "Lobby_down_left") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(door.tag == "Secret_door") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        else if(door.tag == "Data_secret") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else if(door.tag == "Data_exit") {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        }
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // var player_size = player.GetComponent<SpriteRenderer>().bounds.size;
        // var player_pos = player.transform.position;
        // Debug.Log("player pos: ");
        // Debug.Log(player_pos);
    }

    // void Update()
    // {

    // }
}