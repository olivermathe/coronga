package com.example.calculadoraimc_ap1

import android.content.Intent
import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import kotlinx.android.synthetic.main.activity_gen_select.*

class genSelect : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_gen_select)
        btnMasc.setOnClickListener{
            val intent = Intent(this, calculo::class.java)
            intent.putExtra("genero", "Masculino")
            startActivity(intent)
        }
        btnFem.setOnClickListener {
            val intent = Intent(this, calculo::class.java)
            intent.putExtra("genero", "Feminino")
            startActivity(intent)
        }
    }
}

