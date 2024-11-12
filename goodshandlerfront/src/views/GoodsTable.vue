<template>
    <h1>Terméklista</h1>
    <div class="text-end">
        <router-link 
            to="/addgood"
            class="btn btn-primary btn-sm"
        >Új termék</router-link>
    </div>
    <table class="table table-hover">
        <thead>
            <tr>
                <th>Cikkszám</th>
                <th>Megnevezés</th>
                <th>Termékleírás</th>
                <th>Ár(HUF)</th>
            </tr>
        </thead>
        <tbody>
            <tr
                v-for="(good, index) in $goods.getAllGoods()"
                :key="index"
            >
                <td>{{ good.partNumber }}</td>
                <td>{{ good.name }}</td>
                <td>{{ good.itemDescription }}</td>
                <td>{{ good.price }}</td>
                <router-link 
                to="/addgood"
                class="btn btn-primary btn-sm"
                >Módosítás</router-link>
                 <router-link 
                to="/addgood"
                class="btn btn-primary btn-sm"
                >Törlés</router-link>
                </tr>
        </tbody>
    </table>
</template>

<script setup>
import {ref, reactive, inject} from 'vue';
import { useRouter } from 'vue-router';

const $goods = inject('$goods');
const router = useRouter();

</script>