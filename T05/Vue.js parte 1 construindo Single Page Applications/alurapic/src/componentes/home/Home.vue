<template>
  <div >
    <h1 class="titulo">{{ titulo }}</h1>

    <input type="search" class="filtro" @input="filtro = $event.target.value" placeholder="filtre por parte do titulo">
    {{ filtro }}  
    <ul class="lista-fotos">
      <li class="lista-fotos-item" v-for="foto of fotosComFiltro">

      <meu-painel :titulo="foto.titulo">
        <imagem-responsiva :url="foto.url" :titulo="foto.titulo">
      </meu-painel>

      </li>
    </ul>
  </div>
</template>

<script>
import Painel from '../shared/painel/painel.vue';
import ImagemResponsilva from '../shared/imagem-responsiva/ImagemResponsiva.vue';

export default {
  'meu-painel' : Painel,
  'imagem-responsiva': imagemResposiva
},

data() {

  return {

    titulo: 'Alurapic',
    fotos: [],
    filtro: ''
  }
}

computed: {
  fotoComFiltro() {

    if(this.filtro) {
      let exp = new RegExp(this.filtro.trim(), 'i');
      return this.fotos.filter(foto => exp.test(foto.titulo));
    }else{
      return this.fotos;
    }
  }
},

created() {
  this.$http
    .get('http://localhost:3000/v1/fotos')
    .then(res => res.json())
    .then(fotos => this.fotos = fotos, err => console.log(err));
}
  


</script>

<style>

  .titulo {
    text-align: center;
  }

  .centralizado {

      text-align: center;
  }

  .lista-fotos {
    list-style: none;
  }

  .lista-fotos .lista-fotos-item {
    display: inline-block;
  }

  .filtro {
    display: block;
    width: 100%;
  }


</style>