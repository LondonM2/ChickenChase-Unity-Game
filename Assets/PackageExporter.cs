using UnityEngine;
using UnityEditor;

public class PackageExporter
{
    [MenuItem("Tools/Export ChickenChase Package")]
    public static void ExportPackage()
    {
        AssetDatabase.ExportPackage(
            "Assets",
            "Medley_ChickenChase_Project4.unitypackage",
            ExportPackageOptions.Recurse
        );

        Debug.Log("Unity package exported successfully!");
    }
}