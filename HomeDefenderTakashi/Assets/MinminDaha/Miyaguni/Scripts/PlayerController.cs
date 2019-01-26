using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Text pillowCountText;

    Rigidbody playerRB;
    CapsuleCollider playerCapsuleCollider;

    [SerializeField] private GameObject playerPillow;

    [SerializeField] private Vector3 pillowInstantiatePosision;
    
    [SerializeField] private float playerSpeed;
    [SerializeField] private float pillowSpeed;

    int pillowCount = 3;

    [SerializeField] private int initPillowCount;

    private void Awake()
    {
        playerRB = GetComponent<Rigidbody>();
        playerCapsuleCollider = GetComponent<CapsuleCollider>();
    }

    private void Start()
    {
        pillowCount = 3;
        pillowCountText.text = pillowCount.ToString();
    }

    private void Update()
    {
        Move();

        if(Input.GetMouseButtonDown(0) && pillowCount > 0)
        {
            throwPillow();
        }
    }

    // 移動処理
    private void Move()
    {
        // 方向キーの入力値とカメラの向きから、移動方向を決定
        Vector3 moveForward = Vector3.forward * GetMoveDirection().z + Vector3.right * GetMoveDirection().x;
        // 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
        playerRB.velocity += (moveForward * playerSpeed);

        // キャラクターの向きを進行方向に
        if (moveForward != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveForward);
        }
    }

    // 移動方向取得
    public Vector3 GetMoveDirection()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        return new Vector3(x, 0, z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Pillow")
        {
            pillowCount++;
            Destroy(other.gameObject);
            Debug.Log(pillowCount);
            pillowCountText.text = pillowCount.ToString();
        }
    }

    private void throwPillow()
    {
        GameObject pillow = Instantiate(playerPillow, transform.position + pillowInstantiatePosision, Quaternion.identity);
        Rigidbody pillowRB = pillow.GetComponent<Rigidbody>();
        pillowRB.AddForce(transform.forward * pillowSpeed, ForceMode.VelocityChange);
        pillowCount--;
        Debug.Log(pillowCount);
        pillowCountText.text = pillowCount.ToString();
    }
}
