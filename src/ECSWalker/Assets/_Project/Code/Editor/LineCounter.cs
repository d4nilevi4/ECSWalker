using System.IO;
using UnityEditor;
using UnityEngine;

namespace ECSWalker.Editor
{
    public static class LineCounter
    {
        private static ILogger Logger => Debug.unityLogger;
        
        [MenuItem("Tools/⚡⚡⚡ CountLines")]
        private static void CountLines()
        {
            string rootPath = Application.dataPath;

            int totalLines = CountLinesInSolution(Path.Combine(rootPath, "_Project", "Code"));
            Logger.Log("(⌐■_■)",$"Общее количество строк кода в проекте: {totalLines}");
        }

        private static int CountLinesInSolution(string rootPath)
        {
            if (!Directory.Exists(rootPath))
            {
                Logger.LogError("(╯°□°）╯","Указанная папка не найдена.");
                return 0;
            }

            int totalLines = 0;
            
            string[] csFiles = Directory.GetFiles(rootPath, "*.cs", SearchOption.AllDirectories);

            foreach (var file in csFiles)
            {
                try
                {
                    int fileLines = File.ReadAllLines(file).Length;
                    totalLines += fileLines;
                }
                catch (System.Exception ex)
                {
                    Logger.LogWarning("(╯°□°）╯",$"Ошибка при чтении файла {file}: {ex.Message}");
                }
            }

            return totalLines;
        }
    }
}