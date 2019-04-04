import Vue from 'vue'
import Router from 'vue-router'
import Index from '@/routes/Index'

Vue.use(Router);

export default new Router({
  routes: [
    {
      path: '/',
      name: 'Lumper',
      component: Index
    }
  ]
})
