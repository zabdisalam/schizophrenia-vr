using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class TeleportController : MonoBehaviour
{
    public GameObject baseControllerGameObject;
    public GameObject teleportationGameObject;

    public bool hasTeleported = false;
    public GameObject playerObj = null;
    public GameObject teleportReticle = null;

    public InputActionReference teleportActivationReference;
    [Space]
    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancel;

    private TimelinePlayer pedestrianTimeLine;
    private GameObject pedestrian = null;

    private void Start()
    {
        if (playerObj == null)
        {
            playerObj = GameObject.Find("XR Origin");
            teleportReticle = GameObject.Find("SimpleTeleportTarget_circle_3");
            pedestrian = GameObject.Find("Pedestrian");
            pedestrian.SetActive(false);

        }
        teleportActivationReference.action.performed += TeleportModeActivate;
        teleportActivationReference.action.canceled += TeleportModeCancel;
    }
    private void Update()
    {
        // Debug.Log("Player Position: X = " + playerObj.transform.position.x + " --- Y = " + playerObj.transform.position.y + " --- Z = " +
        //  playerObj.transform.position.z);
        if ((playerObj.transform.position.x >= -290.4 && -288.4 >= playerObj.transform.position.x) && (playerObj.transform.position.y >= 68.86 && 70.86 >= playerObj.transform.position.y))
        {
            teleportReticle.SetActive(false);
            hasTeleported = true;
            pedestrian.SetActive(true);
            pedestrianTimeLine.StartTimeline();
        }
    }

    private void TeleportModeActivate(InputAction.CallbackContext obj)
    {
        if (!hasTeleported)
            onTeleportActivate.Invoke();
    }
    private void TeleportModeCancel(InputAction.CallbackContext obj) => Invoke("DeactivateTeleporter", .1f);

    void DeactivateTeleporter() => onTeleportCancel.Invoke();
}

//-289.4 -> -288.4