<script setup>
  import { ref } from 'vue'

  const numberOfUsers = ref('')

  async function fetchUsers(numberOfUsers) {
    const response = await fetch(`https://localhost:8080/api/users${numberOfUsers}`);
    console.log(response.json)

    return await response.json
  }
</script>

<template>
  <div class="wrapper">
    <h1 class="header-title"><span class="green-header-title">Flexible</span> <span class="gray-header-title">Project</span>🤸‍♂️</h1>
    <h3> Welcome! Please insert the <span class="green">number</span> of users that you would like to fetch</h3>
    <form on-submit="fetchUsers(numberOfUsers)">
      <input type="number" min="1" v-model="numberOfUsers"/>
      <button type="submit">Submit</button>
    </form>
    <button :on-click="fetchUsers(numberOfUsers)">EEE</button>
  </div>
</template>

<style scoped>
h1 {
  font-size: 2.6rem;
  top: -10px;
}

h3 {
  font-size: 1.2rem;
}

form {
  display: flex;
  margin: 1rem 0;
}

form input, button {
  background-color: var(--vt-c-text-dark-2);
  padding: 0.5rem 1rem;
  border: 2px solid var(--vt-c-text-light-2);
  border-radius: 0.5em;
  color: var(--vt-c-text-dark-1)
}

form input {
  margin-right: 0.5rem;
}

form button {
  font-weight: 700;
}

.wrapper {
  max-width: 700px;
  background-color: var(--color-background-soft);
  padding: 1em 2em;
  margin: auto;
  border-radius: 2em;
}

.header-title .green-header-title,
.header-title .gray-header-title {
  font-family: 'Roboto';
  font-weight: 700;
}

.green-header-title {
  color: hsla(160, 100%, 37%, 1)
}

@media (min-width: 1024px) {
  .greetings h1, h2 {
    text-align: left;
  }
}
</style>
