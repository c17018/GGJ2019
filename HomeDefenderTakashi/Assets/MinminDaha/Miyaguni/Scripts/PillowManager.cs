using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillowManager : MonoBehaviour
{
    [SerializeField] private float TagWaitTime;

    private IEnumerator Start()
    {
        // 数秒後にタグを変更(生成したときにPlayerに当たると消えるから、消えないようにするために最初はタグを付けてない)
        yield return new WaitForSeconds(TagWaitTime);
        gameObject.tag = "Pillow";
    }

    private void Update()
    {
        // ステージ外に出て座標が-10より低くなると消える
        if (transform.position.y < -10)
        {
            Destroy(this.gameObject);
        }
    }
}
