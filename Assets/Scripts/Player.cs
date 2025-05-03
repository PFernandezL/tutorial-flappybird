using UnityEngine;
using UnityEngine.InputSystem;

public class Player :MonoBehaviour
{
    public float velocity = 2.4f;
    private Rigidbody2D rigidbody;
    private PlayerInputActions inputActions;



    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }


    private void Awake()
    {
        inputActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        inputActions.Enable();
        inputActions.Gameplay.Tap.performed += OnTap;
    }

    private void OnDisable()
    {
        inputActions.Gameplay.Tap.performed -= OnTap;
        inputActions.Disable();
    }

    private void OnTap(InputAction.CallbackContext context)
    {
        rigidbody.linearVelocity = Vector2.up * velocity;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Mouse.current.leftButton.wasPressedThisFrame)
    //    {
    //        Debug.Log("Pressed left-click.");
    //        rigidbody.linearVelocity = Vector2.up * velocity;
    //    }
    //}
}
