<!-- alurapic/src/components/shared/botao/Botao.vue -->
<template>
    <button @click="disparaAcao()" class="botao" :class="estiloDoBotao" :type="tipo">{{rotulo}}</button>
</template>
<script>
props: ['tipo', 'rotulo', 'confirmacao', 'estilo']

export default {

    props: {

        tipo: {
            required:  true,
            t,

        rotulo: {

            required:  true,
            type: String

        },

        confirmacao: Boolean,
        estilo: String

    }

   methods: {
       
       disparaAcao() {

            if(this.confirmacao) {
                if(confirm('Confirma oporação?')) {
                    this.$emit('botaoAtivado');
                }
                return;
           }
           this.$emit('botaoAtivado');
       }
   },

   computed: {

       estiloDoBotao() {

           if(this.estilo == 'padrao') return 'botao botao-padrao';
           if(this.estilo == 'perigo') return 'botao botao-perigo';
       }
   }
}
</script>    

<style scoped>
    .botao {
        display: inline-block;
        padding: 10px;
        border-radius: 3px;
        margin: 10px;
        font-size: 1.2em;
    }

    .botao-perigo {
        background: firebrick;
        color: white;
    }

    .botao-padrao {
        background: darkcyan;
        color: white;
    }

</style>

