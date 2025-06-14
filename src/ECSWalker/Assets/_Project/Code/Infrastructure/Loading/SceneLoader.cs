﻿using Cysharp.Threading.Tasks;
using UnityEngine.SceneManagement;

namespace ECSWalker.Infrastructure
{
    public class SceneLoader : ISceneLoader
    {
        public async UniTask LoadSceneAsync(string name)
        {
            await SceneManager.LoadSceneAsync(name).ToUniTask();
        }
    }
}