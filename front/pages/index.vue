<template>
  <div>
    <h1>Products</h1>
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

const products = ref([]); // To hold the fetched products
const loading = ref(true); // To indicate loading state
const error = ref(null); // To store any errors

onMounted(async () => {
  try {
    const { $axios } = useNuxtApp(); // Access the Axios instance
    const response = await $axios.get('/products'); // Adjusted to fetch the products
    // Check if the data format matches expectations
    if (response.data && Array.isArray(response.data)) {
      products.value = response.data; // Assign the products array
    } else {
      throw new Error('Unexpected response format');
    }
  } catch (err) {
    error.value = err.message || 'Failed to fetch products';
    console.error('Error fetching products:', err);
  } finally {
    loading.value = false; // Ensure loading stops regardless of success or error
  }
});
</script>


<style scoped>
h1 {
  font-size: 24px;
  margin-bottom: 20px;
}
ul {
  list-style: none;
  padding: 0;
}
li {
  margin-bottom: 20px;
  padding: 10px;
  border: 1px solid #ddd;
  border-radius: 5px;
}
</style>
