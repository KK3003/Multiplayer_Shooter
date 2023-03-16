using UnityEngine;

public class PlayerGroundCheck : MonoBehaviour
{
    PlayerController playeraController;

    private void Awake()
    {
        playeraController = GetComponentInParent<PlayerController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == playeraController.gameObject)
        {
            return;
        }
        playeraController.SetGroundedState(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == playeraController.gameObject)
        {
            return;
        }
        playeraController.SetGroundedState(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject == playeraController.gameObject)
        {
            return;
        }
        playeraController.SetGroundedState(true);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == playeraController.gameObject)
        {
            return;
        }
        playeraController.SetGroundedState(true);
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject == playeraController.gameObject)
        {
            return;
        }
        playeraController.SetGroundedState(false);
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject == playeraController.gameObject)
        {
            return;
        }
        playeraController.SetGroundedState(true);
    }
}

