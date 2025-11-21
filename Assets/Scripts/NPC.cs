using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public abstract class NPC : MonoBehaviour, IInteractable
{
    [SerializeField] private SpriteRenderer interactSprite;
    private Transform _playerTransform;
    private const float INTERACT_DISTANCE = 3f;

    public abstract void Interact();
    
    private void Start()
    {
        _playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    private void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame && IsWithinInteractDistance())
        {
            Interact();
        }

        if (interactSprite.gameObject.activeSelf && !IsWithinInteractDistance())
        {
            interactSprite.gameObject.SetActive(false);
        }
        else if(!interactSprite.gameObject.activeSelf && IsWithinInteractDistance())
        {
            interactSprite.gameObject.SetActive(true);
        }
    }

    private bool IsWithinInteractDistance()
    {
        if (Vector2.Distance(_playerTransform.position, transform.position) <= INTERACT_DISTANCE)
        {
            return true;
        }
        return false;
    }
}