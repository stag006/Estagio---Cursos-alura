import vue from "vue";

Vue.directive('meu-transform', {

    bind(el, binding, vnode) {

        let current = 0;

        el.addEventListener('dbclick', function() {

            let incremento = binding.value || 90;

            if(binding.modifiers.reverse) {
                cuerrent-=incremento;
            }else {
                current+=incremento;
            }

            current+=incremento;
            el.style.transform = `rotate(${current}deg)`;

            if(binding.modifiers.animate) el.style.transition = 'transform 0.5s';
        });
    }
});