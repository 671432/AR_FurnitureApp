using UnityEngine;
using UnityEditor;

public class ABCreator : Editor
{
    [MenuItem("Assets/Build Asset Bundles")]
    static void BuildAll()
    {
        BuildPipeline.BuildAssetBundles("/Users/justi/Desktop/unity assets/BundleFiles", BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.Android);
    }
}
