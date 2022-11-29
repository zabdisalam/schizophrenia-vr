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
    public GameObject remy;

    public InputActionReference teleportActivationReference;
    [Space]
    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancel;

    private TimelinePlayer pedestrianTimeLine;
    private GameObject pedestrian;


    private void Start()
    {
        if (playerObj == null)
        {
            pedestrianTimeLine = GameObject.Find("Timeline").GetComponent<TimelinePlayer>();

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
        if (((int)playerObj.transform.position.x == (int)teleportReticle.transform.position.x)
            && ((int)playerObj.transform.position.y == (int)teleportReticle.transform.position.y) && !hasTeleported)
        {
            teleportReticle.SetActive(false);
            hasTeleported = true;
            pedestrian.SetActive(true);
            pedestrianTimeLine.StartTimeline();
        }
    }

    private void TeleportModeActivate(InputAction.CallbackContext obj)
    {
        if (!hasTeleported || !remy.activeSelf)
            onTeleportActivate.Invoke();
    }
    private void TeleportModeCancel(InputAction.CallbackContext obj) => Invoke("DeactivateTeleporter", .1f);

    void DeactivateTeleporter() => onTeleportCancel.Invoke();
}

//-289.4 -> -288.4