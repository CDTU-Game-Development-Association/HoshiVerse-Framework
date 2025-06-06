﻿// *****************************************************************************
// @author: 绘星tsuki
// @email: xiaoyuesun915@gmail.com
// @creationDate: 2025/03/03 19:03
// @version: 1.0
// @description:
// *****************************************************************************

using System.Collections.Generic;
using UnityEngine;

namespace HoshiVerseFramework.FSM
{
    /// <summary>
    /// 状态机Unity挂载脚本组件，自动添加本物体下所有的statesList中的状态
    /// </summary>
    public class FsmComponent : MonoBehaviour
    {
        public List<FsmState> statesList = new();

        public Fsm FsmStateMachine { get; } = new();

        protected virtual void Start()
        {
            foreach (FsmState state in statesList)
            {
                FsmStateMachine.AddState(state.StateType, state);
                if (state.IsDefaultState)
                    FsmStateMachine.SwitchState(state.StateType);
            }
        }

        protected virtual void Update()
        {
            FsmStateMachine.curState.OnUpdate();
        }

        protected virtual void FixedUpdate()
        {
            FsmStateMachine.curState.OnFixedUpdate();
        }
    }
}
