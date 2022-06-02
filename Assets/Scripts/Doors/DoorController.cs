using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
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
        switch(door.tag) {
            case "Start_door":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case "Lobby_door_up_left":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                break;
            case "Lobby_down_left":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case "Lobby_up_right":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                break;
            case "Secret_door":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                break;
            case "Data_secret":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case "Data_exit":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
                break;
            case "Working_exit":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                break;
            case "Plant_exit":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
                break;
            case "Plant_enter":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
                break;
            case "Starting_game":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
                break;
            default:
                break;
        }
        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // var player_size = player.GetComponent<SpriteRenderer>().bounds.size;
        // var player_pos = player.transform.position;
        // Debug.Log("player pos: ");
        // Debug.Log(player_pos);
    }
    private void changeScene()
    {
        switch(door.tag) {
            case "Start_door":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case "Lobby_door_up_left":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                break;
            case "Lobby_down_left":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case "Lobby_up_right":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                break;
            case "Secret_door":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                break;
            case "Data_secret":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                break;
            case "Data_exit":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
                break;
            case "Working_exit":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                break;
            case "Plant_exit":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
                break;
            case "Plant_enter":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
                break;
            case "Starting_game":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
                break;
            default:
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision);
        changeScene();
    }
}