// *****************************************************************************
// @author: 绘星tsuki
// @email: xiaoyuesun915@gmail.com
// @creationDate: 2025/04/09 15:04
// @version: 1.0
// @description:
// *****************************************************************************

using System;
using System.Collections;
using HoshiVerseFramework.Components.Factory;
using HoshiVerseFramework.Configs;
using UnityEngine;

namespace Test
{
    public class TestCall : MonoBehaviour
    {
        [SerializeField] private VFXPoolConfigList configs;
        private FactoryComponent factory;

        private void Awake()
        {
            factory = new FactoryComponent(configs);
        }

        private void Start()
        {
            StartCoroutine(TTest());
        }

        private IEnumerator TTest()
        {
            yield return TestCallMethod(() =>
            {
                factory.CreateVFX(VFXType.Test).Play();
            });
        }

        private IEnumerator TestCallMethod(Action action, float interval = 1f)
        {
            yield return new WaitForSeconds(interval);
            action?.Invoke();
        }
    }
}
