//const goodsKey = 'goodsList';
const API_URL= "https://localhost:7084/";

/*let goodsJson = localStorage.getItem(goodsKey);
let goodsStore = await JSON.parse(goodsJson) || [];

function save() {
    localStorage.setItem(goodsKey, JSON.stringify(goodsStore));
};*/

let goodsStore = await goodsListCreate();

async function goodsListCreate(){
    try {
        const response = await axios.get(`${API_URL}api/Goods`);
        //localStorage.setItem('goodsList',JSON.stringify(response.data))
        return response.data;
    } catch (error) {
        console.error("Error fetching data:", error);
    }
};

export default {

    async goodsListCreate(){
        try {
            const response = await axios.get(`${API_URL}api/Goods`);
            //localStorage.setItem('goodsList',JSON.stringify(response.data))
            return response.data;
        } catch (error) {
            console.error("Error fetching data:", error);
        }
    },

    getAllGoods() {
        return goodsStore;
    },

    getSingleGood(index) {
        return goodsStore[index];
    },

    addGood(good) {
        axios.post(`${API_URL}api/Goods`,good);
        //save();
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