using GF.Fsm;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Owner = GF.Fsm.IFsm<Actor>;

public class Actor
{
    private IFsm<Actor> m_Fsm = null;

    private StandState m_StandState;
    private WalkState m_WalkState;

    public Actor(FsmComponent fsm)
    {
        m_StandState = new StandState();
        m_WalkState = new WalkState();
        m_Fsm = fsm.CreateFsm("ActorFsm", this, m_StandState, m_WalkState);
    }

    public void StartState()
    {
        m_Fsm.Start(m_StandState.GetType());
    }
}

public class StandState : FsmState<Actor>
{
    protected override void OnInit(IFsm<Actor> fsm)
    {
        base.OnInit(fsm);

        Debug.Log("Stand State Init.");
    }

    protected override void OnDestroy(IFsm<Actor> fsm)
    {
        base.OnDestroy(fsm);

        Debug.Log("Stand State Destroy.");
    }

    protected override void OnEnter(IFsm<Actor> fsm)
    {
        base.OnEnter(fsm);
        
        Debug.Log("Stand State Enter");

        // Change State
        ChangeState<WalkState>(fsm);
    }

    protected override void OnLeave(IFsm<Actor> fsm, bool isShutdown)
    {
        base.OnLeave(fsm, isShutdown);

        Debug.Log("Stand State Leave");
    }

    protected override void OnUpdate(IFsm<Actor> fsm, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);

        //Debug.Log("Stand State Update");
    }
}

public class WalkState : FsmState<Actor>
{
    protected override void OnInit(IFsm<Actor> fsm)
    {
        base.OnInit(fsm);

        Debug.Log("Walk State Init.");
    }

    protected override void OnDestroy(IFsm<Actor> fsm)
    {
        base.OnDestroy(fsm);

        Debug.Log("Walk State Destroy.");
    }

    protected override void OnEnter(IFsm<Actor> fsm)
    {
        base.OnEnter(fsm);

        Debug.Log("Walk State Enter");
    }

    protected override void OnLeave(IFsm<Actor> fsm, bool isShutdown)
    {
        base.OnLeave(fsm, isShutdown);

        Debug.Log("Walk State Leave");
    }

    protected override void OnUpdate(IFsm<Actor> fsm, float elapseSeconds, float realElapseSeconds)
    {
        base.OnUpdate(fsm, elapseSeconds, realElapseSeconds);

        //Debug.Log("Walk State Update");
    }
}

public class GFFsmTest : MonoBehaviour
{

    private FsmComponent _mFsmComponent;

    private Actor _mActor;

    private void Start()
    {
        _mFsmComponent = GetComponent<FsmComponent>();

        _mActor = new Actor(_mFsmComponent);

        _mActor.StartState();

    }
}
