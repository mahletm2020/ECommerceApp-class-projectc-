<template>
  <div class="products">
    <h1>Our Products</h1>
    <div v-if="loading">Loading...</div>
    <div v-else-if="error">An error occurred: {{ error }}</div>
    <div v-else>
      <ul>
        <li v-for="product in products" :key="product.id">
          <h2>{{ product.name || 'No Name Available' }}</h2>
          <p>{{ product.description || 'No Description Available' }}</p>
          <p>Price: ${{ product.price || 'Not Available' }}</p>
        </li>
      </ul>
    </div>
  </div>
</template>

<script setup>
import { ref, onMounted } from 'vue';

const products = ref([]);
const loading = ref(true);
const error = ref(null);

onMounted(async () => {
  try {
    const { $axios } = useNuxtApp();
    const response = await $axios.get('/products');
    if (response.data && Array.isArray(response.data)) {
      products.value = response.data;
    } else {
      throw new Error('Unexpected response format');
    }
  } catch (err) {
    error.value = err.message || 'Failed to fetch products';
    console.error('Error fetching products:', err);
  } finally {
    loading.value = false;
  }
});
</script>

<style scoped>
@import url('https://fonts.googleapis.com/css2?family=Lemon+Milk:wght@400;700&display=swap');

.products {
  background: #ffffff;
  padding: 20px;
  font-family: 'Lemon Milk', sans-serif;
  color: #6a0dad;
}

h1 {
  font-size: 36px;
  margin-bottom: 20px;
  text-align: center;
}

ul {
  list-style: none;
  padding: 0;
  display: flex;
  flex-wrap: wrap;
  gap: 20px;
}

li {
  background: #f5f5f5;
  border: 1px solid #ddd;
  border-radius: 10px;
  padding: 15px;
  width: calc(33% - 20px);
  text-align: center;
}

li h2 {
  font-size: 18px;
  margin-bottom: 10px;
  color: #6a0dad;
}

li p {
  font-size: 16px;
  color: #9f7aea;
}
</style>
