package com.example.sehirplaka

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import com.example.sehirplaka.databinding.ActivityMainBinding

class MainActivity : AppCompatActivity() {
     private lateinit var binding: ActivityMainBinding
     override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        setupBinding()
         binding.button.setOnClickListener{
             if(binding.editTextNumber.text.isNotEmpty()){
             var plakaKodu = binding.editTextNumber.text.toString().toInt()
                 //Sadece 11 tanesini yazdım
                 when(plakaKodu){
                     1 -> binding.textView.text = "Adana"
                     2 -> binding.textView.text = "Adıyaman"
                     3 -> binding.textView.text = "Afyon"
                     4 -> binding.textView.text = "Ağrı"
                     5 -> binding.textView.text = "Amasya"
                     6 -> binding.textView.text = "Ankara"
                     7 -> binding.textView.text = "Antalya"
                     8 -> binding.textView.text = "Artvin"
                     9 -> binding.textView.text = "Aydın"
                     10 -> binding.textView.text = "Balıkesir"
                     11 -> binding.textView.text = "Bilecik"
                     else ->{
                         binding.textView.text = "Bulunmadı"
                     }
                 }
             }
             else{
                 binding.textView.text="Şehir plaka kodunu giriniz"
             }
             // Plaka kodunu buldugunda aynı zamanda içerisini temizle
             binding.editTextNumber.text.clear()
         }
    }
    fun setupBinding() {
        binding = ActivityMainBinding.inflate(layoutInflater)
        val view = binding.root
        setContentView(view)
    }




}