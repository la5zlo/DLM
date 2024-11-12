const goodsKey = 'goods';

let goodsJson = localStorage.getItem(goodsKey);
let goodsStore = JSON.parse(goodsJson);

export default {

    getAllGoods() {
        return goodsStore;
    },

    getSingleGood(index) {
        return goodsStore[index];
    },

    editGood(index, good) {
        goodsStore[index] = good;

        localStorage.setItem(goodsStore, JSON.stringify(goodsStore));
    }
}