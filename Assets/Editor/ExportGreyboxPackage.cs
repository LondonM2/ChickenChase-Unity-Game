
using UnityEngine;
using UnityEditor;

public static class ExportGreyboxPackage
{
    [MenuItem("Tools/Export Greybox Package")]
    public static void Export()
    {
        AssetDatabase.ExportPackage(
            new string[] { "Assets" },
            "ChickenRun_Project2_Greybox.unitypackage",
            ExportPackageOptions.Recurse |
            ExportPackageOptions.IncludeDependencies
        );

        Debug.Log("Greybox package exported!");
    }
}
