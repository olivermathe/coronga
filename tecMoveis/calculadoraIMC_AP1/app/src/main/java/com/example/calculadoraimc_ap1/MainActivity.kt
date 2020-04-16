package com.example.calculadoraimc_ap1

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_main.*
//Dupla Aldrin e Vinicius
class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        btnStart.setOnClickListener{
            val intent = Intent(this, genSelect::class.java)
            startActivity(intent)
        }
    }
}
