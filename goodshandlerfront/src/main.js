import {createApp} from 'vue';
import App from './App.vue';
import router from './routes';
import $goods from './data';
import '../node_modules/bootstrap/dist/css/bootstrap.css';
import { ref, provide } from 'vue';

const app = createApp(App);
const isAuth = ref(false);

app.use(router);

app.provide('$goods', $goods);
app.provide('isAuth', isAuth);

app.mount('#app');