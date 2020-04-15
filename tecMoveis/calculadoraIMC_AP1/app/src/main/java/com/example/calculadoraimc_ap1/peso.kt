package com.example.calculadoraimc_ap1

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_peso.*

class peso : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_peso)

            val genero = intent.getStringExtra("genero")
            val gordura = intent.getDoubleExtra("gordura", .0)

            btnCalc.setOnClickListener {

                val peso: Double = inputPeso.text.toString().toDouble()

                val intent = Intent(this, calculoFinal::class.java)
                intent.putExtra("peso", peso)
                intent.putExtra("gordura", gordura)
                intent.putExtra("genero", genero)
                startActivity(intent)
            }
    }
}



