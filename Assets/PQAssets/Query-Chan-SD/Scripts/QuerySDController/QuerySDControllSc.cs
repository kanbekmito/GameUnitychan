using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuerySDControllSc : MonoBehaviour
{

    [SerializeField]
    public GameObject EnemyPrefab;  // Prefabをインスペクタで設定

    void Start()
    {
        StartCoroutine(CreateEnemyCoroutine());
    }

    IEnumerator CreateEnemyCoroutine()
    {
        //1-50個の中から適当に作る
        var count = UnityEngine.Random.Range(1, 50);
        for (var i = 0; i < count; i++)
        {
            //敵を作る
            CreateEnemy();

            //2-5秒待つ
            yield return new WaitForSeconds(UnityEngine.Random.Range(10, 30));
        }
    }

    void CreateEnemy()
    {
        // 生成する座標をランダムに設定
        int x = UnityEngine.Random.Range(-930, -200);
        int y = UnityEngine.Random.Range(10, 100);
        int z = UnityEngine.Random.Range(-660, -100);

        //オブジェクトを生成
        GameObject.Instantiate(EnemyPrefab, new Vector3(x, y, z), Quaternion.identity);
    }
}
