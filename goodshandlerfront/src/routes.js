import {createRouter, createWebHashHistory} from 'vue-router';
import GoodsTable from './views/GoodsTable.vue';
import CreateGood from './views/CreateGood.vue'

const router = createRouter ({
history: createWebHashHistory(),
routes: [
    {path:'/', component : GoodsTable},
    {path:'/addgood', component: CreateGood}    
]
});

export default router;