<template>
  <div class="about">
    <section>
      <h1>About Us</h1>
      <p>
        We are dedicated to providing the best shopping experience. With a
        curated selection of products, we ensure quality and satisfaction for
        all our customers.
      </p>
    </section>
    <div class="team">
      <h2>Meet Our Team</h2>
      <ul>
        <li v-for="(member, index) in team" :key="index">
          <img :src="member.photo" alt="Team Member" />
          <h3>{{ member.name }}</h3>
          <p>{{ member.role }}</p>
        </li>
      </ul>
    </div>
  </div>
</template>

<script setup>
const team = [
  { name: 'Jane Doe', role: 'CEO', photo: '/images/jane.jpg' },
  { name: 'John Smith', role: 'CTO', photo: '/images/john.jpg' },
  { name: 'Alice Brown', role: 'Designer', photo: '/images/alice.jpg' },
];
</script>

<style scoped>
@import url('https://fonts.googleapis.com/css2?family=Lemon+Milk:wght@400;700&display=swap');

.about {
  padding: 40px;
  background-color: #ffffff;
  color: #6a0dad;
  font-family: 'Lemon Milk', sans-serif;
}

section {
  margin-bottom: 30px;
}

h1 {
  font-size: 36px;
  margin-bottom: 20px;
}

p {
  font-size: 18px;
  color: #9f7aea;
}

.team h2 {
  margin-top: 30px;
  font-size: 28px;
}

ul {
  display: flex;
  flex-wrap: wrap;
  gap: 20px;
  padding: 0;
  list-style: none;
}

li {
  flex: 1 1 200px;
  text-align: center;
}

img {
  width: 100px;
  height: 100px;
  border-radius: 50%;
  margin-bottom: 10px;
}

h3 {
  font-size: 20px;
}

p {
  font-size: 16px;
}
</style>
