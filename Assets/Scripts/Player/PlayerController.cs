
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform checkGround;
    

    [SerializeField] private float moveSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private LayerMask layerGround;

    
    private Rigidbody rb;
    private Animator animator;

    private Vector3 movementDirection = Vector3.zero;


    private bool isDie = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

        PlayerEvent.sentPlayerControl?.Invoke(this);    
    }



    private void Update()
    {
        if (IsDie())
        {
            ProcessPlayerDie();
           
           
        }
        else
        {
            GetInputKeyBoard();
           
            SetAnimation();
        }


       

        
    }

    private void ProcessPlayerDie()
    {
        if (!isDie)
        {
            ManagerSound.Instance.PlaySoundSFX(EnumSound.Dead);
            PlayerEvent.playerDieEnvent?.Invoke();
            animator.SetTrigger(AnimationString.IsDie2);
            isDie = true;
            
        }
        if (transform.position.y < -15.5f)
        {
            CameraEvent.camPlayerDie?.Invoke();
        }
       

    }

    public void GetInputKeyBoard()
    {
        //float dirX = -Input.GetAxisRaw("Vertical");
        //float dirZ = Input.GetAxisRaw("Horizontal");
        //movementDirection.x = dirX;
        //movementDirection.z = dirZ;
        //OnPlayerMove();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnPlayerJump();

        }



    }


    public void OnPlayerMove()
    {
        if (!IsGrounded()) return;

        
        float move = movementDirection.magnitude;
        
        if(move >= 0.1)
        {
            rb.velocity = movementDirection * moveSpeed;
        }

        
        

    }
    public void OnPlayerJump()
    {
        if (IsGrounded())
        {
            rb.AddForce(new Vector3(0, 1* jumpForce, movementDirection.z*moveSpeed) );
            ManagerSound.Instance.PlaySoundSFX(EnumSound.Jump);
        }
        
    }
    private void SetAnimation()
    {
        if (!IsGrounded())
        {
            animator.SetBool(AnimationString.IsJump, true);
        }
        else
        {
            animator.SetBool(AnimationString.IsJump, false);
            animator.SetFloat(AnimationString.IsMove, movementDirection.magnitude);
        }
    }

    public bool IsGrounded()
    {
        return Physics.CheckBox(checkGround.position, new Vector3(0.2f, 0.05f, 0.2f), Quaternion.identity, layerGround);
    }

    public bool IsDie()
    {
        return transform.position.y < -0.5;
    }


    public void SetDirectionMovement(Vector2 dir)
    {
        this.movementDirection.x = dir.x;   
        this.movementDirection.z = dir.y;
        OnPlayerMove();
       
    }




}
