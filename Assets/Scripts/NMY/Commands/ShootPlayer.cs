using UnityEngine;

//Shoots the player if they are in range and in sight
public class ShootPlayer : IEnemyCommand{

    private Manager_Enemy EnemyManager;

    public object player;
    public Enemy Enemy;

    public ShootPlayer(Manager_Enemy EnemyManager){
        this.EnemyManager = EnemyManager;
    }

    public void Execute(){
        if(player.distance(Enemy) < Enemy.Sight_Range){
            //Try to shoot Player
        }
    }

    public void Undo()
    {
        throw new System.NotImplementedException();
    }
}
