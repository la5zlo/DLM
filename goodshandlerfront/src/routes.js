import {createRouter, createWebHistory} from 'vue-router';
import GoodsTable from './views/GoodsTable.vue';
import CreateGood from './views/CreateGood.vue';
import EditGood from './views/EditGood.vue';
import Login from './views/Login.vue';
import Goods from './views/Goods.vue';
import { inject } from 'vue';

const router = createRouter ({
    history: createWebHistory(),
    routes: [
        {path:'/', component: Login},
        {path:'/goods', component: Goods,meta: {requiresAuth: true },
            children: [
                {path:'', component : GoodsTable,meta: {requiresAuth: true }},
                {path:'add', component: CreateGood,meta: {requiresAuth: true }}, 
                {path:'edit/:index', component: EditGood,meta: {requiresAuth: true } }   
            ]
        }, 
    ],
});  

router.beforeEach((to, from, next, push) => {
    const isAuth = inject('isAuth');
    if (to.meta.requiresAuth && !isAuth.value) {
        next('/'); 
    } else {
        next();
    }
});

export default router;