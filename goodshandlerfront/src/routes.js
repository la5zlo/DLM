import {createRouter, createWebHistory} from 'vue-router';
import GoodsTable from './views/GoodsTable.vue';
import CreateGood from './views/CreateGood.vue';
import EditGood from './views/EditGood.vue';
import Login from './views/Login.vue';
import Goods from './views/Goods.vue';

const router = createRouter ({
    history: createWebHistory(),
    routes: [
        {path:'/:index?', component: Login},
        {path:'/goods', component: Goods,
            children: [
                {path:'', component : GoodsTable},
                {path:'add', component: CreateGood}, 
                {path:'edit/:index', component: EditGood }   
            ]
        }, 
    ],
});    

export default router;