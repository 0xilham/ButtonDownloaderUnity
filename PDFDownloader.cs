using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.IO;

public class PDFDownloader : MonoBehaviour
{
    public string pdfURL = "https://tourism.gov.in/sites/default/files/2019-04/dummy-pdf_2.pdf"; // URL tempat file PDF berada

    public Button downloadButton; // Tombol untuk memulai unduhan

    void Start()
    {
        downloadButton.onClick.AddListener(DownloadPDF);
    }

    void DownloadPDF()
    {
        StartCoroutine(DownloadPDFCoroutine());
    }

    IEnumerator DownloadPDFCoroutine()
    {
        UnityWebRequest www = UnityWebRequest.Get(pdfURL);
        yield return www.SendWebRequest();

        if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError("Download error: " + www.error);
        }
        else
        {
            byte[] pdfBytes = www.downloadHandler.data;

            // Simpan file PDF di direktori yang dapat diakses Unity di semua platform
            string savePath = Path.Combine(Application.persistentDataPath, "example.pdf");

            // Simpan file PDF
            File.WriteAllBytes(savePath, pdfBytes);

            Debug.Log("PDF downloaded and saved to: " + savePath);
        }
    }
}