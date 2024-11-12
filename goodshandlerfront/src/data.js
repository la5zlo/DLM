const goodsKey = 'goods';
const API_URL= "http://localhost:7084";

//let goodsJson = localStorage.getItem(goodsKey);
let goodsJson = goodsListCreate();
let goodsStore = JSON.parse(goodsJson) || [];

function save() {
    localStorage.setItem(goodsKey, JSON.stringify(goodsStore));
};

async function goodsListCreate(){
    axios.get(API_URL+"/inventory/GetGoods").then(
    (response)=>{
        return response.data;
    }
    )
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