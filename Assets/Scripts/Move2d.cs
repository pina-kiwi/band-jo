using UnityEngine;

public class Move2D : MonoBehaviour
{
    public float Speed = 6f;
    public Animator Animator;
    public SpriteRenderer SpriteRenderer;
    public KeyboardInput KeyboardInput;
    public GamepadInput GamepadInput;
    

    private Vector2 currentMovementInput;
    public Rigidbody2D rigidBody2D; 
    private Vector2 moveInput;
    private Animator animator;

    private void Awake()
    {
        InitializeComponents();
    }

    public void Update()
    {
        GetCombinedInput();
        UpdateAnimator();
        UpdateSpriteDirection();
        ApplyMovement();
    }

    public void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    
    // Auto-assigns component references if they weren't set in the Inspector
    private void InitializeComponents()
    {
        if (SpriteRenderer == null)
            SpriteRenderer = GetComponent<SpriteRenderer>();
        
        if (Animator == null)
            Animator = GetComponent<Animator>();
        
        if (KeyboardInput == null)
            KeyboardInput = GetComponent<KeyboardInput>();
        
        if (GamepadInput == null)
            GamepadInput = GetComponent<GamepadInput>();
    }

    // Gamepad input takes priority over keyboard when active
    private void GetCombinedInput()
    {
        Vector2 keyboardMovement = GetKeyboardMovement();
        Vector2 gamepadMovement = GetGamepadMovement();
        
        if (HasGamepadInput(gamepadMovement))
            currentMovementInput = gamepadMovement;
        else
            currentMovementInput = keyboardMovement;
    }

    private Vector2 GetKeyboardMovement()
    {
        if (KeyboardInput == null)
            return Vector2.zero;
        
        return KeyboardInput.GetMovement();
    }

    private Vector2 GetGamepadMovement()
    {
        if (GamepadInput == null)
            return Vector2.zero;
        
        return GamepadInput.GetMovement();
    }

    private bool HasGamepadInput(Vector2 gamepadMovement)
    {
        return gamepadMovement.sqrMagnitude > 0f;
    }

    private void UpdateAnimator()
    {
        if (Animator == null)
            return;

        // -----------------------------
        // 1. LIVE MOVEMENT INPUT
        // -----------------------------
        float x = currentMovementInput.x;
        float y = currentMovementInput.y;

        bool isMoving = x != 0 || y != 0;
        Animator.SetBool("IsWalking", isMoving);

        // Always update InputX/Y for the blend tree
        Animator.SetFloat("InputX", x);
        Animator.SetFloat("InputY", y);

        // -----------------------------
        // 2. SAVE LAST DIRECTION (for idle)
        // -----------------------------
        if (isMoving)
        {
            // Normalize so that diagonals give about (.7, .7)
            Vector2 normalized = currentMovementInput.normalized;
            Animator.SetFloat("LastInputX", normalized.x);
            Animator.SetFloat("LastInputY", normalized.y);
        }
    }
    
    private bool IsMoving()
    {
        return currentMovementInput.sqrMagnitude > 0f;
    }

    // Flips sprite horizontally based on movement direction (doesn't flip for vertical-only movement)
    private void UpdateSpriteDirection()
    {
        if (SpriteRenderer == null)
            return;
    }

    private bool IsMovingLeft()
    {
        return currentMovementInput.x < 0f;
    }

    private bool IsMovingRight()
    {
        return currentMovementInput.x > 0f;
    }

    // Directly modifies transform.position (not using physics)
    public void ApplyMovement()
    {
        Vector3 movementDelta = CalculateMovementDelta();
        transform.position = transform.position + movementDelta;
    }

    // Multiplies by Time.deltaTime for frame-rate independent movement
    private Vector3 CalculateMovementDelta()
    {
        return (Vector3)(currentMovementInput * Speed * Time.deltaTime);
    }
}