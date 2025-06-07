using System.Collections;
using UnityEngine;

namespace ECSWalker.Infrastructure
{
    public interface ICoroutineRunner
    {
        Coroutine StartCoroutine(IEnumerator load);
    }
}