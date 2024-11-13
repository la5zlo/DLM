<template>
    <h1>Terméklista</h1>
    <div class="text-end mb-3">
        <router-link 
            to="/add"
            class="custom-large-button"
        >Új termék</router-link>
    </div>
    <table class="table table-hover custom-table">
        <thead class="table-header">
            <tr>
                <th>Cikkszám</th>
                <th>Megnevezés</th>
                <th>Termékleírás</th>
                <th>Ár (HUF)</th>
                <th>Műveletek</th>
            </tr>
        </thead>
        <tbody>
            <tr
                v-for="(good, index) in goodsList"
                :key="good.id"
            >
                <td>{{ good.partNumber }}</td>
                <td>{{ good.name }}</td>
                <td>{{ good.itemDescription }}</td>
                <td>{{ good.price }}</td>
                <td class="action-buttons">
                    <div class="mb-3">
                         <button
                            class="btn btn-primary"
                            @click.prevent="openEdit(index)"
                        >Módosítás</button>
                    </div>
                    <div class="mb-3">
                         <button
                            class="btn btn-secondary"
                            @click.prevent="deleteChosen(good.id)"
                        >Törlés</button>
                    </div>
                </td>
            </tr>
        </tbody>
    </table>
</template>

<script setup>
import {ref, reactive, inject} from 'vue';
import { useRouter } from 'vue-router';

const $goods = inject('$goods');
const router = useRouter();
let goodsList = reactive($goods.getAllGoods());



function openEdit(index){
    router.push({path:`edit/${index}`})
};

function deleteChosen(goodId){
    const confirmation = confirm("Are you sure you want to delete this item?");
    if(confirmation){
    $goods.deleteGood(goodId);
    console.log(goodId);
    router.go(0);
    }
}
</script>

<style scoped>
h1 {
    font-size: 2rem;
    color: #343a40;
    margin-bottom: 1rem;
}

.custom-large-button {
    font-size: 1.125rem;
    padding: 10px 20px;
    font-weight: bold;
    background-color: #007bff;
    border-color: #007bff;
    border-radius: 6px;
    color: #fff;
    text-align: center;
}

.custom-large-button:hover {
    background-color: #0056b3;
    border-color: #0056b3;
}

.custom-table {
    border-collapse: collapse;
    width: 100%;
}

.table-header th {
    background-color: #f8f9fa;
    color: #343a40;
    text-align: left;
    padding: 12px;
    font-weight: bold;
}

tbody tr:hover {
    background-color: #f1f3f5;
}

td, th {
    padding: 12px;
    border-bottom: 1px solid #dee2e6;
    vertical-align: middle;
}

.action-buttons {
    display: flex;
    align-items: center;
    justify-content: flex-start;
}

.text-end {
    text-align: right;
}
</style>