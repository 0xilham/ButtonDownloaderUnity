# ButtonDownloaderUnity

## Penggunaan Button Downloader

Untuk membuat tombol di Unity yang dapat digunakan untuk mendownload file PDF dan menyimpannya di penyimpanan perangkat, Anda dapat menggunakan fungsi-fungsi berikut:

### 1. Unity Button:
Membuat tombol di Unity.

### 2. UnityWebRequest: 
Untuk melakukan permintaan unduhan ke server.

### 3. File.WriteAllBytes: 
Untuk menyimpan file yang diunduh ke penyimpanan perangkat.

## Tutorial

#### 1. Buat button didalam hierarchy.
#### 2. Buat Script C sharp di folder project 
```bash
  Assets/Scripts/PDFDownloader.cs
```
#### 3. Masukkan Script ke object Button yang telah dibuat di hierarchy tadi

#### 4. Copas Script diatas dan ubah bagian nilai string di variable 
```bash
  public string pdfURL = "domain.com/file.pdf"; // URL tempat file PDF kamu berada
```

#### 5. Uji coba mengklik button dan berhasil mendownload file PDF kamu