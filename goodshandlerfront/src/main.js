import {createApp} from 'vue';
import App from './App.vue';
import router from './routes';
import $goods from './data';
import '../node_modules/bootstrap/dist/css/bootstrap.css';

const app = createApp(App);

app.use(router);

app.provide('$goods', $goods);

app.mount('#app');