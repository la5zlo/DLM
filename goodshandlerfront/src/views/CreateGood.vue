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
                        v-model="name"
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
                        v-model="itemDescription"
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
                    v-model="partNumber"
                />
            </div>
            <div class="mb-3">
                <label for="" class="form-label">
                    Ár
                </label>
                <input
                    type="number"
                    class="form-control"
                    v-model="price"
                />
            </div>
        </div>
        </div>
        <div class="mb-3">
            <button
                class="btn btn-primary"
                :disabled="isFormValid"
                @click.prevent="createNewGood()"
            >Mentés</button>
            <button
                class="btn btn-secondary"
                @click.prevent="goToGoodsTable()"
            >Vissza</button>
        </div>
    </form>
</template>

<script setup>
import { inject, ref, computed } from 'vue'
import { useRouter } from 'vue-router';


const router = useRouter();
const $goods = inject('$goods');
const isFormValid = computed(() => {return !partNumber.value || !name.value || !itemDescription.value || !price.value });

let partNumber = ref('');
let name = ref('');
let itemDescription = ref('');
let price = ref('');

function createNewGood() {
        if(!isFormValid) {
            alert('Please fill the form!')
            return
        };
        $goods.addGood({
            partNumber: partNumber.value,
            name: name.value,
            itemDescription: itemDescription.value,
            price: price.value
        });

        goToGoodsTable();
    };

function goToGoodsTable() {
        router.push({path: '/goods'});
    }

    /*export default {
        computed:{ 
            isFormValid() {
                return !this.partNumber || !this.name || !this.itemDescription || !this.price;
            }
        },
        data() {
            return {
                partNumber:"",
                name:"",
                itemDescription:"",
                price:""
            }
        },
        methods:{
            createNewGood() {
                if(isFormValid()) {
                    alert('Please fill the form!')
                    return
                }
                $goods.addGood(this.partNumber, this.name, this.itemDescription,this.price);

                goToGoodsTable();
            },

            goToGoodsTable() {
                router.push({path: '/'});
            }
        }
    }*/
</script>