using UnityEngine;
using System.Collections;

public class Boss
{
    private int mp = 53;          // 魔力
    // 魔法用の関数
    public void Magic(int syouhi)
    {
        if (mp >= syouhi)
        {
            // 残りmpを減らす
            this.mp -= syouhi;
            // MPの値が消費以上の場合、文字列を表示する
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない"); ;
        }

    }

}

public class kadai2 : MonoBehaviour
{

    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();
        // 11回処理を繰り返す
        for (int i = 0; i <= 10; i++)
        {

            // 魔法用の関数を呼び出す
            lastboss.Magic(5);

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}