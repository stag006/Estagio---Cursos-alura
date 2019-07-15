var titulo = document.querySelector(".titulo");
titulo.textContent = "Aparecida Nutricionista";

var paciente = document.querySelector("#primeiro-paciente");

var tdPeso = paciente.querySelector(".info-peso");
var peso = tdPeso.textContent;

var tdAltura = paciente.querySelector(".info-altura");
var altura = tdAltura.textContent;

var tdImc = paciente.querySelector(".info-imc");

if(peso < 0 || peso > 1000)
{
   console.log("Peso inválido!");
}

if(altura < 0){
    console.log("altura invalida!");
}

var imc = peso / (altura * altura); // 100 / (2*5)
tdImc.textContent = imc;


