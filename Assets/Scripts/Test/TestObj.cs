// *****************************************************************************
// @author: 绘星tsuki
// @email: xiaoyuesun915@gmail.com
// @creationDate: 2025/03/03 19:03
// @version: 1.0
// @description:
// *****************************************************************************

using System;
using UnityEngine;

namespace Test
{
    public class TestObj : MonoBehaviour
    {
        private void Start()
        {
            Debug.Log(TestManager.Instance.a);
        }
    }
}
