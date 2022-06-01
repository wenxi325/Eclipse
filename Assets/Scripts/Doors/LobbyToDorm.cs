using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LobbyToDorm : MonoBehaviour
{
    // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
    [SerializeField] private GameObject main_door;
    [SerializeField] private GameObject player;
    private bool door_clicked = false;
    void OnMouseDown()
    {
        Debug.Log("dorm_door click!");
        var door_pos = main_door.transform.position;
        Debug.Log(door_pos);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        // var player_size = player.GetComponent<SpriteRenderer>().bounds.size;
        // var player_pos = player.transform.position;
        // Debug.Log("player pos: ");
        // Debug.Log(player_pos);
    }
}
