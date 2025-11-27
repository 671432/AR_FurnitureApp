using System.Collections;
using Lean.Common;
using UnityEngine;
using UnityEngine.Networking;

public class ABLoader : MonoBehaviour
{

    GameObject chestObj;
    GameObject shelfObj;
    GameObject tableObj;
    GameObject barrelObj;
    public GameObject focusCircleObj;
    public GameObject chestDLButton;
    public GameObject shelfDLButton;
    public GameObject tableDLButton;
    public GameObject barrelDLButton;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(PlayerPrefs.GetString("isChestDownloaded") == "yes")
        {
            StartCoroutine(Chest());
        }

        if(PlayerPrefs.GetString("isShelfDownloaded") == "yes")
        {
            StartCoroutine(Shelf());
        }

        if(PlayerPrefs.GetString("isTableDownloaded") == "yes")
        {
            StartCoroutine(Table());
        }

        if(PlayerPrefs.GetString("isBarrelDownloaded") == "yes")
        {
            StartCoroutine(Barrel());
        }
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
        UnityWebRequest uwr = UnityWebRequestAssetBundle.GetAssetBundle("https://github.com/671432/AR_FurnitureApp/raw/refs/heads/main/AssetBundles/chestbundle", 2, 0);
        yield return uwr.SendWebRequest();

        AssetBundle chestBundle = DownloadHandlerAssetBundle.GetContent(uwr);

        AssetBundleRequest loadAsset = chestBundle.LoadAssetAsync("Chest.prefab");
        yield return loadAsset;

        chestObj = (GameObject)Instantiate(loadAsset.asset);

        chestObj.SetActive(false);

        focusCircleObj.GetComponent<ARFocusCircle>().virtual_objects[0] = chestObj;

        PlayerPrefs.SetString("isChestDownloaded", "yes");

        chestDLButton.SetActive(false);
    }

    IEnumerator Shelf()
    {
        UnityWebRequest uwr = UnityWebRequestAssetBundle.GetAssetBundle("https://github.com/671432/AR_FurnitureApp/raw/refs/heads/main/AssetBundles/shelfbundle", 2, 0);
        yield return uwr.SendWebRequest();

        AssetBundle shelfBundle = DownloadHandlerAssetBundle.GetContent(uwr);

        AssetBundleRequest loadAsset = shelfBundle.LoadAssetAsync("Shelf.prefab");
        yield return loadAsset;

        shelfObj = (GameObject)Instantiate(loadAsset.asset);

        shelfObj.SetActive(false);

        focusCircleObj.GetComponent<ARFocusCircle>().virtual_objects[1] = shelfObj;

        PlayerPrefs.SetString("isShelfDownloaded", "yes");

        shelfDLButton.SetActive(false);
    }

    IEnumerator Table()
    {
        UnityWebRequest uwr = UnityWebRequestAssetBundle.GetAssetBundle("https://github.com/671432/AR_FurnitureApp/raw/refs/heads/main/AssetBundles/tablebundle", 2, 0);
        yield return uwr.SendWebRequest();

        AssetBundle tableBundle = DownloadHandlerAssetBundle.GetContent(uwr);

        AssetBundleRequest loadAsset = tableBundle.LoadAssetAsync("Table.prefab");
        yield return loadAsset;

        tableObj = (GameObject)Instantiate(loadAsset.asset);

        tableObj.SetActive(false);

        focusCircleObj.GetComponent<ARFocusCircle>().virtual_objects[2] = tableObj;

        PlayerPrefs.SetString("isTableDownloaded", "yes");

        tableDLButton.SetActive(false);
    }

    IEnumerator Barrel()
    {
        UnityWebRequest uwr = UnityWebRequestAssetBundle.GetAssetBundle("https://github.com/671432/AR_FurnitureApp/raw/refs/heads/main/AssetBundles/barrelbundle", 2, 0);
        yield return uwr.SendWebRequest();

        AssetBundle barrelBundle = DownloadHandlerAssetBundle.GetContent(uwr);

        AssetBundleRequest loadAsset = barrelBundle.LoadAssetAsync("Barrel.prefab");
        yield return loadAsset;

        barrelObj = (GameObject)Instantiate(loadAsset.asset);

        barrelObj.SetActive(false);

        focusCircleObj.GetComponent<ARFocusCircle>().virtual_objects[3] = barrelObj;

        PlayerPrefs.SetString("isBarrelDownloaded", "yes");

        barrelDLButton.SetActive(false);
    }

    public void DeleteObj()
    {
        if(barrelObj.GetComponent<LeanSelectable>().IsSelected == true)
        {
            barrelObj.SetActive(false);
        }

        if(chestObj.GetComponent<LeanSelectable>().IsSelected == true)
        {
            chestObj.SetActive(false);
        }

        if(shelfObj.GetComponent<LeanSelectable>().IsSelected == true)
        {
            shelfObj.SetActive(false);
        }

        if(tableObj.GetComponent<LeanSelectable>().IsSelected == true)
        {
            tableObj.SetActive(false);
        }
    }
}
