import Cadastro from './componentes/cadastro/Cadastro.vue';
import Home from './componentes/home/Home.vue';

export const routes = [
    {path: '', component: Home, titulo: 'Home'},
    {path: '/Cadastro', component: Cadastro, titulo: 'Cdastro'}
];