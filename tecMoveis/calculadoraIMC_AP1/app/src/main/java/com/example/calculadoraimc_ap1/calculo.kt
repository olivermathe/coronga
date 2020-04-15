package com.example.calculadoraimc_ap1

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_calculo.*
import kotlin.math.log10

class calculo : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_calculo)
        val genero = intent.getStringExtra("genero")

        textViewPeso.text = when(genero) {
            "Masculino" -> "tríceps";
            "Feminino" -> "subescapular";
            else -> "tríceps";
        }

        textView6.text = when(genero) {
            "Masculino" -> "abdominal";
            "Feminino" -> "coxa";
            else -> "abdominal";
        }

        val firstValue = when(genero) {
            "Masculino" -> 1.17136;
            "Feminino" -> 1.16650;
            else -> 1.17136;
        }

        val secondValue = when(genero) {
            "Masculino" -> 0.06706;
            "Feminino" -> 0.07063;
            else -> 0.06706;
        }

        btnCalc.setOnClickListener {

            val valor1 = inputText01.text.toString().toDouble()
            val valor2 = inputTextSupra.text.toString().toDouble()
            val valor3 = inputText03.text.toString().toDouble()

            val densidade: Double = firstValue - secondValue * log10(valor1 + valor2 + valor3)

            val intent = Intent(this, calculo2::class.java)
            intent.putExtra("genero", genero)
            intent.putExtra("densidade", densidade)
            startActivity(intent)
        }
    }
}
