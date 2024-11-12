import {createRouter, createWebHashHistory} from 'vue-router';
import GoodsTable from './views/GoodsTable.vue';
import CreateGood from './views/CreateGood.vue';
import EditGood from './views/EditGood.vue';

const router = createRouter ({
history: createWebHashHistory(),
routes: [
    {path:'/', component : GoodsTable},
    {path:'/add', component: CreateGood}, 
    {path:'/edit/:index', component: EditGood }   
]
});

export default router;