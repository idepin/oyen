using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NasiGoreng : MonoBehaviour
{
    //Bahan-bahan (Variable)
    int nasi = 2;
    int bawangPutih = 5; //Variable untuk menyimpan bawang putih
    int bawangMerah = 3;
    int kecap = 1;

    void PotongBahanBahan(int bawangPutihMenjadi, int bawangMerahMenjadi)
    {
        bawangPutih = bawangPutihMenjadi;
        bawangMerah = bawangMerahMenjadi;
        bawangPutih = (bawangPutih * 2);
        bawangMerah = (bawangMerah + 2);
    }

    void Start()
    {
        Debug.Log("Jumlah Bawang Putih adalah " + bawangPutih);
        Debug.Log("Jumlah Bawang Merah adalah " + bawangMerah);
        PotongBahanBahan(30, 20);
        Debug.Log("Jumlah Bawang Putih Setelah dipotong adalah " + bawangPutih);
        Debug.Log("Jumlah Bawang Merah Setelah dipotong adalah " + bawangMerah);
        PotongBahanBahan(70, 40);
        Debug.Log("Jumlah Bawang Putih Setelah dipotong adalah " + bawangPutih);
        Debug.Log("Jumlah Bawang Merah Setelah dipotong adalah " + bawangMerah);
    }

    void Update()
    {

    }

    void FixedUpdate()
    {

    }
}
