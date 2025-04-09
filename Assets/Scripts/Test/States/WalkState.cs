// *****************************************************************************
// @author: 绘星tsuki
// @email: xiaoyuesun915@gmail.com
// @creationDate: 2025/03/03 19:03
// @version: 1.0
// @description:
// *****************************************************************************

using HoshiVerseFramework.FSM;
using UnityEngine;

namespace Test.States
{
    public class WalkState : FsmState
    {
        public override bool OnCheck(StateContext context = null)
        {
            return true;
        }

        public override void OnEnter(StateContext context = null)
        {
            Debug.Log("进入walk状态");
        }

        public override void OnUpdate()
        {
        }

        public override void OnFixedUpdate()
        {
        }

        public override void OnExit(StateContext context = null)
        {
            Debug.Log("退出walk状态");
        }
    }
}
