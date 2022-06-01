using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DormDoorController : MonoBehaviour
{
    [SerializeField] private GameObject dorm_door;
    [SerializeField] private GameObject player;
    private bool door_clicked = false;
    void OnMouseDown()
    {
        Debug.Log("dorm_door click!");
        var door_pos = dorm_door.transform.position;
        Debug.Log(door_pos);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // var player_size = player.GetComponent<SpriteRenderer>().bounds.size;
        // var player_pos = player.transform.position;
        // Debug.Log("player pos: ");
        // Debug.Log(player_pos);
    }

    // void Update()
    // {

    // }
}