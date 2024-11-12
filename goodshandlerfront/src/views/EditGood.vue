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
                        v-model="goods.name"
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
                        v-model="goods.itemDescription"
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
                    v-model="goods.partNumber"
                />
            </div>
            <div class="mb-3">
                <label for="" class="form-label">
                    Ár
                </label>
                <input
                    type="number"
                    class="form-control"
                    v-model="goods.price"
                />
            </div>
        </div>
        </div>
        <div class="mb-3">
            <button
                class="btn btn-primary"
                :disabled="isFormValid"
                @click.prevent="submitForm()"
            >Create Page</button>
        </div>
    </form>
</template>

<script>
import { inject } from 'vue';

const goods = inject('$goods');

</script>