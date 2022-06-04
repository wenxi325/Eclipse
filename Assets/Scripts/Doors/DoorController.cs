using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorController : MonoBehaviour
{
    [SerializeField] private GameObject door;
    [SerializeField] private GameObject player;
    // private bool door_clicked = false;
    void OnMouseDown()
    {
        Debug.Log("dorm_door click!");
        Debug.Log(door.tag);
        switch(door.tag) {
            case "Starting_game":
                SceneManager.LoadScene(1);
                break;
            case "exit_btn":
                SceneManager.LoadScene(0);
                break;
            default:
                break;
        }
    }

    private void changeScene()
    {
        switch(door.tag) {
            case "Start_door":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                SoundManager.sfxInstance.Audio.PlayOneShot(SoundManager.sfxInstance.Click);
                break;
            case "Lobby_door_up_left":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                SoundManager.sfxInstance.Audio.PlayOneShot(SoundManager.sfxInstance.Click);
                break;
            case "Lobby_down_left":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                SoundManager.sfxInstance.Audio.PlayOneShot(SoundManager.sfxInstance.Click);
                break;
            case "Lobby_up_right":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                SoundManager.sfxInstance.Audio.PlayOneShot(SoundManager.sfxInstance.Click);
                break;
            case "Secret_door":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                SoundManager.sfxInstance.Audio.PlayOneShot(SoundManager.sfxInstance.Click);
                break;
            case "Data_secret":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                SoundManager.sfxInstance.Audio.PlayOneShot(SoundManager.sfxInstance.Click);
                break;
            case "Data_exit":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
                SoundManager.sfxInstance.Audio.PlayOneShot(SoundManager.sfxInstance.Click);
                break;
            case "Working_exit":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
                SoundManager.sfxInstance.Audio.PlayOneShot(SoundManager.sfxInstance.Click);
                break;
            case "Plant_exit":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
                SoundManager.sfxInstance.Audio.PlayOneShot(SoundManager.sfxInstance.Click);
                break;
            case "Plant_enter":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
                SoundManager.sfxInstance.Audio.PlayOneShot(SoundManager.sfxInstance.Click);
                break;
            case "Starting_game":
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 6);
                SoundManager.sfxInstance.Audio.PlayOneShot(SoundManager.sfxInstance.Click);
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