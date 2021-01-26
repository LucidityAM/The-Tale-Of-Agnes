using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowTrigger : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Player;
    public GameObject Darkness;
    public Camera MainCamera;

    private Vector2 velocity;

    public float smoothTimeY;
    public float smoothTimeX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Darkness.SetActive(true);
            if (MainCamera != null)
            {
                MainCamera.orthographicSize = 7;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            Darkness.SetActive(false);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            float posX = Mathf.SmoothDamp(Camera.transform.position.x, Player.transform.position.x, ref velocity.x, smoothTimeX);
            float posY = Mathf.SmoothDamp(Camera.transform.position.y, Player.transform.position.y, ref velocity.y, smoothTimeY);

            Camera.transform.position = new Vector3(posX, posY, Camera.transform.position.z);
            if (MainCamera != null)
            {
                MainCamera.orthographicSize = 7;
            }
        }
    }
}
