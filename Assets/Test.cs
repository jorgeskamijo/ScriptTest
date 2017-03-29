using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        // 配列を初期化する
        int[] array = { 30, 50, 80, 60, 100 };

        // 配列の要素数のぶんだけ処理を繰り返す
        for (int i = 0; i < array.Length; i++)
        {
         
                // 配列の要素を表示する
                Debug.Log(array[i]);
            
        }
        // 配列の要素数のぶんだけ処理を繰り返す
        for (int t = 4; t >= 0; t--)
        {

            // 配列の要素を表示する
            Debug.Log(array[t]);

        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
