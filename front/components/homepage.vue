<template>
  <div class="home">
    <nav class="navbar">
    <ul>
      <li><router-link to="/"><i class="fas fa-home"></i> Home</router-link></li>
      <li><router-link to="/products"><i class="fas fa-box"></i> Products</router-link></li>
      <li><router-link to="/about"><i class="fas fa-info-circle"></i> About</router-link></li>
      <li><router-link to="/cart"><i class="fas fa-shopping-cart"></i> Cart</router-link></li>
      <li><router-link to="/signin"><i class="fas fa-user"></i> Sign In</router-link></li>
    </ul>
  </nav>
    <header>
      <h1>Welcome to Our Store</h1>
      <p>Your one-stop shop for all your needs</p>
    </header>
    <div class="cta">
      <button @click="exploreProducts">Explore Products</button>
    </div>
  </div>
</template>

<script setup>
import { useRouter } from 'vue-router';

const router = useRouter();

const exploreProducts = () => {
  router.push('/products');
};
</script>

<style scoped>
@import url('https://fonts.googleapis.com/css2?family=Lemon+Milk:wght@400;700&display=swap');

.home {
  text-align: center;
  background: linear-gradient(to bottom, #ffffff, #d8b4ff);
  padding: 50px;
  font-family: 'Lemon Milk', sans-serif;
}

header {
  margin-bottom: 30px;
}

header h1 {
  font-size: 48px;
  color: #6a0dad;
}

header p {
  font-size: 18px;
  color: #9f7aea;
}

.cta button {
  background-color: #6a0dad;
  color: white;
  padding: 15px 30px;
  border: none;
  border-radius: 10px;
  font-size: 16px;
  cursor: pointer;
  transition: transform 0.3s, background-color 0.3s;
}

.cta button:hover {
  background-color: #9f7aea;
  transform: scale(1.05);
}
@import url('https://fonts.googleapis.com/css2?family=Lemon+Milk:wght@400;700&display=swap');
@import url('https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css');

.navbar {
  background-color: #6a0dad;
  padding: 10px 20px;
  color: white;
  font-family: 'Lemon Milk', sans-serif;
}

.navbar ul {
  list-style: none;
  display: flex;
  justify-content: space-around;
  padding: 0;
  margin: 0;
}

.navbar li {
  margin: 0 10px;
}

.navbar a {
  text-decoration: none;
  color: white;
  font-size: 16px;
  display: flex;
  align-items: center;
  gap: 5px;
  transition: color 0.3s;
}

.navbar a:hover {
  color: #d8b4ff;
}
</style>
