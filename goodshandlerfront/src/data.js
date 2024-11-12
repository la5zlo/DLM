const goodsKey = 'goods';

let goodsJson = localStorage.getItem(goodsKey);
let goodsStore = JSON.parse(goodsJson);

function save() {
    localStorage.setItem(goodsKey, JSON.stringify(goodsStore));
};
export default {

    getAllGoods() {
        return goodsStore;
    },

    getSingleGood(index) {
        return goodsStore[index];
    },

    addGood(good) {
        goodsStore.push(good);
        save();
    },

    editGood(index, good) {
        goodsStore[index] = good;

        save();
    },

    deleteGood(index) {
        goodsStore.splice(index, 1);
        save();
    }
}