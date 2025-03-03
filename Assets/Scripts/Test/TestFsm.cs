// *****************************************************************************
// @author: 绘星tsuki
// @email: xiaoyuesun915@gmail.com
// @creationDate: 2025/03/03 19:03
// @version: 1.0
// @description:
// *****************************************************************************

using System;
using HoshiVerseFramework.Base.FSM;
using Test.States;
using UnityEngine;

namespace Test
{
    public class TestFsm : FsmComponent
    {
        protected override void Update()
        {
            base.Update();
            FsmStateMachine.SwitchState("Idle");
        }
    }
}
