<template>
  <div>
    <Homepage/>
    <Products/>
    <About/>
    <SignIn/>
    <Login/>
    <Cart/>
  </div>
</template>

<script setup>
import Homepage from '~/components/homepage.vue';
import Products from '~/components/products.vue';
import About from '~/components/about.vue';
// import SignIn from '/components/SignIn.vue';
import SignIn from '~/components/signin.vue'
import Login from '~/components/login.vue';
// import Cart from './components/Cart.vue';



// const routes = [
//   { path: '/', component: Home },
//   { path: '/products', component: Products },
//   { path: '/about', component: About },
//   { path: '/signin', component: SignIn },
//   { path: '/login', component: Login },
//   { path: '/cart', component: Cart },
// ];

// const router = createRouter({
//   history: createWebHistory(),
//   routes,
// });
</script>

<style lang="scss" scoped>

</style>