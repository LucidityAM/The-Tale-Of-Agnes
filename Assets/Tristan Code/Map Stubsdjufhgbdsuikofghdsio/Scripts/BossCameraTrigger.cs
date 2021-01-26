using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossCameraTrigger : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Room;
    public GameObject Player;
    public GameObject ConfidenceMeter;
    public GameObject Darkness;

    private Vector3 RoomPos;
    private Vector3 OrigPos;

    //Push da camera
    public float xPush;
    public float yPush;

    //Scaler for da camera
    private float speed = 10f;
    public float cameraSize;

    //da camera
    private Camera Cam;

    // Start is called before the first frame update
    void Start()
    {
        RoomPos = new Vector3(Room.transform.position.x + xPush, Room.transform.position.y + yPush, -15f);
        Cam = Camera.GetComponent<Camera>();
        if (Darkness != null)
        {
            Darkness.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Camera.transform.position = Vector3.Lerp(Camera.transform.position, RoomPos, Time.deltaTime * speed);
            Cam.orthographicSize = cameraSize;
            OrigPos = new Vector3(0, 6.23f, 10);
            if(Darkness != null)
            {
                Darkness.SetActive(true);
            }
        }
    }

}
