package com.example.calculadoraimc_ap1

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_calculo_final.*
import kotlinx.android.synthetic.main.activity_peso.*

class calculoFinal : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_calculo_final)

    val peso = intent.getDoubleExtra("peso", .0)
    val genero = intent.getStringExtra("genero")
    val gordura = intent.getDoubleExtra("gordura", .0)
    val pesoGordo = (gordura/100) * peso
    val massaMagra = peso - pesoGordo
    val pesoIdeal = when(genero) {
        "Masculino" -> massaMagra / 0.85;
        "Feminino" -> massaMagra / 0.75;
        else -> massaMagra / 0.85;
    }
    val pesoExcesso = peso - pesoIdeal
    println(peso)
    println(genero)
    println(gordura)
    println(pesoGordo)
    println(massaMagra)
    println(pesoIdeal)
    println(pesoExcesso)
    textGordura.text = "Massa gordura = " + "%.2f".format(pesoGordo) + "kg"
    textMassaMagra.text = "Massa magra = " + "%.2f".format(massaMagra) + "kg"
    textPesoIdeal.text = "Seu peso ideal = " + "%.2f".format(pesoIdeal) + "kg"
    textPesoExcesso.text = "Peso em excesso = " + "%.2f".format(pesoExcesso) + "kg"

        btnIntro.setOnClickListener {
        val intent = Intent(this, MainActivity::class.java)
        startActivity(intent)
    }
}
}
