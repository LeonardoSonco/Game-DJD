using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
	private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
		Vector3 pos = new Vector3(player.transform.position.x, player.transform.position.y, player.transform.position.z);
        offset = transform.position - pos;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
