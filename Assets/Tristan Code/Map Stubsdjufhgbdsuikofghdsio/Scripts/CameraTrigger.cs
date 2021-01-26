using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Room;
    public GameObject Player;

    private Vector3 RoomPos;

    private float speed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        RoomPos = new Vector3(Room.transform.position.x, Room.transform.position.y, -10);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnCollisionStay2D(Collider2D collision)
    //{
    //    if(collision.gameObject.tag == "player")
    //    {
    //        Camera.transform.position = Vector3.Lerp(Camera.transform.position, RoomPos, Time.deltaTime * speed);
    //    }
    //}


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Camera.transform.position = Vector3.Lerp(Camera.transform.position, RoomPos, Time.deltaTime * speed);
        }
    }
}
