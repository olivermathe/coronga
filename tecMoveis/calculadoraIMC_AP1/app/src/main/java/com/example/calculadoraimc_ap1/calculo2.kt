package com.example.calculadoraimc_ap1

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_calculo.*
import kotlinx.android.synthetic.main.activity_calculo2.*

class calculo2 : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_calculo2)

        val genero = intent.getStringExtra("genero")
        val densidade = intent.getDoubleExtra("densidade", .0);
        val gordura = ((4.95 / densidade) - 4.50) * 100

        textViewCalculo2.text = when(genero) {
            "Masculino" -> this.calculaMediaMasc(gordura);
            "Feminino" -> this.calculaMediaFem(gordura)
            else -> this.calculaMediaMasc(gordura)
        }

      btnPeso.setOnClickListener {
            val intent = Intent(this, peso::class.java)
            intent.putExtra("gordura", gordura)
            intent.putExtra("genero", genero)
            startActivity(intent)
        }
    }
    fun calculaMediaMasc(gordura: Double): String {
        if (gordura <= 4) {
            return "magro"
        }
        if (gordura <= 8) {
            return "Abaixo da média"
        }
        if (gordura <= 16) {
            return "Na média"
        }
        if (gordura <= 24) {
            return "Acima da média"
        }
        return "Obeso"
    }
    fun calculaMediaFem(gordura: Double): String {
        if (gordura <= 8) {
            return "Magra"
        }
        if (gordura <= 14) {
            return "Abaixo da média"
        }
        if (gordura <= 22) {
            return "Na média"
        }
        if (gordura <= 29) {
            return "Acima da média"
        }
        return "Obesa"
    }
}


