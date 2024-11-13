const goodsKey = 'goods';
const API_URL= "https://localhost:7084/";

//let goodsJson = localStorage.getItem(goodsKey);
let goodsStore = await goodsListCreate();
//let goodsStore = await JSON.parse(goodsJson) || [];

function save() {
    localStorage.setItem(goodsKey, JSON.stringify(goodsStore));
};

async function goodsListCreate(){
    try {
        const response = await axios.get(`${API_URL}api/Goods`);
        //console.log(response.data);
        return response.data;
    } catch (error) {
        console.error("Error fetching data:", error);
    }
};

export default {

    getAllGoods() {
        return goodsStore;
    },

    getSingleGood(index) {
        return goodsStore[index];
    },

    addGood(good) {
        axios.post(`${API_URL}api/Goods`,good);

        /*goodsStore.push(good);
        save();*/
    },

    editGood(goodId, good) {
        axios.put(`${API_URL}api/Goods/${goodId}`,good);

        /*goodsStore[index] = good;
        save();*/
    },

    deleteGood(goodId) {
        axios.delete(`${API_URL}api/Goods/${goodId}`);

        /*goodsStore.splice(index, 1);
        save();*/
    }
}