var tempoInicial = $("#tempo-digitacao").text();
var campo = $(".campo-digitacao");

$(function(){
    console.log("Pagina Carregou")
    atualizaTamnhoFrase();
    inicializaContadores();
    inicializaCronometro();            
    inicializaMarcadores();
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
                campo.toggleClass("campo-desativado");
            }
        },1000);
    });
}

function inicializaMarcadores(){
    var frase = $(".frase").text();
    campo.on("input",function(){
        var digitado = campo.val();
        var comparavel = frase.substr(0,digitado.length);
        console.log("digitado:" + digitado);
        console.log("frase C.:" + comparavel);

        if(frase.startsWith){
            campo.addClass("borda-verde");
            campo.removeClass("borda-vermelha");
        }
        else{
            campo.addClass("borda-vermelha");
            campo.removeClass("borda-verde");
        }
    });
}


//$("#botao-reiniciar").on("click", function(){
//    console.log("Botao clicado")
//);
function reiniciaJogo(){
    campo.attr("disabled", false);
    campo.val("");
    $("#contador-palavras").text("0");
    $("#contador-caracteres").text("0");
    $("#tempo-digitacao").text(tempoInicial);
    inicializaCronometro();
    campo.toggleClass("campo-desativado");
    campo.removeClass("borda-vermelha");
    campo.removeClass("borda-verde");
}

