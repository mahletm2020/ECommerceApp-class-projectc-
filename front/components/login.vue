<template>
  <div class="auth-page">
    <h1>Login</h1>
    <form>
      <label for="email">Email</label>
      <input type="email" id="email" placeholder="Enter your email" />
      <label for="password">Password</label>
      <input type="password" id="password" placeholder="Enter your password" />
      <button type="submit">Login</button>
    </form>
    <p>
      Don't have an account? <router-link to="/signup">Sign Up</router-link>
    </p>
  </div>
</template>

<style scoped>
.auth-page {
  background: #ffffff;
  padding: 40px;
  font-family: 'Lemon Milk', sans-serif;
  text-align: center;
  color: #6a0dad;
}

h1 {
  font-size: 36px;
  margin-bottom: 20px;
}

form {
  display: flex;
  flex-direction: column;
  gap: 15px;
  align-items: center;
}

input {
  width: 80%;
  padding: 10px;
  font-size: 16px;
  border: 1px solid #ddd;
  border-radius: 5px;
}

button {
  background-color: #6a0dad;
  color: white;
  padding: 10px 20px;
  border: none;
  border-radius: 5px;
  cursor: pointer;
  transition: transform 0.3s, background-color 0.3s;
}

button:hover {
  background-color: #9f7aea;
  transform: scale(1.05);
}

p {
  font-size: 16px;
  margin-top: 20px;
}

a {
  color: #6a0dad;
  text-decoration: none;
}
</style>