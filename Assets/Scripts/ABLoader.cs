using System.Collections;
using UnityEngine;
using UnityEngine.Networking;

public class ABLoader : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChestDownload()
    {
        StartCoroutine(Chest());
    }
    public void ShelfDownload()
    {
        StartCoroutine(Shelf());
    }
    public void TableDownload()
    {
        StartCoroutine(Table());
    }
    public void BarrelDownload()
    {
        StartCoroutine(Barrel());
    }

    IEnumerator Chest()
    {
        UnityWebRequest uwr = UnityWebRequestAssetBundle.GetAssetBundle("https://drive.google.com/uc?export=download&id=19KO47ln4LjvFTahkESdHhIzgrIT9EMpv", 1, 0);
        yield return uwr.SendWebRequest();

        AssetBundle chestBundle = DownloadHandlerAssetBundle.GetContent(uwr);

        AssetBundleRequest loadAsset = chestBundle.LoadAssetAsync("Chest.prefab");
        yield return loadAsset;

        Instantiate(loadAsset.asset);
    }

    IEnumerator Shelf()
    {
        UnityWebRequest uwr = UnityWebRequestAssetBundle.GetAssetBundle("https://drive.google.com/uc?export=download&id=1Ld-MXCZA_bWkhyqP362bHgeuIaUqrcpw", 1, 0);
        yield return uwr.SendWebRequest();

        AssetBundle shelfBundle = DownloadHandlerAssetBundle.GetContent(uwr);

        AssetBundleRequest loadAsset = shelfBundle.LoadAssetAsync("Shelf.prefab");
        yield return loadAsset;

        Instantiate(loadAsset.asset);
    }

    IEnumerator Table()
    {
        UnityWebRequest uwr = UnityWebRequestAssetBundle.GetAssetBundle("https://drive.google.com/uc?export=download&id=1CBZn6sbiki1VGsJtCPQ_UQ3g0KUyzexz", 1, 0);
        yield return uwr.SendWebRequest();

        AssetBundle tableBundle = DownloadHandlerAssetBundle.GetContent(uwr);

        AssetBundleRequest loadAsset = tableBundle.LoadAssetAsync("Table.prefab");
        yield return loadAsset;

        Instantiate(loadAsset.asset);
    }

    IEnumerator Barrel()
    {
        UnityWebRequest uwr = UnityWebRequestAssetBundle.GetAssetBundle("https://drive.google.com/uc?export=download&id=1zpuizu3TMKmJkgQs8Aj97qhVDZAu58nR", 1, 0);
        yield return uwr.SendWebRequest();

        AssetBundle barrelBundle = DownloadHandlerAssetBundle.GetContent(uwr);

        AssetBundleRequest loadAsset = barrelBundle.LoadAssetAsync("Barrel.prefab");
        yield return loadAsset;

        Instantiate(loadAsset.asset);
    }
}
