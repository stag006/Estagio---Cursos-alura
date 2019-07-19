var frase = $(".frase").text();
var numPalavras = frase.split(" ").length;
var tamanhoFrase = $("#tamanho-frase");

tamanhoFrase.text(numPalavras);


var campo = $(".campo-digitacao");
campo.on("click", function(){
    console.log("cliquei no campo");
    console.log(campo.val());
});

console.log(campo);