using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillowManager : MonoBehaviour
{
    [SerializeField] private float tagWaitTime;
    [SerializeField] private float lifeTime = 5.0f;

    private IEnumerator Start()
    {
        // 数秒後にタグを変更(生成したときにPlayerに当たると消えるから、消えないようにするために最初はタグを付けてない)
        yield return new WaitForSeconds(tagWaitTime);
        gameObject.tag = "Pillow";
    }

    private void Update()
    {
        lifeTime -= Time.deltaTime;
        if(lifeTime < 0.0f)
        {
            Destroy(gameObject);
        }
        // ステージ外に出て座標が-10より低くなると消える
        if (transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }
    }
}
