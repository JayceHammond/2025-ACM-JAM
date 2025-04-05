using System.Collections;
using UnityEngine;

public class Shoot : IEnemyCommand{
    private Manager_Enemy EnemyManager;

    public Shoot(Manager_Enemy EnemyManager){
        this.EnemyManager = EnemyManager;
    }

    public void Execute(){

    }

    public void Undo()
    {
        throw new System.NotImplementedException();
    }

    public void Pew(){
        Vector3 snapPlayerPOS = EnemyManager.player.transform.position;

        GameObject newBarb = (GameObject)Resources.Load("Model Route Here");
        newBarb = GameObject.Instantiate(newBarb);

        MonoBehaviour.StartCoroutine(BarbToPosition(newBarb, newBarb.transform.position , snapPlayerPOS));

    }

    IEnumerator BarbToPosition(GameObject barb, Vector3 startPos, Vector3 targetPos){

        for(float t = 0; t< 1; t += Time.deltaTime){
            barb.transform.position = Vector3.Lerp(startPos, targetPos, t);

            yield return null;
        }

        barb.transform.position = targetPos;
    }
}
