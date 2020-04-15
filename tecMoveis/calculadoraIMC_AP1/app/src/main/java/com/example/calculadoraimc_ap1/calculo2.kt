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

        textView13.text = when(genero) {
            "Masculino" -> this.getClassificacaoHomem(gordura);
            "Feminino" -> this.getClassificacaoMulher(gordura)
            else -> this.getClassificacaoHomem(gordura)
        }

      btnPeso.setOnClickListener {
            val intent = Intent(this, peso::class.java)
            intent.putExtra("gordura", gordura)
            intent.putExtra("genero", genero)
            startActivity(intent)
        }
    }

    fun getClassificacaoHomem(gordura: Double): String {
        if (gordura <= 4) {
            return "MAGRO"
        }
        if (gordura <= 8) {
            return "ABAIXO DA MÉDIA"
        }
        if (gordura <= 16) {
            return "NA MÉDIA"
        }
        if (gordura <= 24) {
            return "ACIMA DA MÉDIA"
        }
        return "OBESO"
    }

    fun getClassificacaoMulher(gordura: Double): String {
        if (gordura <= 8) {
            return "MAGRO"
        }
        if (gordura <= 14) {
            return "ABAIXO DA MÉDIA"
        }
        if (gordura <= 22) {
            return "NA MÉDIA"
        }
        if (gordura <= 29) {
            return "ACIMA DA MÉDIA"
        }
        return "OBESO"
    }

}


