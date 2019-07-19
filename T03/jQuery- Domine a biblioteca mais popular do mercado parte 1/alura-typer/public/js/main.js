var tempoInicial = $("#tempo-digitacao").text();

$(function(){
    console.log("Pagina Carregou")
    atualizaTamnhoFrase();
    inicializaContadores();
    inicializaCronometro();            
    $("#botao-reiniciar").click(reiniciaJogo);    
});

function atualizaTamnhoFrase(){
    var frase = $(".frase").text();
    var numPalavras = frase.split(" ").length;
    var tamanhoFrase = $("#tamanho-frase");
    tamanhoFrase.text(numPalavras);
    
}

var campo = $(".campo-digitacao");

function inicializaContadores(){
        campo.on("input", function(){
        var conteudo = campo.val();

        var qtdPalavras = conteudo.split(/\S+/).length -1;    
        $("#contador-palavras").text(qtdPalavras);

        var qtdCaracteres = conteudo.length;
        $("#contador-caracteres").text(qtdCaracteres);
    });
}


function inicializaCronometro() {
    var tempoRestante =  $("#tempo-digitacao").text();
    campo.one("focus",function(){
        var cronometroID = setInterval(function(){
            tempoRestante--;        
            $("#tempo-digitacao").text(tempoRestante);
            if(tempoRestante < 1){
                campo.attr("disabled",true);
                clearInterval(cronometroID);
                campo.toggleClass("campo-desativado")
            }
        },1000);
    });
}


//$("#botao-reiniciar").on("click", function(){
//    console.log("Botao clicado")
//);

function reiniciaJogo(){
    campo.attr("disabled", false);
    campo.val("");
    $("#contador-palavras").text('0');
    $("#contador-caracteres").text('0');
    $("#tempo-digitacao").text(tempoInicial);
    inicializaCronometro();
    campo.toggleClass("campo-desativado");
}

