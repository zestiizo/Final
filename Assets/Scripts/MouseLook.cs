using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    Vector2 mouseLook;
    [SerializeField] float sensitivity;
    GameObject character;

    // Start is called before the first frame update
    void Start()
    {
        character = this.transform.parent.gameObject;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X");
        float vertical = Input.GetAxis("Mouse Y");

        Vector2 look = new Vector2(horizontal, vertical);
        mouseLook += look * sensitivity;

        mouseLook.y = Mathf.Clamp(mouseLook.y, -80f, 80);

        transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.up);
        character.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, character.transform.up);
    }
}
