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
        // 枕の初期数を定義
        pillowCount = initPillowCount;
        // 枕残数テキストを更新
        pillowCountText.text = "まくらの数: " + pillowCount.ToString();
    }

    private void Update()
    {
        // 動きの更新
        Move();

        // クリックしたときに枕を飛ばす処理を読み込む
        if(Input.GetMouseButtonDown(1) && pillowCount > 0)
        {
            throwPillow();
        }
    }

    // 移動処理
    private void Move()
    {
        // 方向キーの入力で、移動方向を決定
        Vector3 moveForward = Vector3.forward * GetMoveDirection().z + Vector3.right * GetMoveDirection().x;
        // 移動方向にスピードを掛ける
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
        // 入力受け取り
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        return new Vector3(x, 0, z);
    }

    private void OnTriggerEnter(Collider other)
    {
        // 枕回収処理
        if(other.gameObject.tag == "Pillow")
        {
            //落ちてる枕を消す
            Destroy(other.gameObject);
            // 枕残数の更新
            pillowCount++;
            pillowCountText.text = "まくらの数: " + pillowCount.ToString();
        }
    }

    // 枕を投げる処理
    private void throwPillow()
    {
        // 枕を生成
        GameObject pillow = Instantiate(playerPillow, transform.position + pillowInstantiatePosision, Quaternion.identity);
        // 生成した枕の物理演算を参照
        Rigidbody pillowRB = pillow.GetComponent<Rigidbody>();
        // 枕を前方に飛ばす
        pillowRB.AddForce(transform.forward * pillowSpeed, ForceMode.VelocityChange);
        // 枕残数を更新
        pillowCount--;
        pillowCountText.text = "まくらの数: " + pillowCount.ToString();
    }
}
