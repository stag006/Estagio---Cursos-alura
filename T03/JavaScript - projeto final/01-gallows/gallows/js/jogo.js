var criaJogo = function(sprite) {
    
    var palavraSecreta = '';
    var lacunas = [];
    var etapa = 1;
    
    
    // novas funcionaliades

    var ganhou = function () {
        console.log('falta implementar');
    };

    var perdeu = function () {
        console.log('falta implementar');
    };

    var ganhouOuPerdeu = function () {
        console.log('falta implementar');
    };

    var reinicia = function () {
        console.log('falta implementar');
    };
    
    var processaChute = function (chute) {
        
        var exp = new RegExp(chute, 'gi'),
            resulta,
            acertou = false;
        
        while(resultado = exp.exec(palavraSecreta)) {
            
            acertou = lacunas[resultado.index] = chute;            
        }
        
        if(!acertou) sprite.nextFrame();
        
        
    };
    
    var criaLacunas = function() {
        for(var i=0; i < palavraSecreta.length; i++){
            lacunas.push('');
        }
    };
    
    var proximaEtapa = function() {
        etapa = 2;
    }
    
    var setPalavraSecreta = function (palavra) {
        
        palavraSecreta = palavra;
        criaLacunas();
        proximaEtapa();
    };

    var getLacunas = function () {
        return lacunas;
    };

    var getEtapa = function () {
        return etapa;
    };

    return {

        setPalavraSecreta: setPalavraSecreta, 
        getLacunas: getLacunas,
        getEtapa: getEtapa,
        processaChute: processaChute
    };
};

