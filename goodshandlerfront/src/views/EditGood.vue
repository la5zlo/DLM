<template>
    <form action="" class="container mb-3">
        <div class="row">
            <div class="col-md-8">
                <div class="mb-3">
                    <label for="" class="form-label">
                        Megnevezés
                    </label>
                    <input
                        type="text"
                        class="form-control"
                        v-model="good.name"
                    />
                </div>
                <div class="mb-3">
                    <label for="" class="form label">
                        Termékleírás
                    </label>
                    <textarea
                        type="text"
                        class="form-control"
                        rows="5"
                        v-model="good.itemDescription"
                    ></textarea>
                </div>
            </div>
        <div class="col">
            <div class="mb-3">
                <label for="" class="form-label">
                    Cikkszám
                </label>
                <input
                    type="text"
                    class="form-control"
                    v-model="good.partNumber"
                />
            </div>
            <div class="mb-3">
                <label for="" class="form-label">
                    Ár
                </label>
                <input
                    type="number"
                    class="form-control"
                    v-model="good.price"
                />
            </div>
        </div>
        </div>
        <div class="mb-3">
            <button
                class="btn btn-primary"
                @click.prevent="edit()"
            >Változtatások Mentése</button>
            <button
                class="btn btn-secondary"
                @click.prevent="goToGoodsTable()"
            >Vissza</button>
        </div>
    </form>
</template>

<script setup>
import { useRouter } from 'vue-router';
import { useRoute } from 'vue-router';
import { inject, computed } from 'vue';

const router = useRouter();
const route = useRoute();
const goods = inject('$goods');
const index = route.params.index;



const isFormValid = computed(() => {return !good.partNumber || !good.name || !good.itemDescription || !good.price });

let originalGood = goods.getSingleGood(index);
let good = {...originalGood};

function goToGoodsTable() {
    good = {...originalGood};
    router.push({path: '/goods'});
};

function edit() {
    if(isFormValid.value) {
            alert('Hiányzó adatok!')
            return
        };
        goods.editGood(good.id,{
            id: good.id, 
            partNumber: good.partNumber,
            name: good.name,
            itemDescription: good.itemDescription,
            price: good.price 
        });
        goToGoodsTable();
}

</script>