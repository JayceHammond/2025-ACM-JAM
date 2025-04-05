using System.Collections.Generic;
using UnityEngine;

public class Invoker_Enemy : MonoBehaviour{
    
    Stack<IEnemyCommand> _CommandList;
    
    public Invoker_Enemy(){
        _CommandList = new Stack<IEnemyCommand>();
    }

    public void AddCommand(IEnemyCommand newCommand){
        newCommand.Execute();
        _CommandList.Push(newCommand);
    }

    public void RemoveCommand(){
        IEnemyCommand lastCommand = _CommandList.Pop();
        lastCommand.Undo();
    }

}
