using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class NEnemyManager : CharacterManager
{
  
    public NEnemyIdleState _NEnemyIdleState= new();
    public NEnemyPartrolState _NEnemyPartrolState= new();
    public NEnemyChaseState _NEnemyChaseState= new();
    public NEnemyAttackState _NEnemyAttackState= new();
    public NEnemyGetHitState _NEnemyGetHitState= new();
    public NormalEnemy _normalEnemy;

  /*  public NEnemyIdleState GetNEnemyIdleState() { return _NEnemyIdleState; }
    public NEnemyAttackState GetNEnemyAttackState() { return _NEnemyAttackState; }
    public NEnemyChaseState GetNEnemyChaseState() { return _NEnemyChaseState;}
    public NEnemyGetHitState GetNEnemyGetHitState() { return _NEnemyGetHitState;}
    public NEnemyPartrolState GetNEnemyPartrolState() { return _NEnemyPartrolState;}*/


    private void Start()
    {
        SetUpProperties();
    }
    protected override void Update()
    {
        base.Update();
    }
    private void SetUpProperties()
    {
        _state = _NEnemyIdleState;
        _state.EnterState(this);
    }

}
